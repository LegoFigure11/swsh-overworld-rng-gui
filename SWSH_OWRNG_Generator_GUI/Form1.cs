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
            textBox6.Clear();
            textBox6.Text = "0";
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

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void hpMaxFilter_Click(object sender, EventArgs e)
        {
            hpMin.Clear();
            hpMin.Text = "31";
            textBox6.Clear();
            textBox6.Text = "31";
        }

        private void hpFilter_Click(object sender, EventArgs e)
        {
            hpMin.Clear();
            hpMin.Text = "0";
            textBox6.Clear();
            textBox6.Text = "31";
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void atkMinFilter_Click(object sender, EventArgs e)
        {
            textBox7.Clear();
            textBox7.Text = "0";
            textBox8.Clear();
            textBox8.Text = "0";
        }

        private void atkMaxFilter_Click(object sender, EventArgs e)
        {
            textBox7.Clear();
            textBox7.Text = "31";
            textBox8.Clear();
            textBox8.Text = "31";
        }

        private void label5_Click(object sender, EventArgs e)
        {
            textBox7.Clear();
            textBox7.Text = "0";
            textBox8.Clear();
            textBox8.Text = "31";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                textBox20.ReadOnly = true;
                textBox21.ReadOnly = true;
                textBox22.ReadOnly = true;
                textBox23.ReadOnly = true;
            }
            else
            {
                textBox20.ReadOnly = false;
                textBox21.ReadOnly = false;
                textBox22.ReadOnly = false;
                textBox23.ReadOnly = false;
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
            textBox9.Clear();
            textBox9.Text = "0";
            textBox10.Clear();
            textBox10.Text = "0";
        }



        private void spaMinFilter_Click(object sender, EventArgs e)
        {
            textBox11.Clear();
            textBox11.Text = "0";
            textBox12.Clear();
            textBox12.Text = "0";
        }

        private void defMaxFilter_Click(object sender, EventArgs e)
        {
            textBox9.Clear();
            textBox9.Text = "31";
            textBox10.Clear();
            textBox10.Text = "31";
        }

        private void spaMaxFilter_Click(object sender, EventArgs e)
        {
            textBox11.Clear();
            textBox11.Text = "31";
            textBox12.Clear();
            textBox12.Text = "31";
        }

        private void spdMinFilter_Click(object sender, EventArgs e)
        {
            textBox13.Clear();
            textBox13.Text = "0";
            textBox14.Clear();
            textBox14.Text = "0";
        }

        private void spdMaxFilter_Click(object sender, EventArgs e)
        {
            textBox13.Clear();
            textBox13.Text = "31";
            textBox14.Clear();
            textBox14.Text = "31";
        }

        private void speMinFilter_Click(object sender, EventArgs e)
        {
            textBox15.Clear();
            textBox15.Text = "0";
            textBox16.Clear();
            textBox16.Text = "0";
        }

        private void speMaxFilter_Click(object sender, EventArgs e)
        {
            textBox15.Clear();
            textBox15.Text = "31";
            textBox16.Clear();
            textBox16.Text = "31";
        }
    }
}
