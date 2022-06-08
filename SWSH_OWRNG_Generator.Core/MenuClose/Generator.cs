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
        public static uint Generate(ulong state0, ulong state1, uint NPCs)
        {
            Xoroshiro128Plus rng = new(state0, state1);
            for (uint i = 0; i < NPCs; i++)
            {
                rng.NextInt(91);
            }
            rng.Next();
            rng.NextInt(60);

            uint c = 0;
            while (c < 500) // Prevent infinite loop in case we never find our starting position
            {
                if (rng.GetState() == (state0, state1))
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
