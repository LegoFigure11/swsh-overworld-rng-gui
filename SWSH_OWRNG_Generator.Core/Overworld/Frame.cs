namespace SWSH_OWRNG_Generator.Core.Overworld
{
    public class Frame
    {
        public string? Advances { get; set; }
        public ushort TID { get; set; }
        public ushort SID { get; set; }
        public ulong Animation { get; set; }
        public string? Jump { get; set; }
        public string? Steps { get; set; }
        public uint Level { get; set; }
        public uint Slot { get; set; }
        public string? PID { get; set; }
        public string? EC { get; set; }
        public string? Shiny { get; set; }
        public string? Brilliant { get; set; }
        public int Ability { get; set; }
        public string? Nature { get; set; }
        public string? Gender { get; set; }
        public uint HP { get; set; }
        public uint Atk { get; set; }
        public uint Def { get; set; }
        public uint SpA { get; set; }
        public uint SpD { get; set; }
        public uint Spe { get; set; }
        public string? Height { get; set; }
        public string? Mark { get; set; }        
        public string? State0 { get; set; }
        public string? State1 { get; set; }
    }
}
