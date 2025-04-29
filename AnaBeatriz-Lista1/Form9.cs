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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double l, a, c, vol;
                l = Convert.ToDouble(textBox1.Text);
                c = Convert.ToDouble(textBox2.Text);
                a = Convert.ToDouble(textBox3.Text);
                vol = l * c * a;
                label6.Text = Convert.ToString(vol);
            } catch (FormatException) {
                MessageBox.Show("Por favor, digite valores válidos para largura,comprimento e largura", "Erro",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            label6.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
