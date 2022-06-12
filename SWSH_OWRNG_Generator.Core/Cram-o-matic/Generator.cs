using PKHeX.Core;

namespace SWSH_OWRNG_Generator.Core.Cram_o_matic
{
    public static class Generator
    {
        public static List<Frame> Generate(ulong state0, ulong state1, ulong advances, ulong InitialAdvances, int ItemIndex, IProgress<int> progress, Filter Filters, uint NPCCount)
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

                uint Slot = 4 - (uint)rng.NextInt(4); // Reverse order
                uint Ball = (uint)rng.NextInt(100);
                bool IsSportSafari = rng.NextInt(1000) == 0;

                string BallType = GetBall(Ball, IsSportSafari, ItemIndex);
                if (
                    BallType == "Poké Ball" && !Filters.Poke ||
                    BallType == "Great Ball" && !Filters.Great ||
                    BallType == "Shop Slot 1" && !Filters.Shop1 ||
                    BallType == "Shop Slot 2" && !Filters.Shop2 ||
                    BallType == "Apricorn" && !Filters.Apri ||
                    (BallType == "Sport" || BallType == "Safari") && !Filters.SafariSport
                    )
                {
                    go.Next();
                    advance++;
                    continue;
                }
                bool IsBonus = rng.NextInt((Ball == 99 || IsSportSafari) ? (ulong)1000 : 100) == 0;
                if (!IsBonus && Filters.BonusOnly)
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
                        Slot = Slot,
                        Ball = BallType,
                        Bonus = IsBonus,
                        State0 = _s0.ToString("X16"),
                        State1 = _s1.ToString("X16"),
                    }
                );

                go.Next();
                advance++;
            }

            return Results;
        }
        private static string GetBall(uint Roll, bool IsSportSafari, int ItemIndex)
        {
            if (IsSportSafari)
                return (ItemIndex == 0 ? "Safari" : "Sport");
            return GetBallFromRange(Roll);
        }

        private static string GetBallFromRange(uint Roll) => Roll switch
        {
            >= 99 => "Apricorn",
            >= 75 => "Shop Slot 2",
            >= 50 => "Shop Slot 1",
            >= 25 => "Great Ball",
            _ => "Poké Ball",
        };
    }
}
