namespace SWSH_OWRNG_Generator.Core.Util
{
    public class Common
    {
        public static uint GetTSV(uint TID, uint SID)
        {
            return TID ^ SID;
        }
        public static (uint, uint) GenerateBrilliantInfo(uint KOs) => KOs switch
        {
            >= 500 => (30, 6),
            >= 300 => (30, 5),
            >= 200 => (30, 4),
            >= 100 => (30, 3),
            >= 50 => (25, 2),
            >= 20 => (20, 1),
            >= 1 => (15, 1),
            _ => (0, 0),
        };
    }
}
