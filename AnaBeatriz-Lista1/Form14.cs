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
    public partial class Form14: Form
    {
        public Form14()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double numa, numb, conc;
                numa = Convert.ToDouble(textBox1.Text);
                numb = Convert.ToDouble(textBox2.Text);
                label4.Text = Convert.ToString(numb);
                label6.Text = Convert.ToString(numa);
            }catch {
                MessageBox.Show("Por favor, digite valores válidos para A e B", "Erro",
       MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            label4.Text = "";
            label6.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
