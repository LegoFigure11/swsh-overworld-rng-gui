﻿using PKHeX.Core;

namespace SWSH_OWRNG_Generator.Core
{
    public static class Generator
    {
        private static readonly IReadOnlyList<string> Natures = GameInfo.GetStrings(1).Natures;
        private static readonly string[] PersonalityMarks = { "Rowdy", "AbsentMinded", "Jittery", "Excited", "Charismatic", "Calmness", "Intense", "ZonedOut", "Joyful", "Angry", "Smiley", "Teary", "Upbeat", "Peeved", "Intellectual", "Ferocious", "Crafty", "Scowling", "Kindly", "Flustered", "PumpedUp", "ZeroEnergy", "Prideful", "Unsure", "Humble", "Thorny", "Vigor", "Slump" };

        // Heavily derived from https://github.com/Lincoln-LM/PyNXReader/
        public static List<Frame> Generate(ulong state0, ulong state1, ulong advances, ulong InitialAdvances, IProgress<int> progress, Overworld.Filter Filters, uint NPCs)
        {
            List<Frame> Results = new();

            uint[] IVs;
            bool GenerateLevel = Filters.LevelMin != Filters.LevelMax;
            uint LevelDelta = Filters.LevelMax - Filters.LevelMin + 1;
            uint EC;
            uint PID;
            uint SlotRand = 0;
            uint Level = 0;
            uint BrilliantRand;
            uint Nature;
            uint AbilityRoll;
            uint FixedSeed;
            uint ShinyXOR;
            uint BrilliantThreshold;
            uint BrilliantRolls;
            int BrilliantIVs;
            string Gender;
            bool PassIVs, Brilliant, Shiny;
            ulong advance = 0;
            string Jump = string.Empty;

            (BrilliantThreshold, BrilliantRolls) = Util.Common.GenerateBrilliantInfo(Filters.KOs);

            ulong ProgressUpdateInterval = advances / 100;
            if (ProgressUpdateInterval == 0)
                ProgressUpdateInterval++;

            Xoroshiro128Plus go = new(state0, state1);

            for (ulong i = 0; i < InitialAdvances; i++)
            {
                go.Next();
            }

            while (advance < advances)
            {
                if (progress != null && (advance % ProgressUpdateInterval == 0))
                    progress.Report(1);
                long totalRolls = 1; // Placeholder to ensure this is run once normally, also accounts for rolls not being determined yet
                for (long rollToCheck = 0; rollToCheck < totalRolls; rollToCheck++)
                {
                    // Init new RNG
                    (ulong s0, ulong s1) = go.GetState();
                    Xoroshiro128Plus rng = new(s0, s1);
                    if (Filters.MenuClose)
                    {
                        Jump = $"+{MenuClose.Generator.GetAdvances(rng, NPCs)}";
                        rng = MenuClose.Generator.Advance(ref rng, NPCs);
                    }
                    Brilliant = false;
                    Gender = "";
                    uint LeadRand;
                    if (Filters.Static)
                    {
                        LeadRand = (uint)rng.NextInt(100);
                        if (Filters.CuteCharm && LeadRand < 66)
                            Gender = "CC";
                    }
                    else
                    {
                        if (!Filters.Fishing)
                            rng.NextInt();
                        rng.NextInt(100);

                        LeadRand = (uint)rng.NextInt(100);
                        if (Filters.CuteCharm && LeadRand < 66)
                            Gender = "CC";

                        SlotRand = (uint)rng.NextInt(100);
                        if (Filters.SlotMin > SlotRand || Filters.SlotMax < SlotRand)
                            continue;

                        if (GenerateLevel)
                        {
                            Level = Filters.LevelMin + (uint)rng.NextInt(LevelDelta);
                        }
                        else
                        {
                            Level = Filters.LevelMin;
                        }

                        GenerateMark(ref rng, Filters.Weather, Filters.Fishing, Filters.MarkRolls); // Double Mark Gen happens always

                        if (!Filters.Hidden)
                        {
                            BrilliantRand = (uint)rng.NextInt(1000);
                            if (BrilliantRand < BrilliantThreshold)
                            {
                                Brilliant = true;
                                Level = Filters.LevelMax;
                            }
                            if ((Filters.DesiredAura == "Brilliant" && !Brilliant) || (Filters.DesiredAura == "None" && Brilliant))
                                continue;
                        }
                    }

                    Shiny = false;
                    uint MockPID = 0;
                    if (Filters.TIDSIDSearch)
                        totalRolls = Filters.ShinyRolls + (Brilliant ? BrilliantRolls : 0);
                    if (!Filters.ShinyLocked)
                    {
                        for (int roll = 0; roll < Filters.ShinyRolls + (Brilliant ? BrilliantRolls : 0); roll++)
                        {
                            MockPID = (uint)rng.Next();
                            if (Filters.TIDSIDSearch)
                            {
                                Shiny = roll == rollToCheck; // Account for pid loop ending early
                                Filters.TSV = Util.Common.GetTSV(MockPID >> 16, MockPID & 0xFFFF);
                            }
                            else
                                Shiny = Util.Common.GetTSV(Util.Common.GetTSV(MockPID >> 16, MockPID & 0xFFFF), Filters.TSV) < 16;
                            if (Shiny)
                                break;
                        }
                    }

                    if (Gender != "CC")
                        Gender = rng.NextInt(2) == 0 ? "F" : "M";
                    Nature = (uint)rng.NextInt(25);
                    AbilityRoll = 2;
                    if (!Filters.AbilityLocked)
                        AbilityRoll = (uint)rng.NextInt(2);

                    if (!Filters.Static && Filters.HeldItem)
                        rng.NextInt(100); // Held Item

                    BrilliantIVs = 0;
                    if (Brilliant)
                    {
                        BrilliantIVs = (int)rng.NextInt(2) | 2;
                        if (Filters.EggMoveCount > 1)
                            rng.NextInt(Filters.EggMoveCount); // Egg Move Index
                    }

                    FixedSeed = (uint)rng.Next();
                    (EC, PID, IVs, ShinyXOR, PassIVs) = CalculateFixed(FixedSeed, Filters.TSV, Shiny, (int)(Filters.FlawlessIVs + BrilliantIVs), Filters.MinIVs!, Filters.MaxIVs!);

                    if (!PassIVs ||
                        (Filters.DesiredShiny == "Square" && ShinyXOR != 0) ||
                        (Filters.DesiredShiny == "Star" && (ShinyXOR > 15 || ShinyXOR == 0)) ||
                        (Filters.DesiredShiny == "Star/Square" && ShinyXOR > 15) ||
                        (Filters.DesiredShiny == "No" && ShinyXOR < 16)
                        )
                        continue;

                    string Mark = GenerateMark(ref rng, Filters.Weather, Filters.Fishing, Filters.MarkRolls);

                    if (!PassesMarkFilter(Mark, Filters.DesiredMark!))
                        continue;

                    if (!PassesNatureFilter(Natures[(int)Nature], Filters.DesiredNature!))
                        continue;

                    // Passes all filters!
                    (ulong _s0, ulong _s1) = go.GetState();
                    Results.Add(
                        new Frame
                        {
                            Advances = Filters.TIDSIDSearch ? $"{(-(long)(advance + InitialAdvances)):N0} | Roll: {rollToCheck:N0}" : (advance + InitialAdvances).ToString("N0"),
                            TID = (ushort)(MockPID >> 16),
                            SID = (ushort)MockPID,
                            Animation = (_s0 & 1) ^ (_s1 & 1),
                            Jump = Jump,
                            Level = Level,
                            Slot = SlotRand,
                            PID = PID.ToString("X8"),
                            EC = EC.ToString("X8"),
                            Shiny = ShinyXOR == 0 ? "Square" : (ShinyXOR < 16 ? "Star" : "No"),
                            Brilliant = Brilliant ? "Y" : "-",
                            Ability = AbilityRoll == 0 ? 1 : 0,
                            Nature = Natures[(int)Nature],
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
                }
                if (Filters.TIDSIDSearch)
                    go.Prev();
                else
                    go.Next();
                advance++;
            }

            return Results;
        }

        public static string GenerateMark(ref Xoroshiro128Plus go, bool Weather, bool Fishing, int MarkRolls)
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
                if (fish == 0 && Fishing) return "Fishing";
            }
            return "None";
        }

        private static uint FixedEC, FixedPID, FixedIVIndex, i;
        private static bool PassIVs;
        public static (uint, uint, uint[], uint, bool) CalculateFixed(uint FixedSeed, uint TSV, bool Shiny, int ForcedIVs, uint[] MinIVs, uint[] MaxIVs)
        {
            Xoroshiro128Plus go = new(FixedSeed, 0x82A2B175229D6A5B);
            FixedEC = (uint)go.Next();
            FixedPID = (uint)go.Next();
            if (!Shiny)
            {
                if (((FixedPID >> 16) ^ (FixedPID & 0xFFFF) ^ TSV) < 16)
                    FixedPID ^= 0x10000000; // Antishiny
            }
            else
            {
                if (((FixedPID >> 16) ^ (FixedPID & 0xFFFF) ^ TSV) >= 16)
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

            return (FixedEC, FixedPID, IVs, Util.Common.GetTSV(Util.Common.GetTSV(FixedPID >> 16, FixedPID & 0xFFFF), TSV), PassIVs);
        }

        private static bool PassesMarkFilter(string Mark, string DesiredMark)
        {
            return !((DesiredMark == "Any Mark" && Mark == "None") || (DesiredMark == "Any Personality" && (Mark == "None" || Mark == "Uncommon" || Mark == "Time" || Mark == "Weather" || Mark == "Fishing" || Mark == "Rare")) || (DesiredMark != "Ignore" && DesiredMark != "Any Mark" && DesiredMark != "Any Personality" && Mark != DesiredMark));
        }

        private static bool PassesNatureFilter(string Nature, string DesiredNature)
        {
            return (DesiredNature == Nature) || (DesiredNature == "Ignore");
        }

        public static string GenerateRetailSequence(ulong state0, ulong state1, uint start, uint max, IProgress<int> progress)
        {
            Xoroshiro128Plus go = new(state0, state1);
            for (int i = 0; i < start; i++)
                go.Next();

            string ret = string.Empty;
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
