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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double na, nb, nan, nbn;
                na = Convert.ToDouble(textBox1.Text);
                nb = Convert.ToDouble(textBox3.Text);
                nbn = na;
                nan = nb;
                label6.Text = Convert.ToString(nan);
                label8.Text = Convert.ToString(nbn);

            } catch
            {
                MessageBox.Show("Por favor, digite valores válidos para A e B", "Erro",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear(); 
            textBox3.Clear();
            label6.Text = "";
            label8.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
