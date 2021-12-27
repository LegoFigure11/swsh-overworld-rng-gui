namespace SWSH_OWRNG_Generator_GUI
{
    public class Xoroshiro
    {
        public ulong state0, state1;

        public Xoroshiro(ulong s0, ulong s1)
        {
            state0 = s0;
            state1 = s1;
        }

        ulong State()
        {
            ulong s0 = this.state0;
            ulong s1 = this.state1;
            return s0 | (s1 << 64);
        }

        private static ulong RotateLeft(ulong x, int k)
        {
            return (x << k) | (x >> (64 - k));
        }

        public ulong Next()
        {
            ulong s0 = state0;
            ulong s1 = state1;
            ulong result = s0 + s1;
            s1 ^= s0;
            state0 = RotateLeft(s0, 24) ^ s1 ^ (s1 << 16);
            state1 = RotateLeft(s1, 37);
            return result;
        }

        public ulong Previous()
        {
            ulong s0 = state0;
            ulong s1 = state1;
            s1 = RotateLeft(s1, 27);
            s0 = s0 ^ s1 ^ (s1 << 16);
            s0 = RotateLeft(s0, 40);
            s1 ^= s0;
            state0 = s0;
            state1 = s1;
            ulong result = s0 + s1;
            return result;
        }

        public uint NextUInt()
        {
            return (uint)Next();
        }

        uint GetMask(uint x)
        {
            x -= 1;
            x |= x >> 1;
            x |= x >> 2;
            x |= x >> 4;
            x |= x >> 8;
            x |= x >> 16;
            return x;
        }

        public ulong Rand(uint n = 0xFFFFFFFF)
        {
            uint mask = GetMask(n);
            ulong res = Next() & mask;
            while (res >= n)
            {
                res = Next() & mask;
            }
            return res;
        }
    }
}
