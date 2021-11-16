using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace SWSH_OWRNG_Generator_GUI
{
    public partial class Form1 : Form
    {
        //private rng calc;
        public Form1()
        {
            InitializeComponent();
            this.Text = "SwSh OWRNG Generator GUI";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void HpMinFilter_Click(object sender, EventArgs e)
        {
            hpMin.Clear();
            hpMin.Text = "0";
            hpMax.Clear();
            hpMax.Text = "0";
        }

        private void Filter_LostFocus(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (Int32.TryParse(textBox.Text, out int i))
            {
                if (i < 0) textBox.Text = "0";
                if (i > 31) textBox.Text = "31";
            }

            else
            {
                textBox.Text = "0";
            }

        }

        private void LevelSlot_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (Int32.TryParse(textBox.Text, out int i))
            {
                if (i < 0) textBox.Text = "0";
                if (i > 99) textBox.Text = "99";
            }
        }

        private void TIDSID_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (Int32.TryParse(textBox.Text, out int i))
            {
                if (i < 0) textBox.Text = "0";
                if (i > 0xFFFF) textBox.Text = "65535";
            }
        }

        private void ResetFilters(object sender, EventArgs e)
        {
            Label label = (Label)sender;
            string stat = label.Name;

            switch (stat)
            {
                case "hpFilter":
                    hpMin.Text = "0";
                    hpMax.Text = "31";
                    break;

                case "atkFilter":
                    atkMin.Text = "0";
                    atkMax.Text = "31";
                    break;

                case "defFilter":
                    defMin.Text = "0";
                    defMax.Text = "31";
                    break;

                case "spaFilter":
                    spaMin.Text = "0";
                    spaMax.Text = "31";
                    break;

                case "spdFilter":
                    spdMin.Text = "0";
                    spdMax.Text = "31";
                    break;

                case "speFilter":
                    speMin.Text = "0";
                    speMax.Text = "31";
                    break;
            }
        }

        private void HpMaxFilter_Click(object sender, EventArgs e)
        {
            hpMin.Clear();
            hpMin.Text = "31";
            hpMax.Clear();
            hpMax.Text = "31";
        }

        private void AtkMinFilter_Click(object sender, EventArgs e)
        {
            atkMin.Clear();
            atkMin.Text = "0";
            atkMax.Clear();
            atkMax.Text = "0";
        }

        private void AtkMaxFilter_Click(object sender, EventArgs e)
        {
            atkMin.Clear();
            atkMin.Text = "31";
            atkMax.Clear();
            atkMax.Text = "31";
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CheckStatic_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckStatic.Checked)
            {
                InputLevelMax.ReadOnly = true;
                InputLevelMin.ReadOnly = true;
                InputSlotMax.ReadOnly = true;
                InputSlotMin.ReadOnly = true;
            }
            else
            {
                InputLevelMax.ReadOnly = false;
                InputLevelMin.ReadOnly = false;
                InputSlotMax.ReadOnly = false;
                InputSlotMin.ReadOnly = false;
            }

        }


        private void DefMinFilter_Click(object sender, EventArgs e)
        {
            defMin.Clear();
            defMin.Text = "0";
            defMax.Clear();
            defMax.Text = "0";
        }



        private void SpaMinFilter_Click(object sender, EventArgs e)
        {
            spaMin.Clear();
            spaMin.Text = "0";
            spaMax.Clear();
            spaMax.Text = "0";
        }

        private void DefMaxFilter_Click(object sender, EventArgs e)
        {
            defMin.Clear();
            defMin.Text = "31";
            defMax.Clear();
            defMax.Text = "31";
        }

        private void SpaMaxFilter_Click(object sender, EventArgs e)
        {
            spaMin.Clear();
            spaMin.Text = "31";
            spaMax.Clear();
            spaMax.Text = "31";
        }

        private void SpdMinFilter_Click(object sender, EventArgs e)
        {
            spdMin.Clear();
            spdMin.Text = "0";
            spdMax.Clear();
            spdMax.Text = "0";
        }

        private void SpdMaxFilter_Click(object sender, EventArgs e)
        {
            spdMin.Clear();
            spdMin.Text = "31";
            spdMax.Clear();
            spdMax.Text = "31";
        }

        private void SpeMinFilter_Click(object sender, EventArgs e)
        {
            speMin.Clear();
            speMin.Text = "0";
            speMax.Clear();
            speMax.Text = "0";
        }

        private void SpeMaxFilter_Click(object sender, EventArgs e)
        {
            speMin.Clear();
            speMin.Text = "31";
            speMax.Clear();
            speMax.Text = "31";
        }


        private void InputStatePaste_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.V || e.Modifiers == Keys.Shift && e.KeyCode == Keys.Insert)
            {
                string NewText = "";

                foreach (char a in Clipboard.GetText())
                {
                    if ((a >= 'a' && a <= 'f') || (a >= 'A' && a <= 'F') || (a >= '0' && a <= '9'))
                    {
                        NewText += char.ToUpper(a);
                    }
                }

                if (NewText != "")
                {
                    Clipboard.SetText(NewText);
                }
                else
                { Clipboard.Clear(); }
            }
        }

        private void HexInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            string s = "";

            s += e.KeyChar;

            byte[] b = Encoding.ASCII.GetBytes(s);

            if (e.KeyChar != (char)Keys.Back && !char.IsControl(e.KeyChar))
            {
                if (!(((0x30 <= b[0]) && (b[0] <= 0x39)) ||
                      ((0x41 <= b[0]) && (b[0] <= 0x46)) ||
                      ((0x61 <= b[0]) && (b[0] <= 0x66))))
                {
                    e.Handled = true;
                }
                else
                {
                    e.KeyChar = char.ToUpper(e.KeyChar);
                }
            }
        }

        private void DecInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            string s = "";

            s += e.KeyChar;

            byte[] b = Encoding.ASCII.GetBytes(s);

            if (e.KeyChar != (char)Keys.Back && !char.IsControl(e.KeyChar))
            {
                if (!(((0x30 <= b[0]) && (b[0] <= 0x39)) ||
                      (('z' <= b[0]) && (b[0] <= 'a')) ||
                      (('Z' <= b[0]) && (b[0] <= 'A'))))
                {
                    e.Handled = true;
                }
            }
        }

        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            Pad(InputState0, '0', 16);
            Pad(InputState1, '0', 16);
            Pad(InputTID, '0', 5);
            Pad(InputSID, '0', 5);
            Pad(InputSlotMin, '0', 1);
            Pad(InputSlotMax, '0', 1);
            Pad(InputLevelMin, '0', 1);
            Pad(InputLevelMax, '0', 1);
            ulong s0 = UInt64.Parse(InputState0.Text, System.Globalization.NumberStyles.AllowHexSpecifier);
            ulong s1 = UInt64.Parse(InputState1.Text, System.Globalization.NumberStyles.AllowHexSpecifier);
            ulong advances = UInt64.Parse(InputMaxAdv.Text);
            uint TID = UInt16.Parse(InputTID.Text);
            uint SID = UInt16.Parse(InputSID.Text);
            uint SlotMin = UInt16.Parse(InputSlotMin.Text);
            uint SlotMax = UInt16.Parse(InputSlotMax.Text);
            uint LevelMin = UInt16.Parse(InputLevelMin.Text);
            uint LevelMax = UInt16.Parse(InputLevelMax.Text);
            bool ShinyCharm = CheckShinyCharm.Checked;
            bool MarkCharm = CheckMarkCharm.Checked;
            bool Weather = CheckWeather.Checked;
            bool Static = CheckStatic.Checked;
            bool Fishing = CheckFishing.Checked;
            bool HeldItem = CheckHeldItem.Checked;
            bool ExtraRoll = CheckExtraRoll.Checked;
            string DesiredMark = (string)SelectedMark.SelectedItem;
            string DesiredShiny = (string)SelectedShiny.SelectedItem;
            uint[] MinIVs = { UInt16.Parse(hpMin.Text), UInt16.Parse(atkMin.Text), UInt16.Parse(defMin.Text), UInt16.Parse(spaMin.Text), UInt16.Parse(spdMin.Text), UInt16.Parse(speMin.Text) };
            uint[] MaxIVs = { UInt16.Parse(hpMax.Text), UInt16.Parse(atkMax.Text), UInt16.Parse(defMax.Text), UInt16.Parse(spaMax.Text), UInt16.Parse(spdMax.Text), UInt16.Parse(speMax.Text) };

            Results.Rows.Clear();

            List<Frame> Frames = Generator.Generate(
                s0, s1, advances, TID, SID, ShinyCharm, MarkCharm, Weather, Static, Fishing, HeldItem, ExtraRoll, DesiredMark, DesiredShiny,
                LevelMin, LevelMax, SlotMin, SlotMax, MinIVs, MaxIVs
            );

            foreach (Frame Frame in Frames)
            {
                int RowID = Results.Rows.Add();
                DataGridViewRow Row = Results.Rows[RowID];
                Row.Cells["Frame"].Value = Frame.Advances;
                Row.Cells["Level"].Value = Frame.Level;
                Row.Cells["Slot"].Value = Frame.Slot;
                Row.Cells["PID"].Value = Frame.PID.ToString("X8");
                Row.Cells["EC"].Value = Frame.EC.ToString("X8");
                Row.Cells["Shiny"].Value = Frame.Shiny;
                Row.Cells["HP"].Value = Frame.HP;
                Row.Cells["Atk"].Value = Frame.Atk;
                Row.Cells["Def"].Value = Frame.Def;
                Row.Cells["SpA"].Value = Frame.SpA;
                Row.Cells["SpD"].Value = Frame.SpD;
                Row.Cells["Spe"].Value = Frame.Spe;
                Row.Cells["Mark"].Value = Frame.Mark;
            }
        }

        private void Pad(object sender, char s, int length)
        {
            ((TextBox)sender).Text = ((TextBox)sender).Text.PadLeft(length, s);
        }

   
    }
}
