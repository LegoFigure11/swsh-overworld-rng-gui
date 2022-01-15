using PKHeX.Core;
using System;
using System.Collections.Generic;

namespace SWSH_OWRNG_Generator_GUI
{
    class Generator
    {
        private static readonly string[] Natures = { "Hardy", "Lonely", "Brave", "Adamant", "Naughty", "Bold", "Docile", "Relaxed", "Impish", "Lax", "Timid", "Hasty", "Serious", "Jolly", "Naive", "Modest", "Mild", "Quiet", "Bashful", "Rash", "Calm", "Gentle", "Sassy", "Careful", "Quirky" };
        private static readonly string[] PersonalityMarks = { "Rowdy", "AbsentMinded", "Jittery", "Excited", "Charismatic", "Calmness", "Intense", "ZonedOut", "Joyful", "Angry", "Smiley", "Teary", "Upbeat", "Peeved", "Intellectual", "Ferocious", "Crafty", "Scowling", "Kindly", "Flustered", "PumpedUp", "ZeroEnergy", "Prideful", "Unsure", "Humble", "Thorny", "Vigor", "Slump" };

        // Heavily derived from https://github.com/Lincoln-LM/PyNXReader/
        public static List<Frame> Generate(
            ulong state0, ulong state1, ulong advances, uint TID, uint SID, bool ShinyCharm, bool MarkCharm, bool Weather,
            bool Static, bool Fishing, bool HeldItem, string DesiredMark, string DesiredShiny, string DesiredNature, uint LevelMin,
            uint LevelMax, uint SlotMin, uint SlotMax, uint[] MinIVs, uint[] MaxIVs, bool IsAbilityLocked, uint EggMoveCount,
            uint KOs, uint FlawlessIVs, bool IsCuteCharm, bool IsShinyLocked, bool TIDSIDSearch, ulong InitialAdvances, IProgress<int> progress
            )
        {
            List<Frame> Results = new List<Frame>();

            int ShinyRolls = ShinyCharm ? 3 : 1;
            int MarkRolls = MarkCharm ? 3 : 1;
            uint TSV = GetTSV(TID, SID);
            uint[] IVs;
            bool GenerateLevel = LevelMin != LevelMax;
            uint LevelDelta = LevelMax - LevelMin + 1;

            uint EC, PID, LeadRand = 0, SlotRand = 0, Level = 0, BrilliantRand, Nature, AbilityRoll, FixedSeed, ShinyXOR, BrilliantThreshold, BrilliantRolls;
            int BrilliantIVs;
            string Mark = "", Gender;
            bool PassIVs, Brilliant, Shiny;
            ulong advance = 0;

            (BrilliantThreshold, BrilliantRolls) = GenerateBrilliantInfo(KOs);

            ulong ProgressUpdateInterval = advances / 100;
            if (ProgressUpdateInterval == 0)
                ProgressUpdateInterval++;

            Xoroshiro128Plus go = new Xoroshiro128Plus(state0, state1);

            for (ulong i = 0; i < InitialAdvances; i++)
            {
                go.Next();
            }

            while (advance < advances)
            {
                if (progress != null && (advance % ProgressUpdateInterval == 0))
                    progress.Report(1);

                // Init new RNG
                (ulong s0, ulong s1) = go.GetState();
                Xoroshiro128Plus rng = new Xoroshiro128Plus(s0, s1);
                Brilliant = false;
                Gender = "";

                if (Static)
                {
                    LeadRand = (uint)rng.NextInt(100);
                    if (IsCuteCharm && LeadRand < 66)
                        Gender = "CC";
                }
                else
                {
                    if (!Fishing)
                        rng.NextInt();
                    rng.NextInt(100);
                    LeadRand = (uint)rng.NextInt(100);
                    if (IsCuteCharm && LeadRand < 66)
                        Gender = "CC";

                    SlotRand = (uint)rng.NextInt(100);
                    if (SlotMin > SlotRand || SlotMax < SlotRand)
                    {
                        if (TIDSIDSearch)
                            go.Prev();
                        else
                            go.Next();
                        advance += 1;
                        continue;
                    }

                    if (GenerateLevel)
                    {
                        Level = LevelMin + (uint)rng.NextInt(LevelDelta);
                    }
                    else
                    {
                        Level = LevelMin;
                    }

                    GenerateMark(rng, Weather, Fishing, MarkRolls); // Double Mark Gen happens always?
                    BrilliantRand = (uint)rng.NextInt(1000);
                    if (BrilliantRand < BrilliantThreshold)
                        Brilliant = true;

                }

                Shiny = false;
                uint MockPID = 0;
                if (!IsShinyLocked)
                {
                    for (int roll = 0; roll < ShinyRolls + (Brilliant ? BrilliantRolls : 0); roll++)
                    {
                        MockPID = (uint)rng.Next();
                        Shiny = (((MockPID >> 16) ^ (MockPID & 0xFFFF)) ^ TSV) < 16;
                        if (Shiny)
                            break;
                    }
                }

                if (Gender != "CC")
                    Gender = rng.NextInt(2) == 0 ? "F" : "M";
                Nature = (uint)rng.NextInt(25);
                AbilityRoll = 2;
                if (!IsAbilityLocked)
                    AbilityRoll = (uint)rng.NextInt(2);

                if (!Static && HeldItem)
                    rng.NextInt(100);

                BrilliantIVs = 0;
                if (Brilliant)
                {
                    BrilliantIVs = (int)rng.NextInt(2) | 2;
                    if (EggMoveCount > 1)
                        rng.NextInt(EggMoveCount);
                }

                FixedSeed = (uint)rng.Next();
                (EC, PID, IVs, ShinyXOR, PassIVs) = CalculateFixed(FixedSeed, TSV, Shiny, (int)(FlawlessIVs + BrilliantIVs), MinIVs, MaxIVs);

                if (TIDSIDSearch)
                {
                    ShinyXOR = 0;
                }

                if (!PassIVs ||
                    (DesiredShiny == "Square" && ShinyXOR != 0) ||
                    (DesiredShiny == "Star" && (ShinyXOR > 15 || ShinyXOR == 0)) ||
                    (DesiredShiny == "Star/Square" && ShinyXOR > 15) ||
                    (DesiredShiny == "No" && ShinyXOR < 16)
                    )
                {
                    if (TIDSIDSearch)
                        go.Prev();
                    else
                        go.Next();
                    advance += 1;
                    continue;
                }

                Mark = GenerateMark(rng, Weather, Fishing, MarkRolls);

                if (!PassesMarkFilter(Mark, DesiredMark))
                {
                    if (TIDSIDSearch)
                        go.Prev();
                    else
                        go.Next();
                    advance += 1;
                    continue;
                }

                if (!PassesNatureFilter(Natures[Nature], DesiredNature))
                {
                    if (TIDSIDSearch)
                        go.Prev();
                    else
                        go.Next();
                    advance += 1;
                    continue;
                }

                // Passes all filters!
                (ulong _s0, ulong _s1) = go.GetState();
                Results.Add(
                    new Frame()
                    {
                        Advances = TIDSIDSearch ? (-(long)(advance + InitialAdvances)).ToString("N0") : (advance + InitialAdvances).ToString("N0"),
                        TID = (ushort)(MockPID >> 16),
                        SID = (ushort)MockPID,
                        Animation = _s0 & 1 ^ _s1 & 1,
                        Level = Level,
                        Slot = SlotRand,
                        PID = PID.ToString("X8"),
                        EC = EC.ToString("X8"),
                        Shiny = ShinyXOR == 0 ? "Square" : (ShinyXOR < 16 ? "Star" : "No"),
                        Brilliant = Brilliant ? "Y" : "-",
                        Ability = AbilityRoll == 0 ? 1 : 0,
                        Nature = Natures[Nature],
                        Gender = Gender,
                        HP = IVs[0],
                        Atk = IVs[1],
                        Def = IVs[2],
                        SpA = IVs[3],
                        SpD = IVs[4],
                        Spe = IVs[5],
                        Mark = Mark,
                        State0 = _s0.ToString("X16"),
                        State1 = _s1.ToString("X16"),
                    }
                );

                if (TIDSIDSearch)
                    go.Prev();
                else
                    go.Next();
                advance += 1;
            }

            return Results;
        }

        public static uint GetTSV(uint TID, uint SID)
        {
            return TID ^ SID;
        }

        public static string GenerateMark(Xoroshiro128Plus go, bool Weather, bool Fishing, int MarkRolls)
        {
            for (int i = 0; i < MarkRolls; i++)
            {
                uint rare = (uint)go.NextInt(1000);
                uint pers = (uint)go.NextInt(100);
                uint unco = (uint)go.NextInt(50);
                uint weat = (uint)go.NextInt(50);
                uint time = (uint)go.NextInt(50);
                uint fish = (uint)go.NextInt(25);

                if (rare == 0) return "Rare";
                if (pers == 0) return PersonalityMarks[go.NextInt(28)];
                if (unco == 0) return "Uncommon";
                if (weat == 0 && Weather) return "Weather";
                if (time == 0) return "Time";
                if (fish == 0 && Fishing) return "Fish";
            }
            return "None";
        }

        private static uint FixedEC, FixedPID, FixedIVIndex, i;
        private static bool PassIVs;
        public static (uint, uint, uint[], uint, bool) CalculateFixed(uint FixedSeed, uint TSV, bool Shiny, int ForcedIVs, uint[] MinIVs, uint[] MaxIVs)
        {
            Xoroshiro128Plus go = new Xoroshiro128Plus(FixedSeed, 0x82A2B175229D6A5B);
            FixedEC = (uint)go.Next();
            FixedPID = (uint)go.Next();
            if (!Shiny)
            {
                if (((FixedPID >> 16) ^ (FixedPID & 0xFFFF) ^ TSV) < 16)
                    FixedPID ^= 0x10000000; // Antishiny
            }
            else
            {
                if (!(((FixedPID >> 16) ^ (FixedPID & 0xFFFF) ^ TSV) < 16))
                    FixedPID = (((TSV ^ (FixedPID & 0xFFFF)) << 16) | (FixedPID & 0xFFFF)) & 0xFFFFFFFF;
            }

            uint[] IVs = { 32, 32, 32, 32, 32, 32 };
            PassIVs = true;
            for (i = 0; i < ForcedIVs; i++)
            {
                FixedIVIndex = (uint)go.NextInt(6);
                while (IVs[FixedIVIndex] != 32)
                {
                    FixedIVIndex = (uint)go.NextInt(6);
                }
                IVs[FixedIVIndex] = 31;
                if (IVs[FixedIVIndex] > MaxIVs[FixedIVIndex])
                {
                    PassIVs = false;
                    break;
                }
            }

            for (i = 0; i < 6 && PassIVs; i++)
            {
                if (IVs[i] == 32)
                    IVs[i] = (uint)go.NextInt(32);
                if (IVs[i] < MinIVs[i] || IVs[i] > MaxIVs[i])
                {
                    PassIVs = false;
                    break;
                }
            }

            return (FixedEC, FixedPID, IVs, GetTSV(FixedPID >> 16, FixedPID & 0xFFFF) ^ TSV, PassIVs);
        }

        private static bool PassesMarkFilter(string Mark, string DesiredMark)
        {
            return !((DesiredMark == "Any Mark" && Mark == "None") || (DesiredMark == "Any Personality" && (Mark == "None" || Mark == "Uncommon" || Mark == "Time" || Mark == "Weather" || Mark == "Fishing" || Mark == "Rare")) || (DesiredMark != "Ignore" && DesiredMark != "Any Mark" && DesiredMark != "Any Personality" && Mark != DesiredMark));
        }

        private static bool PassesNatureFilter(string Nature, string DesiredNature)
        {
            return ((DesiredNature == Nature) || (DesiredNature == "Ignore"));
        }

        private static (uint, uint) GenerateBrilliantInfo(uint KOs)
        {
            if (KOs >= 500) return (30, 6);
            if (KOs >= 300) return (30, 5);
            if (KOs >= 200) return (30, 4);
            if (KOs >= 100) return (30, 3);
            if (KOs >= 50) return (25, 2);
            if (KOs >= 20) return (20, 1);
            if (KOs >= 1) return (15, 1);
            return (0, 0);
        }

        public static string GenerateRetailSequence(ulong state0, ulong state1, uint start, uint max, IProgress<int> progress)
        {
            Xoroshiro128Plus go = new Xoroshiro128Plus(state0, state1);
            for (int i = 0; i < start; i++)
                go.Next();

            string ret = String.Empty;
            ulong ProgressUpdateInterval = (start + max) / 100;
            if (ProgressUpdateInterval == 0)
                ProgressUpdateInterval++;

            for (uint i = 0; i < max; i++)
            {
                if (progress != null && (i % ProgressUpdateInterval == 0))
                    progress.Report(1);
                ret += go.Next() & 1;
            }

            return ret;
        }
    }




}
