using System;
using System.Text;
using System.Windows.Forms;

namespace SWSH_OWRNG_Generator_GUI
{
    public partial class Form1 : Form
    {
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

        private void Filter_TextChanged(object sender, EventArgs e)
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

        private void HpFilter_Click(object sender, EventArgs e)
        {
            hpMin.Clear();
            hpMin.Text = "0";
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

        private void AtkFilter_Click(object sender, EventArgs e)
        {
            atkMin.Clear();
            atkMin.Text = "0";
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
                LevelMax.ReadOnly = true;
                LevelMin.ReadOnly = true;
                SlotMax.ReadOnly = true;
                SlotMin.ReadOnly = true;
            }
            else
            {
                LevelMax.ReadOnly = false;
                LevelMin.ReadOnly = false;
                SlotMax.ReadOnly = false;
                SlotMin.ReadOnly = false;
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
                        NewText = NewText + char.ToUpper(a);
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
    }
}
