using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnaBeatriz_Lista1
{
    public partial class FahrenheitparaCelsius : Form
    {
        public FahrenheitparaCelsius()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Double C;
                Double F;
                C = Convert.ToDouble(textBox1.Text);
                F = (9 * C + 160) / 5;
                F = Math.Round(F, 2);
                label3.Text = Convert.ToString(F);
            } catch (FormatException) {
                MessageBox.Show("Por favor, insira valores válidos para a temperatura em ºC.", "Erro",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            label3.Text = "";
            
        }
    }
}
