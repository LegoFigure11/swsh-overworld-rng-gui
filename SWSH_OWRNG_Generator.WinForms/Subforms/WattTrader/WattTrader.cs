using SWSH_OWRNG_Generator.Core.WattTrader;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SWSH_OWRNG_Generator.WinForms.Subforms.WattTrader
{
    public partial class WattTrader : Form
    {
        private readonly MainWindow MainWindow;
        public WattTrader(MainWindow f)
        {
            InitializeComponent();
            InputState0.Text = f.InputState0.Text;
            InputState1.Text = f.InputState1.Text;
            MainWindow = f;
            SelectedItem.SelectedIndex = 1;

            InputState0.KeyPress += new KeyPressEventHandler(MainWindow.HexInput_KeyPress);
            InputState1.KeyPress += new KeyPressEventHandler(MainWindow.HexInput_KeyPress);
            InputInitialAdv.KeyPress += new KeyPressEventHandler(MainWindow.DecInput_KeyPress);
            InputMaxAdv.KeyPress += new KeyPressEventHandler(MainWindow.DecInput_KeyPress);
            InputSlotMax.KeyPress += new KeyPressEventHandler(MainWindow.DecInput_KeyPress);
            InputSlotMin.KeyPress += new KeyPressEventHandler(MainWindow.DecInput_KeyPress);
            InputNPCs.KeyPress += new KeyPressEventHandler(MainWindow.DecInput_KeyPress);
        }

        private async void WattSearchSearch_Click(object sender, EventArgs e)
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

            MainWindow.Pad(InputSlotMin, '0', 1);
            MainWindow.Pad(InputSlotMax, '0', 1);

            Filter Filters = new()
            {
                SlotMin = int.Parse(InputSlotMin.Text),
                SlotMax = int.Parse(InputSlotMax.Text),
                MenuClose = CheckMenuClose.Checked
            };

            WattProgressBar.Value = 0;
            WattProgressBar.Maximum = (int)advances;
            WattProgressBar.Step = WattProgressBar.Maximum / 100;

            WattSearch.Text = "Calculating...";
            WattSearch.Enabled = false;

            var progress = new Progress<int>(_ => WattProgressBar.PerformStep());

            List<Frame> Frames = await Task.Run(() => Generator.Generate(s0, s1, advances, InitialAdvances, progress, Filters, NPCs));

            BindingSource Source = new() { DataSource = Frames };
            WattResults.DataSource = Source;
            WattResults.Columns["Jump"].Visible = CheckMenuClose.Checked;
            Source.ResetBindings(false);

            WattProgressBar.Value = WattProgressBar.Maximum;
            WattSearch.Text = "Search!";
            WattSearch.Enabled = true;
        }

        private void CheckMenuClose_CheckedChanged(object sender, EventArgs e)
        {
            InputNPCs.Enabled = CheckMenuClose.Checked;
        }

        private void WattTrader_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainWindow.WattTraderFormOpen = false;
        }

        private void SelectedItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SelectedItem.Text is null) return;
            var (min, max) = GetRangeFromItem(SelectedItem.Text);
            InputSlotMin.Text = min.ToString();
            InputSlotMax.Text = max.ToString();
        }

        private static (int, int) GetRangeFromItem(string Item)
        {
            if (Item == "Bottle Cap x1") return (0, 49);
            else if (Item == "Bottle Cap x3") return (50, 59);
            else if (Item == "Gold Bottle Cap x1") return (60, 62);
            else if (Item == "Red Apricorn x5") return (63, 79);
            else if (Item == "Blue Apricorn x5") return (80, 96);
            else if (Item == "Yellow Apricorn x5") return (97, 113);
            else if (Item == "Green Apricorn x5") return (114, 130);
            else if (Item == "White Apricorn x5") return (131, 147);
            else if (Item == "Black Apricorn x5") return (148, 164);
            else if (Item == "Pink Apricorn x5") return (165, 181);
            else if (Item == "Red Apricorn x10") return (182, 191);
            else if (Item == "Blue Apricorn x10") return (192, 201);
            else if (Item == "Yellow Apricorn x10") return (202, 211);
            else if (Item == "Green Apricorn x10") return (212, 221);
            else if (Item == "White Apricorn x10") return (222, 231);
            else if (Item == "Black Apricorn x10") return (232, 241);
            else if (Item == "Pink Apricorn x10") return (242, 251);
            else if (Item == "PP Up x1") return (252, 301);
            else if (Item == "PP Up x2") return (302, 326);
            else if (Item == "PP Max x1") return (327, 331);
            else if (Item == "Rare Candy x1") return (332, 381);
            else if (Item == "Rare Candy x5") return (382, 421);
            else if (Item == "Gigantamix x1") return (422, 471);
            else if (Item == "Armorite Ore x1") return (472, 531);
            else if (Item == "Armorite Ore x3") return (532, 551);
            else if (Item == "Armorite Ore x8") return (552, 556);
            else if (Item == "Dynite Ore x1") return (557, 576);
            else if (Item == "Dynite Ore x5") return (577, 581);
            else if (Item == "Max Mushrooms x1") return (582, 601);
            else if (Item == "Max Elixir x1") return (602, 641);
            else if (Item == "Galarica Twig x3") return (642, 681);
            else if (Item == "Galarica Twig x5") return (682, 691);
            else if (Item == "Strawberry Sweet x1") return (692, 706);
            else if (Item == "Love Sweet x1") return (707, 721);
            else if (Item == "Berry Sweet x1") return (722, 736);
            else if (Item == "Clover Sweet x1") return (737, 751);
            else if (Item == "Flower Sweet x1") return (752, 766);
            else if (Item == "Star Sweet x1") return (767, 781);
            else if (Item == "Ribbon Sweet x1") return (782, 796);
            else if (Item == "Big Nugget x1") return (797, 826);
            else if (Item == "Beast Ball x1") return (827, 827);
            else if (Item == "Dream Ball x1") return (828, 828);
            else if (Item == "Lansat Berry x1") return (829, 858);
            else if (Item == "Starf Berry x1") return (859, 868);
            else if (Item == "Lucky Egg x1") return (869, 878);
            else if (Item == "Electirizer x1") return (879, 908);
            else if (Item == "Magmarizer x1") return (909, 938);
            else if (Item == "Cracked Pot x1") return (939, 968);
            else if (Item == "Chipped Pot x1") return (969, 979);
            else if (Item == "King's Rock x1") return (980, 999);
            else if (Item == "Beast or Dream Ball") return (827, 828);
            else return (0, 999);
        }
    }
}
