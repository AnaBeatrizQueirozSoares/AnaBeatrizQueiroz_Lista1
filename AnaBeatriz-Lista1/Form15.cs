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
    public partial class Form15: Form
    {
        public Form15()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Double km, ms;
                km = Convert.ToDouble(textBox1.Text);
                ms = km / 3.6;
                ms = Math.Round(ms);
                label4.Text = Convert.ToString(ms);
            }
            catch {
                MessageBox.Show("Por favor, digite valores válidos para a velocidade", "Erro",
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
            label4.Text = "";
        }
    }
}
