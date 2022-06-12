using PKHeX.Core;

namespace SWSH_OWRNG_Generator.Core.Loto_ID
{
    public class Generator
    {
        public static List<Frame> Generate(ulong state0, ulong state1, ulong advances, ulong InitialAdvances, HashSet<string> IDs, Filter Filters, uint NPCCount, IProgress<int> progress)
        {
            List<Frame> Results = new();

            Xoroshiro128Plus go = new(state0, state1);

            // Advance to starting frame
            for (ulong i = 0; i < InitialAdvances; i++)
            {
                go.Next();
            }

            ulong advance = 0;
            ulong ProgressUpdateInterval = advances / 100;
            if (ProgressUpdateInterval == 0)
                ProgressUpdateInterval++;

            string Jump = string.Empty;

            while (advance < advances)
            {
                if (progress != null && (advance % ProgressUpdateInterval == 0))
                    progress.Report(1);

                // Init new RNG
                (ulong s0, ulong s1) = go.GetState();
                Xoroshiro128Plus rng = new(s0, s1);
                if (Filters.MenuClose)
                {
                    Jump = $"+{MenuClose.Generator.GetAdvances(rng, NPCCount)}";
                    rng = MenuClose.Generator.Advance(ref rng, NPCCount);
                }
                uint _1 = (uint)rng.NextInt(10);
                uint _2 = (uint)rng.NextInt(10);
                uint _3 = (uint)rng.NextInt(10);
                uint _4 = (uint)rng.NextInt(10);
                uint _5 = (uint)rng.NextInt(10);

                uint Item = 0;
                foreach (string ID in IDs)
                {
                    if (ID[5] - '0' == _5)
                        Item = Math.Max(Item, 1);
                    if (ID[5] - '0' == _5 && ID[4] - '0' == _4)
                        Item = Math.Max(Item, 2);
                    if (ID[5] - '0' == _5 && ID[4] - '0' == _4 && ID[3] - '0' == _3)
                        Item = Math.Max(Item, 3);
                    if (ID[5] - '0' == _5 && ID[4] - '0' == _4 && ID[3] - '0' == _3 && ID[2] - '0' == _2)
                        Item = Math.Max(Item, 4);
                    if (ID[5] - '0' == _5 && ID[4] - '0' == _4 && ID[3] - '0' == _3 && ID[2] - '0' == _2 && ID[1] - '0' == _1)
                        Item = Math.Max(Item, 5);
                }

                if (
                    Item == 5 && !Filters.MasterBall ||
                    Item == 4 && !Filters.RareCandy ||
                    Item == 3 && !Filters.PPMax ||
                    Item == 2 && !Filters.PPUp ||
                    Item == 1 && !Filters.MooMoo ||
                    Item == 0 && !Filters.None
                )
                {
                    go.Next();
                    advance++;
                    continue;
                }

                // Passes all filters!
                (ulong _s0, ulong _s1) = go.GetState();
                Results.Add(
                    new Frame
                    {
                        Advances = (advance + InitialAdvances).ToString("N0"),
                        Animation = (_s0 & 1) ^ (_s1 & 1),
                        Jump = Jump,
                        ID = $"{_1}{_2}{_3}{_4}{_5}",
                        Prize = GetPrize(Item),
                        State0 = _s0.ToString("X16"),
                        State1 = _s1.ToString("X16"),
                    }
                );

                go.Next();
                advance++;
            }

            return Results;
        }

        private static string GetPrize(uint Item) => Item switch
        {
            >= 5 => "Master Ball",
            >= 4 => "Rare Candy",
            >= 3 => "PP Max",
            >= 2 => "PP Up",
            >= 1 => "Moomoo Milk",
            _ => "(None)",
        };
    }
}
