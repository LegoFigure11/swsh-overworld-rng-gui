using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SWSH_OWRNG_Generator.WinForms
{
    public partial class MenuCloseTimeline : Form
    {
        MainWindow MainWindow;
        public MenuCloseTimeline(MainWindow f)
        {
            InitializeComponent();
            InputState0.Text = f.InputState0.Text;
            InputState1.Text = f.InputState1.Text;
            MainWindow = f;

            InputState0.KeyPress += new KeyPressEventHandler(MainWindow.HexInput_KeyPress);
            InputState1.KeyPress += new KeyPressEventHandler(MainWindow.HexInput_KeyPress);
            InputInitialAdv.KeyPress += new KeyPressEventHandler(MainWindow.DecInput_KeyPress);
            InputMaxAdv.KeyPress += new KeyPressEventHandler(MainWindow.DecInput_KeyPress);
            InputNPCs.KeyPress += new KeyPressEventHandler(MainWindow.DecInput_KeyPress);
        }

        private async void TimelineSearch_Click(object sender, System.EventArgs e)
        {
            MainWindow.Pad(InputState0, '0', 16);
            MainWindow.Pad(InputState1, '0', 16);
            ulong s0 = ulong.Parse(InputState0.Text, NumberStyles.AllowHexSpecifier);
            ulong s1 = ulong.Parse(InputState1.Text, NumberStyles.AllowHexSpecifier);
            MainWindow.Pad(InputNPCs, '0', 1);
            uint NPCs = uint.Parse(InputNPCs.Text) + 1;

            MainWindow.Pad(InputMaxAdv, '0', 1);
            ulong advances = ulong.Parse(InputMaxAdv.Text);
            if (advances == 0)
            {
                InputMaxAdv.Text = "1";
                advances = 1;
            }
            MainWindow.Pad(InputInitialAdv, '0', 1);
            ulong InitialAdvances = ulong.Parse(InputInitialAdv.Text);

            TimelineProgressBar.Value = 0;
            TimelineProgressBar.Maximum = (int)advances;
            TimelineProgressBar.Step = TimelineProgressBar.Maximum / 100;

            TimelineSearch.Text = "Calculating...";
            TimelineSearch.Enabled = false;

            var progress = new Progress<int>(_ => TimelineProgressBar.PerformStep());

            List<Core.MenuCloseTimeline.Frame> Frames = await Task.Run(() => Core.MenuCloseTimeline.Generator.Generate(s0, s1, advances, InitialAdvances, NPCs, progress));

            BindingSource Source = new() { DataSource = Frames };
            TimelineResults.DataSource = Source;
            Source.ResetBindings(false);

            TimelineProgressBar.Value = TimelineProgressBar.Maximum;
            TimelineSearch.Text = "Search!";
            TimelineSearch.Enabled = true;
        }
    }
}
