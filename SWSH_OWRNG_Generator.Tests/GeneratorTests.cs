using FluentAssertions;
using SWSH_OWRNG_Generator.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace SWSH_OWRNG_Generator.Tests;

public sealed class GeneratorTests
{
    private const uint TID = 1337;
    private const uint SID = 1390;
    private const bool ShinyCharm = true;
    private const bool MarkCharm = true;
    private const bool Weather = false;
    private const bool Fishing = false;
    private const bool HeldItem = false;
    private const string Ignore = "Ignore";
    private readonly static uint[] MinIVs = { 0, 0, 0, 0, 0, 0 };
    private readonly static uint[] MaxIVs = { 31, 31, 31, 31, 31, 31 };
    private readonly static IProgress<int> Progress = new Progress<int>();


    [Theory]
    [InlineData(0x69CABBA9ECABBA9Eu, 0xCABBA9ECABBA9E69u)]
    public void GenerateStatic(in ulong s0, in ulong s1)
    {
        List<Frame> Frames = Generator.Generate(
            s0, s1, 1000, TID, SID, ShinyCharm, MarkCharm, Weather, true, Fishing, HeldItem, Ignore, Ignore, Ignore, Ignore,
            0, 0, 0, 0, MinIVs, MaxIVs, false, 0, 0, 0, false, false, false, false, 0, Progress
        );
        Frames.Should().NotBeNull();
        Frames.Where(f => f.Shiny != "No").Count().Should().Be(0);
        Frames.Where(f => f.Mark == "Rare").Count().Should().Be(1);
        Frames.Where(f => f.Mark == "Uncommon").Count().Should().Be(36);
        Frames.Where(f => f.Advances == "869" && f.PID == "770397FE" && f.EC == "87036D68" && f.Ability == 1 && f.Nature == "Jolly" && f.HP == 29 && f.Atk == 0 && f.Def == 1 && f.SpA == 30 && f.SpD == 30 && f.Spe == 0 && f.Mark == "Upbeat").Count().Should().Be(1);
    }

    [Theory]
    [InlineData(0xAAAAAAAAAAAAAAAAu, 0x50C1AB1ECABBA6E5u)]
    public void GenerateSymbol(in ulong s0, in ulong s1)
    {
        List<Frame> Frames = Generator.Generate(
            s0, s1, 60000, TID, SID, ShinyCharm, MarkCharm, Weather, false, Fishing, HeldItem, Ignore, Ignore, Ignore, Ignore,
            34, 36, 0, 99, MinIVs, MaxIVs, false, 4, 500, 0, false, false, false, false, 0, Progress
        );
        Frames.Should().NotBeNull();
        Frames.Where(f => f.Shiny != "No" && f.Brilliant == "Y").Count().Should().Be(3);
        Frames.Where(f => f.PID == "4ED54E82" && f.EC == "5C7EDFDF").Count().Should().Be(3);
        Frames.Where(f => f.PID == "4ED54E82" && f.EC == "5C7EDFDF" && f.Slot == 94 && f.Level == 36 && f.HP == 31 && f.Atk == 31 && f.Def == 11 && f.SpA == 11 && f.SpD == 21 && f.Spe == 21 && f.Mark == "Peeved").Count().Should().Be(1);

        Frames = Generator.Generate(
            s0, s1, (uint)5000, TID, SID, true, true, true, false, false, false, "Ignore", "Ignore", "Ignore", "Ignore",
            34, 36, 0, 99, MinIVs, MaxIVs, false, 4, 500, 0, false, false, false, false, 50000, Progress
        );
        Frames.Where(f => f.Shiny != "No").Count().Should().Be(10);
    }
}