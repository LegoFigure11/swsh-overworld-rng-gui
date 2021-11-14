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

        private void button1_Click(object sender, EventArgs e)
        {
            textBox5.Clear();
            textBox5.Text = "0";
            textBox6.Clear();
            textBox6.Text = "0";
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox5.Clear();
            textBox5.Text = "31";
            textBox6.Clear();
            textBox6.Text = "31";
        }

        private void label4_Click(object sender, EventArgs e)
        {
            textBox5.Clear();
            textBox5.Text = "0";
            textBox6.Clear();
            textBox6.Text = "31";
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox7.Clear();
            textBox7.Text = "0";
            textBox8.Clear();
            textBox8.Text = "0";
        }

        private void button3_Click(object sender, EventArgs e)
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

        private void textBox5_Validating(object sender, CancelEventArgs e)
        {
            if (Int32.TryParse(textBox5.Text, out int i))
            {
                if (i < 0) textBox5.Text = "0";
                if (i > 31) textBox5.Text = "31";
            }
            else
            {
                textBox5.Text = "0";
                e.Cancel = true;
            }
        }
    }
}
