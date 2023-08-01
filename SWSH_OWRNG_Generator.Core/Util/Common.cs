using PKHeX.Core;

namespace SWSH_OWRNG_Generator.Core.Util
{
    public class Common
    {
        private static readonly string[] PersonalityMarks = { "Rowdy", "AbsentMinded", "Jittery", "Excited", "Charismatic", "Calmness", "Intense", "ZonedOut", "Joyful", "Angry", "Smiley", "Teary", "Upbeat", "Peeved", "Intellectual", "Ferocious", "Crafty", "Scowling", "Kindly", "Flustered", "PumpedUp", "ZeroEnergy", "Prideful", "Unsure", "Humble", "Thorny", "Vigor", "Slump" };
        public static readonly IReadOnlyList<string> Natures = GameInfo.GetStrings(1).Natures;

        public static bool PassesNatureFilter(int Nature, string DesiredNature)
        {
            return DesiredNature == Natures[Nature] || DesiredNature == "Ignore";
        }

        public static bool PassesMarkFilter(string Mark, string DesiredMark)
        {
            return !(DesiredMark == "Any Mark" && Mark == "None" || DesiredMark == "Any Personality" && (Mark == "None" || Mark == "Uncommon" || Mark == "Time" || Mark == "Weather" || Mark == "Fishing" || Mark == "Rare") || DesiredMark != "Ignore" && DesiredMark != "Any Mark" && DesiredMark != "Any Personality" && Mark != DesiredMark);
        }

        public static bool PassesHeightFilter(int Scale, string DesiredHeight)
        {
            return DesiredHeight == "Ignore" ||
                (DesiredHeight == "XXXS (0)" && Scale == 0) ||
                (DesiredHeight == "XXS (1 - 24)" && Scale >= 1 && Scale <= 24) ||
                (DesiredHeight == "XS (25 - 59)" && Scale >= 25 && Scale <= 59) ||
                (DesiredHeight == "S (66 - 99)" && Scale >= 66 && Scale <= 99) ||
                (DesiredHeight == "M (100 - 155)" && Scale >= 100 && Scale <= 155) ||
                (DesiredHeight == "L (156 - 195)" && Scale >= 156 && Scale <= 195) ||
                (DesiredHeight == "XL (196 - 230)" && Scale >= 196 && Scale <= 230) ||
                (DesiredHeight == "XXL (231 - 245)" && Scale >= 231 && Scale <= 254) ||
                (DesiredHeight == "XXXL (255)" && Scale == 255) ||
                (DesiredHeight == "XXXS or XXXL" && (Scale == 0 || Scale == 255));
        }

        public static uint GetTSV(uint TID, uint SID)
        {
            return TID ^ SID;
        }

        public static (uint, uint) GenerateBrilliantInfo(uint KOs) => KOs switch
        {
            >= 500 => (30, 6),
            >= 300 => (30, 5),
            >= 200 => (30, 4),
            >= 100 => (30, 3),
            >= 50 => (25, 2),
            >= 20 => (20, 1),
            >= 1 => (15, 1),
            _ => (0, 0),
        };

        public static string GenerateHeightScale(uint Height) => Height switch
        {
            >= 255 => $"XXXL ({Height})",
            >= 231 => $"XXL ({Height})",
            >= 196 => $"XL ({Height})",
            >= 156 => $"L ({Height})",
            >= 100 => $"M ({Height})",
            >= 66 => $"S ({Height})",
            >= 25 => $"XS ({Height})",
            >= 1 => $"XXS ({Height})",
            _ => $"XXXS ({Height})",
        };

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

        public static (uint, uint, uint[], uint, bool, uint) CalculateFixed(uint FixedSeed, uint TSV, bool Shiny, int ForcedIVs, uint[] MinIVs, uint[] MaxIVs)
        {
            Xoroshiro128Plus go = new(FixedSeed, 0x82A2B175229D6A5B);
            uint FixedEC = (uint)go.Next();
            uint FixedPID = (uint)go.Next();
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
            bool PassIVs = true;
            for (int i = 0; i < ForcedIVs; i++)
            {
                uint FixedIVIndex = (uint)go.NextInt(6);
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

            for (int i = 0; i < 6 && PassIVs; i++)
            {
                if (IVs[i] == 32)
                    IVs[i] = (uint)go.NextInt(32);
                if (IVs[i] < MinIVs[i] || IVs[i] > MaxIVs[i])
                {
                    PassIVs = false;
                    break;
                }
            }

            uint Height = (uint)go.NextInt(129) + (uint)go.NextInt(128);
            // uint Weight = (uint)go.NextInt(129) + (uint)go.NextInt(128);

            return (FixedEC, FixedPID, IVs, GetTSV(GetTSV(FixedPID >> 16, FixedPID & 0xFFFF), TSV), PassIVs, Height);
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
                if (progress != null && i % ProgressUpdateInterval == 0)
                    progress.Report(1);
                ret += go.Next() & 1;
            }

            return ret;
        }
    }
}
