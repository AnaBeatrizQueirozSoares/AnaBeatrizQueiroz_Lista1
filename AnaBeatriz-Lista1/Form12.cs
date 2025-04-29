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
    public partial class Form12: Form
    {
        public Form12()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int va, vb, resultado;
                va = Convert.ToInt32(textBox1.Text);
                vb = Convert.ToInt32(textBox2.Text);
                resultado = (va * va) + (vb * vb);
                label5.Text = Convert.ToString(resultado);
            }
            catch {
                MessageBox.Show("Por favor, digite valores válidos para A e B", "Erro",
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
            label5.Text = "";
        }
    }
}
