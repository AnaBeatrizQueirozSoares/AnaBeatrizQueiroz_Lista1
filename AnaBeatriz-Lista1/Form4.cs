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
    public partial class Form4 : Form
    {
        public Form4()
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
                Double vol, a, r;
                r = Convert.ToDouble(textBox2.Text);
                a = Convert.ToDouble(textBox1.Text);
                vol = 3.14159 * (r * r) * a;
                vol = Math.Round(vol, 2);
                label4.Text = Convert.ToString(vol);
            } catch
            {
                MessageBox.Show("Por favor, insira valores validos para o cálculo do volume do cilindro", "erro",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            label4.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
