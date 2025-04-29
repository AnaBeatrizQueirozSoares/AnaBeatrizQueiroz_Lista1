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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double tg, vm, dis, gas;
                tg = Convert.ToDouble(textBox1.Text);
                vm = Convert.ToDouble(textBox2.Text);
                dis = tg * vm;
                gas = dis / 12;
                label4.Text = Convert.ToString(gas);
                label5.Text = Convert.ToString(dis);
            } catch
            {
                MessageBox.Show("Por favor, insira valores validos para o tempo gasto e a velocidade média", "Erro",
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
            label5.Text = "";
        }
    }
}
