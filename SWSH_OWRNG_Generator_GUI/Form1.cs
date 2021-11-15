using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void hpMinFilter_Click(object sender, EventArgs e)
        {
            hpMin.Clear();
            hpMin.Text = "0";
            hpMax.Clear();
            hpMax.Text = "0";
        }

        private void filter_TextChanged(object sender, EventArgs e)
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

        private void resetFilters(object sender, EventArgs e)
        {
            Label label = (Label)sender;
            string boxName = label.Name.Substring(0,label.Name.Length-6);
            string minFilter = boxName + "MinFilter";
            var result = this.GetType().GetField(minFilter);
            
            Console.WriteLine($"< {result} >");
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void hpMaxFilter_Click(object sender, EventArgs e)
        {
            hpMin.Clear();
            hpMin.Text = "31";
            hpMax.Clear();
            hpMax.Text = "31";
        }

        private void hpFilter_Click(object sender, EventArgs e)
        {
            hpMin.Clear();
            hpMin.Text = "0";
            hpMax.Clear();
            hpMax.Text = "31";
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void atkMinFilter_Click(object sender, EventArgs e)
        {
            atkMin.Clear();
            atkMin.Text = "0";
            atkMax.Clear();
            atkMax.Text = "0";
        }

        private void atkMaxFilter_Click(object sender, EventArgs e)
        {
            atkMin.Clear();
            atkMin.Text = "31";
            atkMax.Clear();
            atkMax.Text = "31";
        }

        private void atkFilter_Click(object sender, EventArgs e)
        {
            atkMin.Clear();
            atkMin.Text = "0";
            atkMax.Clear();
            atkMax.Text = "31";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
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

        private void textBox21_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox20_TextChanged(object sender, EventArgs e)
        { 
        
        }


        private void defMinFilter_Click(object sender, EventArgs e)
        {
            defMin.Clear();
            defMin.Text = "0";
            defMax.Clear();
            defMax.Text = "0";
        }



        private void spaMinFilter_Click(object sender, EventArgs e)
        {
            spaMin.Clear();
            spaMin.Text = "0";
            spaMax.Clear();
            spaMax.Text = "0";
        }

        private void defMaxFilter_Click(object sender, EventArgs e)
        {
            defMin.Clear();
            defMin.Text = "31";
            defMax.Clear();
            defMax.Text = "31";
        }

        private void spaMaxFilter_Click(object sender, EventArgs e)
        {
            spaMin.Clear();
            spaMin.Text = "31";
            spaMax.Clear();
            spaMax.Text = "31";
        }

        private void spdMinFilter_Click(object sender, EventArgs e)
        {
            spdMin.Clear();
            spdMin.Text = "0";
            spdMax.Clear();
            spdMax.Text = "0";
        }

        private void spdMaxFilter_Click(object sender, EventArgs e)
        {
            spdMin.Clear();
            spdMin.Text = "31";
            spdMax.Clear();
            spdMax.Text = "31";
        }

        private void speMinFilter_Click(object sender, EventArgs e)
        {
            speMin.Clear();
            speMin.Text = "0";
            speMax.Clear();
            speMax.Text = "0";
        }

        private void speMaxFilter_Click(object sender, EventArgs e)
        {
            speMin.Clear();
            speMin.Text = "31";
            speMax.Clear();
            speMax.Text = "31";
        }
    }
}
