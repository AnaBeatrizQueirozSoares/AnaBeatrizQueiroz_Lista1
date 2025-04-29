using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnaBeatriz_Lista1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double c;
                double r;
                double a;
                c = Convert.ToDouble(textBox1.Text);
                r = c / 2 * 3.14159;
                r = Math.Round(r, 2);
                label5.Text = Convert.ToString(r);
                a = 3.14159 * (r * r);
                a = Math.Round(a, 2);
                label6.Text = Convert.ToString(a);
            } catch (FormatException)
            {
                MessageBox.Show("Por favor, insira valores válidos para a circunferência.", "Erro",
            MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            label5.Text = "";
            label6.Text = "";
        }
    }
}
