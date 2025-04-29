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
    public partial class Form13: Form
    {
        public Form13()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            label4.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        { try
            {
                int val1, val2;
                double med;
                val1 = Convert.ToInt32(textBox1.Text);
                val2 = Convert.ToInt32(textBox2.Text);
                med = (val1 + val2) / 2;
                label4.Text = Convert.ToString(med);
                Math.Round(med, 2);
            } catch {
                MessageBox.Show("Por favor, digite valores válidos para 1 e 2", "Erro",
       MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
