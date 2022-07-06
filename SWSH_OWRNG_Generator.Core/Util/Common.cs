using PKHeX.Core;

namespace SWSH_OWRNG_Generator.Core.Util
{
    public class Common
    {
        private static readonly string[] PersonalityMarks = { "Rowdy", "AbsentMinded", "Jittery", "Excited", "Charismatic", "Calmness", "Intense", "ZonedOut", "Joyful", "Angry", "Smiley", "Teary", "Upbeat", "Peeved", "Intellectual", "Ferocious", "Crafty", "Scowling", "Kindly", "Flustered", "PumpedUp", "ZeroEnergy", "Prideful", "Unsure", "Humble", "Thorny", "Vigor", "Slump" };

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
        public static (uint, uint, uint[], uint, bool) CalculateFixed(uint FixedSeed, uint TSV, bool Shiny, int ForcedIVs, uint[] MinIVs, uint[] MaxIVs)
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

            // uint Height = (uint)go.NextInt(129) + (uint)go.NextInt(128);
            // uint Weight = (uint)go.NextInt(129) + (uint)go.NextInt(128);

            return (FixedEC, FixedPID, IVs, GetTSV(GetTSV(FixedPID >> 16, FixedPID & 0xFFFF), TSV), PassIVs);
        }
    }
}
