using System;
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
            InputNPCs.KeyPress += new KeyPressEventHandler(MainWindow.DecInput_KeyPress);
        }

        private async void CramSearch_Click(object sender, EventArgs e)
        {
            MainWindow.Pad(InputState0, '0', 16);
            MainWindow.Pad(InputState1, '0', 16);
            ulong s0 = ulong.Parse(InputState0.Text, NumberStyles.AllowHexSpecifier);
            ulong s1 = ulong.Parse(InputState1.Text, NumberStyles.AllowHexSpecifier);
            MainWindow.Pad(InputNPCs, '0', 1);
            uint NPCs = 0;
            if (CheckMenuClose.Checked)
            {
                NPCs = uint.Parse(InputNPCs.Text);
            }


            MainWindow.Pad(InputMaxAdv, '0', 1);
            ulong advances = ulong.Parse(InputMaxAdv.Text);
            if (advances == 0)
            {
                InputMaxAdv.Text = "1";
                advances = 1;
            }
            MainWindow.Pad(InputInitialAdv, '0', 1);
            ulong InitialAdvances = ulong.Parse(InputInitialAdv.Text);

            int ItemIndex = SelectedItem.SelectedIndex;

            Core.Cram_o_matic.Filter Filters = new()
            {
                Poke = CheckPoke.Checked,
                Great = CheckGreat.Checked,
                Shop1 = CheckShop1.Checked,
                Shop2 = CheckShop2.Checked,
                Apri = CheckApricorn.Checked,
                SafariSport = CheckSafariSport.Checked,
                BonusOnly = CheckBonus.Checked,
                MenuClose = CheckMenuClose.Checked
            };

            CramProgressBar.Value = 0;
            CramProgressBar.Maximum = (int)advances;
            CramProgressBar.Step = CramProgressBar.Maximum / 100;

            CramSearch.Text = "Calculating...";
            CramSearch.Enabled = false;

            var progress = new Progress<int>(_ => CramProgressBar.PerformStep());

            List<Core.Cram_o_matic.Frame> Frames = await Task.Run(() => Core.Cram_o_matic.Generator.Generate(s0, s1, advances, InitialAdvances, ItemIndex, progress, Filters, NPCs));

            BindingSource Source = new() { DataSource = Frames };
            CramResults.DataSource = Source;
            CramResults.Columns["Jump"].Visible = CheckMenuClose.Checked;
            Source.ResetBindings(false);

            CramProgressBar.Value = CramProgressBar.Maximum;
            CramSearch.Text = "Search!";
            CramSearch.Enabled = true;
        }

        private void CheckMenuClose_CheckedChanged(object sender, EventArgs e)
        {
            InputNPCs.Enabled = CheckMenuClose.Checked;
        }

        private void Cram_o_matic_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainWindow.CramFormOpen = false;
        }
    }
}
