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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double F;
                double C;
                F = Convert.ToDouble(textBox1.Text);
                C = (F - 32) * 5 / 9;
                C = Math.Round(C, 2);
                label4.Text = Convert.ToString(C);
            } catch (FormatException)
            {
                MessageBox.Show("Por favor, insira valores validos para graus fahrenheit", "Erro",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            label4.Text = "";
        }
    }
}
