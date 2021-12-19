using System;
using System.Collections.Generic;

namespace SWSH_OWRNG_Generator_GUI
{
    class Generator
    {
        private static readonly string[] Natures = { "Hardy", "Lonely", "Brave", "Adamant", "Naughty", "Bold", "Docile", "Relaxed", "Impish", "Lax", "Timid", "Hasty", "Serious", "Jolly", "Naive", "Modest", "Mild", "Quiet", "Bashful", "Rash", "Calm", "Gentle", "Sassy", "Careful", "Quirky" };
        private static readonly string[] PersonalityMarks = { "Rowdy", "AbsentMinded", "Jittery", "Excited", "Charismatic", "Calmness", "Intense", "ZonedOut", "Joyful", "Angry", "Smiley", "Teary", "Upbeat", "Peeved", "Intellectual", "Ferocious", "Crafty", "Scowling", "Kindly", "Flustered", "PumpedUp", "ZeroEnergy", "Prideful", "Unsure", "Humble", "Thorny", "Vigor", "Slump" };
        private static readonly uint Max = (uint)Math.Pow(2, 32) - 1;

        // Heavily derived from https://github.com/Lincoln-LM/PyNXReader/
        public static List<Frame> Generate(
            ulong state0, ulong state1, ulong advances, uint TID, uint SID, bool ShinyCharm, bool MarkCharm, bool Weather,
            bool Static, bool Fishing, bool HeldItem, string DesiredMark, string DesiredShiny, uint LevelMin,
            uint LevelMax, uint SlotMin, uint SlotMax, uint[] MinIVs, uint[] MaxIVs, bool IsAbilityLocked, uint EggMoveCount,
            uint KOs, uint FlawlessIVs, bool TIDSIDSearch, IProgress<int> progress
            )
        {
            List<Frame> Results = new List<Frame>();

            int ShinyRolls = ShinyCharm ? 3 : 1;
            int MarkRolls = MarkCharm ? 3 : 1;
            uint TSV = GetTSV(TID, SID);
            uint[] IVs;
            bool GenerateLevel = LevelMin != LevelMax;
            uint LevelDelta = LevelMax - LevelMin + 1;

            uint EC, PID, SlotRand = 0, Level = 0, BrilliantRand, Nature, AbilityRoll, FixedSeed, ShinyXOR, BrilliantThreshold, BrilliantRolls;
            int BrilliantIVs;
            string Mark = "";
            bool PassIVs, Brilliant, Shiny;
            ulong advance = 0;

            (BrilliantThreshold, BrilliantRolls) = GenerateBrilliantInfo(KOs);

            ulong ProgressUpdateInterval = advances / 100;
            if (ProgressUpdateInterval == 0)
                ProgressUpdateInterval++;

            Xoroshiro go = new Xoroshiro(state0, state1);

            while (advance < advances)
            {
                if (progress != null && (advance % ProgressUpdateInterval == 0))
                    progress.Report(1);

                // Init new RNG
                Xoroshiro rng = new Xoroshiro(go.state0, go.state1);
                Brilliant = false;
                if (Static)
                {
                    rng.rand(100);
                }
                else
                {
                    if (!Fishing)
                        rng.rand(Max);
                    rng.rand(100);
                    rng.rand(100);

                    SlotRand = (uint)rng.rand(100);
                    if (SlotMin > SlotRand || SlotMax < SlotRand)
                    {
                        if (TIDSIDSearch)
                            go.previous();
                        else
                            go.next();
                        advance += 1;
                        continue;
                    }

                    if (GenerateLevel)
                    {
                        Level = LevelMin + (uint)rng.rand(LevelDelta);
                    }
                    else
                    {
                        Level = LevelMin;
                    }

                    GenerateMark(rng, Weather, Fishing, MarkRolls); // Double Mark Gen happens always?
                    BrilliantRand = (uint)rng.rand(1000);
                    if (BrilliantRand < BrilliantThreshold)
                        Brilliant = true;

                }

                Shiny = false;
                uint MockPID = 0;
                for (int roll = 0; roll < ShinyRolls + (Brilliant ? BrilliantRolls : 0); roll++)
                {
                    MockPID = rng.nextuint();
                    Shiny = (((MockPID >> 16) ^ (MockPID & 0xFFFF)) ^ TSV) < 16;
                    if (Shiny)
                        break;
                }

                rng.rand(2); // Mystery
                Nature = (uint)rng.rand(25);
                AbilityRoll = 2;
                if (!IsAbilityLocked)
                    AbilityRoll = (uint)rng.rand(2);

                if (!Static && HeldItem)
                    rng.rand(100);

                BrilliantIVs = 0;
                if (Brilliant)
                {
                    BrilliantIVs = (int)rng.rand(2) | 2;
                    rng.rand(EggMoveCount);
                }

                FixedSeed = rng.nextuint();
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
                        go.previous();
                    else
                        go.next();
                    advance += 1;
                    continue;
                }

                Mark = GenerateMark(rng, Weather, Fishing, MarkRolls);

                if (!PassesMarkFilter(Mark, DesiredMark))
                {
                    if (TIDSIDSearch)
                        go.previous();
                    else
                        go.next();
                    advance += 1;
                    continue;
                }

                // Passes all filters!
                Results.Add(
                    new Frame()
                    {
                        Advances = TIDSIDSearch ? (-(long)advance).ToString("N0") : advance.ToString("N0"),
                        TID = (ushort)(MockPID >> 16),
                        SID = (ushort)MockPID,
                        Animation = go.state0 & 1 ^ go.state1 & 1,
                        Level = Level,
                        Slot = SlotRand,
                        PID = PID.ToString("X8"),
                        EC = EC.ToString("X8"),
                        Shiny = ShinyXOR == 0 ? "Square" : (ShinyXOR < 16 ? "Star" : "No"),
                        Brilliant = Brilliant ? "Y" : "-",
                        Ability = AbilityRoll == 0 ? 1 : 0,
                        Nature = Natures[Nature],
                        HP = IVs[0],
                        Atk = IVs[1],
                        Def = IVs[2],
                        SpA = IVs[3],
                        SpD = IVs[4],
                        Spe = IVs[5],
                        Mark = Mark,
                        State0 = go.state0.ToString("X16"),
                        State1 = go.state1.ToString("X16"),
                    }
                );

                if (TIDSIDSearch)
                    go.previous();
                else
                    go.next();
                advance += 1;
            }

            return Results;
        }

        public static uint GetTSV(uint TID, uint SID)
        {
            return TID ^ SID;
        }

        public static string GenerateMark(Xoroshiro go, bool Weather, bool Fishing, int MarkRolls)
        {
            for (int i = 0; i < MarkRolls; i++)
            {
                uint rare = (uint)go.rand(1000);
                uint pers = (uint)go.rand(100);
                uint unco = (uint)go.rand(50);
                uint weat = (uint)go.rand(50);
                uint time = (uint)go.rand(50);
                uint fish = (uint)go.rand(25);

                if (rare == 0) return "Rare";
                if (pers == 0) return PersonalityMarks[go.rand(28)];
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
            Xoroshiro go = new Xoroshiro(FixedSeed, 0x82A2B175229D6A5B);
            FixedEC = go.nextuint();
            FixedPID = go.nextuint();
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
                FixedIVIndex = (uint)go.rand(6);
                while (IVs[FixedIVIndex] != 32)
                {
                    FixedIVIndex = (uint)go.rand(6);
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
                    IVs[i] = (uint)go.rand(32);
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
            Xoroshiro go = new Xoroshiro(state0, state1);
            for (int i = 0; i < start; i++)
                go.next();

            string ret = String.Empty;
            ulong ProgressUpdateInterval = (start + max) / 100;
            if (ProgressUpdateInterval == 0)
                ProgressUpdateInterval++;

            for (uint i = 0; i < max; i++)
            {
                if (progress != null && (i % ProgressUpdateInterval == 0))
                    progress.Report(1);
                ret += go.next() & 1;
            }

            return ret;
        }
    }




}
