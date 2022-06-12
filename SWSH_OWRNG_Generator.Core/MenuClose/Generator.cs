using PKHeX.Core;

namespace SWSH_OWRNG_Generator.Core.MenuClose
{
    public class Generator
    {
        public static ref Xoroshiro128Plus Advance(ref Xoroshiro128Plus rng, uint NPCs)
        {
            for (uint i = 0; i < NPCs; i++)
            {
                rng.NextInt(91);
            }
            rng.Next();
            rng.NextInt(60);
            return ref rng;
        }
        public static uint GetAdvances(Xoroshiro128Plus rng, uint NPCs)
        {
            (ulong _s0, ulong _s1) = rng.GetState();
            Advance(ref rng, NPCs);

            uint c = 0;
            while (c < 500) // Prevent infinite loop in case we never find our starting position
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
