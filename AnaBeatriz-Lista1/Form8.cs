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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Double a, b, c, d, vzs, mais;
                //a * b & a + b
                a = Convert.ToDouble(textBox1.Text);
                b = Convert.ToDouble(textBox2.Text);
                vzs = a * b;
                mais = a + b;
                label8.Text = Convert.ToString(mais);
                label9.Text = Convert.ToString(vzs);
            }catch
            {
                MessageBox.Show("Por favor, digite valores válidos para A,B,C e D", "Erro",
       MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Double a, b, c, d, vzs, mais;
                a = Convert.ToDouble(textBox1.Text);
                c = Convert.ToDouble(textBox3.Text);
                vzs = a * c;
                mais = a + c;
                label8.Text = Convert.ToString(mais);
                label9.Text = Convert.ToString(vzs);
            }catch
            {
                MessageBox.Show("Por favor, digite valores válidos para A,B,C e D", "Erro",
       MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                Double a, b, c, d, vzs, mais;
                a = Convert.ToDouble(textBox1.Text);
                d = Convert.ToDouble(textBox4.Text);
                vzs = a * d;
                mais = a + d;
                label8.Text = Convert.ToString(mais);
                label9.Text = Convert.ToString(vzs);
            }catch
            {
                MessageBox.Show("Por favor, digite valores válidos para A,B,C e D", "Erro",
       MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        { try
            {
                Double a, b, c, d, vzs, mais;
                b = Convert.ToDouble(textBox2.Text);
                c = Convert.ToDouble(textBox3.Text);
                vzs = b * c;
                mais = b + c;
                label8.Text = Convert.ToString(mais);
                label9.Text = Convert.ToString(vzs);
            }catch
            {
                MessageBox.Show("Por favor, digite valores válidos para A,B,C e D", "Erro",
       MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        { try
            {
                Double a, b, c, d, vzs, mais;
                b = Convert.ToDouble(textBox2.Text);
                d = Convert.ToDouble(textBox4.Text);
                vzs = b * d;
                mais = b + d;
                label8.Text = Convert.ToString(mais);
                label9.Text = Convert.ToString(vzs);
            } catch
            {
                MessageBox.Show("Por favor, digite valores válidos para A,B,C e D", "Erro",
       MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                Double a, b, c, d, vzs, mais;
                c = Convert.ToDouble(textBox3.Text);
                d = Convert.ToDouble(textBox4.Text);
                vzs = c * d;
                mais = c + d;
                label8.Text = Convert.ToString(mais);
                label9.Text = Convert.ToString(vzs);
            }catch
            {
                MessageBox.Show("Por favor, digite valores válidos para A,B,C e D", "Erro",
       MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                label8.Text = "";
                label9.Text = "";
            } catch {
                MessageBox.Show("Por favor, digite valores válidos para A,B,C e D", "Erro",
       MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
