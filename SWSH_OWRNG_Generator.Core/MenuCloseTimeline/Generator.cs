using PKHeX.Core;

namespace SWSH_OWRNG_Generator.Core.MenuCloseTimeline
{
    public class Generator
    {
        public static List<Frame> Generate(ulong state0, ulong state1, ulong advances, ulong InitialAdvances, uint NPCCount, IProgress<int> progress)
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

                uint num = MenuClose.Generator.GetAdvances(go, NPCCount);
                Jump = $"+{num}";

                (ulong _s0, ulong _s1) = go.GetState();
                Results.Add(
                    new Frame
                    {
                        Advances = (advance + InitialAdvances).ToString("N0"),
                        Jump = Jump,
                        State0 = _s0.ToString("X16"),
                        State1 = _s1.ToString("X16"),
                    }
                );

                MenuClose.Generator.Advance(ref go, NPCCount);
                advance += num;
            }

            return Results;
        }
    }
}