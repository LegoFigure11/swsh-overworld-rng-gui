﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SWSH_OWRNG_Generator.WinForms
{
    public partial class Cram_o_matic : Form
    {
        private readonly MainWindow MainWindow;
        public Cram_o_matic(MainWindow f)
        {
            InitializeComponent();
            InputState0.Text = f.InputState0.Text;
            InputState1.Text = f.InputState1.Text;
            MainWindow = f;
            SelectedItem.SelectedIndex = 0;

            InputState0.KeyPress += new KeyPressEventHandler(MainWindow.HexInput_KeyPress);
            InputState1.KeyPress += new KeyPressEventHandler(MainWindow.HexInput_KeyPress);
            InputInitialAdv.KeyPress += new KeyPressEventHandler(MainWindow.DecInput_KeyPress);
            InputMaxAdv.KeyPress += new KeyPressEventHandler(MainWindow.DecInput_KeyPress);
        }

        private async void CramSearch_Click(object sender, EventArgs e)
        {
            MainWindow.Pad(InputState0, '0', 16);
            MainWindow.Pad(InputState1, '0', 16);
            ulong s0 = ulong.Parse(InputState0.Text, NumberStyles.AllowHexSpecifier);
            ulong s1 = ulong.Parse(InputState1.Text, NumberStyles.AllowHexSpecifier);
            MainWindow.Pad(InputInitialAdv, '0', 1);
            ulong InitialAdvances = ulong.Parse(InputInitialAdv.Text);
            ulong advances = ulong.Parse(InputMaxAdv.Text);
            if (advances == 0)
            {
                InputMaxAdv.Text = "1";
                advances = 1;
            }

            int ItemIndex = SelectedItem.SelectedIndex;

            Core.Cram_o_matic.Filter Filters = new();
            Filters.Poke = CheckPoke.Checked;
            Filters.Great = CheckGreat.Checked;
            Filters.Shop1 = CheckShop1.Checked;
            Filters.Shop2 = CheckShop2.Checked;
            Filters.Apri = CheckApricorn.Checked;
            Filters.SafariSport = CheckSafariSport.Checked;
            Filters.BonusOnly = CheckBonus.Checked;

            CramProgressBar.Value = 0;
            CramProgressBar.Maximum = (int)advances;
            CramProgressBar.Step = CramProgressBar.Maximum / 100;

            CramSearch.Text = "Calculating...";
            CramSearch.Enabled = false;

            var progress = new Progress<int>(_ => CramProgressBar.PerformStep());

            List<Core.Cram_o_matic.Frame> Frames = await Task.Run(() => Core.Cram_o_matic.Generator.Generate(s0, s1, advances, InitialAdvances, ItemIndex, progress, Filters));

            BindingSource Source = new() { DataSource = Frames };
            CramResults.DataSource = Source;
            Source.ResetBindings(false);

            CramProgressBar.Value = CramProgressBar.Maximum;
            CramSearch.Text = "Search!";
            CramSearch.Enabled = true;
        }
    }
}
