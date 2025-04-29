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
    public partial class Form17: Form
    {
        public Form17()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Double saliq, salbruto, des1, des2;
                salbruto = Convert.ToInt32(textBox1.Text);
                des1 = (salbruto * 10) / 100;
                salbruto = salbruto - des1;
                des2 = (salbruto * 5) / 100;
                saliq = salbruto - des2;
                label4.Text = Convert.ToString(saliq);
            } catch {
                MessageBox.Show("Por favor, digite valores válidos para o salário bruto", "Erro",
       MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            label4.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
