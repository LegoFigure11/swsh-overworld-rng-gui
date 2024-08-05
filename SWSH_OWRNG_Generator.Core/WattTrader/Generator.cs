using PKHeX.Core;

namespace SWSH_OWRNG_Generator.Core.WattTrader
{
    public static class Generator
    {
        public static List<Frame> Generate(ulong state0, ulong state1, ulong advances, ulong InitialAdvances, IProgress<int> progress, Filter Filters, uint NPCCount)
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

                uint Highlight = (uint)rng.NextInt(1000);
                if (Highlight < Filters.SlotMin || Highlight > Filters.SlotMax)
                {
                    go.Next();
                    advance++;
                    continue;
                }
                uint Regular = (uint)rng.NextInt(9);

                // Passes all filters!
                (ulong _s0, ulong _s1) = go.GetState();
                Results.Add(
                    new Frame
                    {
                        Advances = (advance + InitialAdvances).ToString("N0"),
                        Animation = (_s0 & 1) ^ (_s1 & 1),
                        Jump = Jump,
                        Highlight = $"{GetHighlightItem(Highlight)} ({Highlight:N0})",
                        Regular = $"{Regular}",
                        State0 = _s0.ToString("X16"),
                        State1 = _s1.ToString("X16"),
                    }
                );

                go.Next();
                advance++;
            }

            return Results;
        }

        private static string GetHighlightItem(uint Roll) => Roll switch
        {
            >= 980 => "King's Rock x1",
            >= 969 => "Chipped Pot x1",
            >= 939 => "Cracked Pot x1",
            >= 909 => "Magmarizer x1",
            >= 879 => "Electirizer x1",
            >= 869 => "Lucky Egg x1",
            >= 859 => "Starf Berry x1",
            >= 829 => "Lansat Berry x1",
            >= 828 => "Dream Ball x1",
            >= 827 => "Beast Ball x1",
            >= 797 => "Big Nugget x1",
            >= 782 => "Ribbon Sweet x1",
            >= 767 => "Star Sweet x1",
            >= 752 => "Flower Sweet x1",
            >= 737 => "Clover Sweet x1",
            >= 722 => "Berry Sweet x1",
            >= 707 => "Love Sweet x1",
            >= 692 => "Strawberry Sweet x1",
            >= 682 => "Galarica Twig x5",
            >= 642 => "Galarica Twig x3",
            >= 602 => "Max Elixir x1",
            >= 582 => "Max Mushrooms x1",
            >= 577 => "Dynite Ore x5",
            >= 557 => "Dynite Ore x1",
            >= 552 => "Armorite Ore x8",
            >= 532 => "Armorite Ore x3",
            >= 472 => "Armorite Ore x1",
            >= 422 => "Gigantamix x1",
            >= 382 => "Rare Candy x5",
            >= 332 => "Rare Candy x1",
            >= 327 => "PP Max x1",
            >= 302 => "PP Up x2",
            >= 252 => "PP Up x1",
            >= 242 => "Pink Apricorn x10",
            >= 232 => "Black Apricorn x10",
            >= 222 => "White Apricorn x10",
            >= 212 => "Green Apricorn x10",
            >= 202 => "Yellow Apricorn x10",
            >= 192 => "Blue Apricorn x10",
            >= 182 => "Red Apricorn x10",
            >= 165 => "Pink Apricorn x5",
            >= 148 => "Black Apricorn x5",
            >= 131 => "White Apricorn x5",
            >= 114 => "Green Apricorn x5",
            >= 97 => "Yellow Apricorn x5",
            >= 80 => "Blue Apricorn x5",
            >= 63 => "Red Apricorn x5",
            >= 60 => "Gold Bottle Cap x1",
            >= 50 => "Bottle Cap x3",
            _ => "Bottle Cap x1",
        };
    }
}
