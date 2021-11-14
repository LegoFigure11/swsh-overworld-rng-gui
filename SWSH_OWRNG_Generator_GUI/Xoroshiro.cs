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

        ulong state()
        {
            ulong s0 = this.state0;
            ulong s1 = this.state1;
            return s0 | (s1 << 64);
        }

        private static ulong rotl(ulong x, int k)
        {
            return (ulong)((x << k) | (x >> (64 - k)));
        }

        public ulong next()
        {
            ulong s0 = state0;
            ulong s1 = state1;
            ulong result = (ulong)((s0 + s1));
            s1 ^= s0;
            state0 = rotl(s0, 24) ^ s1 ^ (ulong)((s1 << 16));
            state1 = rotl(s1, 37);
            return result;
        }

        public uint nextuint()
        {
            return (uint)next();
        }

        uint getMask(uint x)
        {
            x -= 1;
            for (int i = 0; i < 6; i++)
            {
                x |= x >> (1 << i);
            }
            return x;
        }

        public ulong rand(uint n)
        {
            uint mask = getMask(n);
            ulong res = next() & mask;
            while (res >= n)
            {
                res = next() & mask;
            }
            return res;
        }
    }
}
