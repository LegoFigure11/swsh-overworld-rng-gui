namespace SWSH_OWRNG_Generator_GUI
{
    class Generator
    {
        private static string[] Natures = { "Hardy", "Lonely", "Brave", "Adamant", "Naughty", "Bold", "Docile", "Relaxed", "Impish", "Lax", "Timid", "Hasty", "Serious", "Jolly", "Naive", "Modest", "Mild", "Quiet", "Bashful", "Rash", "Calm", "Gentle", "Sassy", "Careful", "Quirky" };
        private static string[] PersonalityMarks = { "Rowdy", "AbsentMinded", "Jittery", "Excited", "Charismatic", "Calmness", "Intense", "ZonedOut", "Joyful", "Angry", "Smiley", "Teary", "Upbeat", "Peeved", "Intellectual", "Ferocious", "Crafty", "Scowling", "Kindly", "Flustered", "PumpedUp", "ZeroEnergy", "Prideful", "Unsure", "Humble", "Thorny", "Vigor", "Slump" };
        private static uint[] TemplateIVs = { 32, 32, 32, 32, 32, 32 };
        private static uint Max = (uint)System.Math.Pow(2, 32) - 1;
        public Generator()
        {
        }

        public static void Generate(
            ulong state0, ulong state1, ulong advances, uint TID, uint SID, bool ShinyCharm, bool MarkCharm, bool Weather,
            bool Static, bool Fishing, bool HeldItem, bool ExtraRoll, string DesiredMark, string DesiredShiny, uint LevelMin,
            uint LevelMax, uint SlotMin, uint SlotMax, uint[] MinIVs, uint[] MaxIVs
            )
        {
            int ShinyRolls = ShinyCharm ? 3 : 1;
            int MarkRolls = MarkCharm ? 3 : 1;
            uint TSV = GetTSV(TID, SID);
            uint[] IVs = TemplateIVs;
            bool GenerateLevel = LevelMin != LevelMax;
            uint LevelDelta = LevelMax - LevelMin + 1;
            bool Shiny = false;

            uint EC, PID, SlotRand, Level, BrilliantRand;
            string Mark;
            ulong advance = 0;

            Xoroshiro go = new Xoroshiro(state1, state0);

            while (advance < advances)
            {
                // Init new RNG
                Xoroshiro rng = new Xoroshiro(go.state0, go.state1);

                if (Static)
                {
                    rng.rand(100);
                }
                else
                {
                    rng.rand(Max);
                    rng.rand(100);
                    rng.rand(100);

                    SlotRand = (uint)rng.rand(100);
                    if (SlotMin > SlotRand || SlotMax < SlotRand)
                    {
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

                    Mark = GenerateMark(rng, Weather, Fishing, MarkRolls);
                    if (!ExtraRoll && DesiredMark != "Any" && Mark != DesiredMark)
                    {
                        go.next();
                        advance += 1;
                        continue;
                    }
                    BrilliantRand = (uint)rng.rand(1000);
                }

                Shiny = false;
                for (int roll = 0; roll < ShinyRolls; roll++)
                {
                    uint MockPID = rng.nextuint();
                    Shiny = (((MockPID >> 16) ^ (MockPID & 0xFFFF)) ^ TSV) < 16;
                    if (Shiny)
                        break;
                }

                go.next();
                advance += 1;
            }
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
    }




}
