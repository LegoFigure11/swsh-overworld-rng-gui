using PKHeX.Core;

namespace SWSH_OWRNG_Generator.Core.MenuClose
{
    public class Generator
    {
        public static ref Xoroshiro128Plus Advance(ref Xoroshiro128Plus rng, uint NPCs, byte Mode = (byte)MenuCloseType.Regular)
        {
            for (uint i = 0; i < NPCs; i++)
            {
                rng.NextInt(91);
            }
            rng.Next();
            rng.NextInt(60);
            if (Mode == (byte)MenuCloseType.HoldingDirection)
            {
                rng.NextInt(360);
            }
            else if (Mode == (byte)MenuCloseType.CaveRegular)
            {
                // Not implemented
            }
            else if (Mode == (byte)MenuCloseType.CaveHoldingDirection)
            {
                // Not implemented
            }
            return ref rng;
        }
        public static uint GetAdvances(Xoroshiro128Plus rng, uint NPCs, byte Mode = (byte)MenuCloseType.Regular)
        {
            (ulong _s0, ulong _s1) = rng.GetState();
            Advance(ref rng, NPCs, Mode);

            uint c = 0;
            while (c < 500) // Prevent infinite loop, 500 is generous because even at 99 we shouldn't see higher than ~150
            {
                if (rng.GetState() == (_s0, _s1))
                {
                    break;
                }
                c++;
                rng.Prev();
            }

            return c;
        }
    }
}
