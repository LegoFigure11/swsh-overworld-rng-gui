﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace SWSH_OWRNG_Generator.WinForms
{
    public partial class Loto_ID : Form
    {
        private const string FileName = ".\\Loto-ID.txt";
        private readonly MainWindow MainWindow;
        private readonly uint TID7;
        private readonly string DisplayID;
        private readonly HashSet<string> IDList = new();
        public Loto_ID(MainWindow f)
        {
            InitializeComponent();
            InputState0.Text = f.InputState0.Text;
            InputState1.Text = f.InputState1.Text;
            MainWindow = f;
            TID7 = ((uint.Parse(f.InputSID.Text) << 16) | uint.Parse(f.InputTID.Text)) % 1_000_000;
            DisplayID = $"{TID7:D6}";
            InputDisplayID.Text = DisplayID;
            LoadIDs();

            InputState0.KeyPress += new KeyPressEventHandler(MainWindow.HexInput_KeyPress);
            InputState1.KeyPress += new KeyPressEventHandler(MainWindow.HexInput_KeyPress);
            InputInitialAdv.KeyPress += new KeyPressEventHandler(MainWindow.DecInput_KeyPress);
            InputMaxAdv.KeyPress += new KeyPressEventHandler(MainWindow.DecInput_KeyPress);
            InputDisplayID.KeyPress += new KeyPressEventHandler(MainWindow.DecInput_KeyPress);
            InputNPCs.KeyPress += new KeyPressEventHandler(MainWindow.DecInput_KeyPress);
        }

        private void UpdateIDsFromFile()
        {
            if (File.Exists(FileName))
            {
                IDList.Clear();
                string[] lines = File.ReadAllLines(FileName);
                foreach (string line in lines)
                {
                    IDList.Add($"{uint.Parse(line):D6}");
                }
            }
        }
        private void LoadIDs()
        {
            UpdateIDsFromFile();
            InputLoadedFromFile.Text = IDList.Count.ToString("N0");
        }

        private void ButtonReload_Click(object sender, EventArgs e)
        {
            LoadIDs();
        }

        private async void LotoIDSearch_Click(object sender, EventArgs e)
        {
            MainWindow.Pad(InputState0, '0', 16);
            MainWindow.Pad(InputState1, '0', 16);
            MainWindow.Pad(InputDisplayID, '0', 6);
            ulong s0 = ulong.Parse(InputState0.Text, NumberStyles.AllowHexSpecifier);
            ulong s1 = ulong.Parse(InputState1.Text, NumberStyles.AllowHexSpecifier);
            MainWindow.Pad(InputNPCs, '0', 1);
            uint NPCs = 0;
            if (CheckMenuClose.Checked)
                NPCs = uint.Parse(InputNPCs.Text) + 1;

            MainWindow.Pad(InputMaxAdv, '0', 1);
            ulong advances = ulong.Parse(InputMaxAdv.Text);
            if (advances == 0)
            {
                InputMaxAdv.Text = "1";
                advances = 1;
            }
            MainWindow.Pad(InputInitialAdv, '0', 1);
            ulong InitialAdvances = ulong.Parse(InputInitialAdv.Text);

            IDList.Add(InputDisplayID.Text);

            LotoIDProgressBar.Value = 0;
            LotoIDProgressBar.Maximum = (int)advances;
            LotoIDProgressBar.Step = LotoIDProgressBar.Maximum / 100;

            LotoIDSearch.Text = "Calculating...";
            LotoIDSearch.Enabled = false;

            Core.Loto_ID.Filter Filters = new()
            {
                None = CheckNoItem.Checked,
                MooMoo = CheckMooMoo.Checked,
                PPUp = CheckPPUp.Checked,
                PPMax = CheckPPMax.Checked,
                RareCandy = CheckRareCandy.Checked,
                MasterBall = CheckMaster.Checked,
                MenuClose = CheckMenuClose.Checked
            };

            var progress = new Progress<int>(_ => LotoIDProgressBar.PerformStep());

            List<Core.Loto_ID.Frame> Frames = await Task.Run(() => Core.Loto_ID.Generator.Generate(s0, s1, advances, InitialAdvances, IDList, Filters, NPCs, progress));

            BindingSource Source = new() { DataSource = Frames };
            LotoIdResults.DataSource = Source;
            LotoIdResults.Columns["Jump"].Visible = CheckMenuClose.Checked;
            Source.ResetBindings(false);

            LotoIDProgressBar.Value = LotoIDProgressBar.Maximum;
            LotoIDSearch.Text = "Search!";
            LotoIDSearch.Enabled = true;
        }

        private void CheckMenuClose_CheckedChanged(object sender, EventArgs e)
        {
            InputNPCs.Enabled = CheckMenuClose.Checked;
        }
    }
}
