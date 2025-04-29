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
    public partial class Form16: Form
    {
        public Form16()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int int1, int2, quo;
                int1 = Convert.ToInt32(textBox1.Text);
                int2 = Convert.ToInt32(textBox2.Text);
                quo = int1 % int2;
                label4.Text = Convert.ToString(quo);
            } catch {
                MessageBox.Show("Por favor, digite valores válidos para 1 e 2", "Erro",
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
            textBox2.Clear();
            label4.Text = "";
        }
    }
}
    