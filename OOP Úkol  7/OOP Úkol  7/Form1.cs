using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Úkol__7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Zbozi zbozi = new Zbozi(textBox1.Text, (int)numericUpDown1.Value, dateTimePicker1.Value, (int)numericUpDown1.Value);
            zbozi.Trvanlivost();
            zbozi.CenasDPH();
            odpoved.Text = zbozi.ToString();
            if (checkBox1.Checked == true)
            {
                button2.Enabled = true;
            }
            else
            {
                button2.Enabled = false;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Produkt produkt = new Produkt(textBox1.Text, (int)numericUpDown1.Value, dateTimePicker1.Value, (int)numericUpDown1.Value, checkBox1.Checked);
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.ForeColor = Color.Gold;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.ForeColor = Color.LawnGreen;
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.ForeColor = Color.Gold;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.ForeColor = Color.LawnGreen;
        }

      
    }
}
