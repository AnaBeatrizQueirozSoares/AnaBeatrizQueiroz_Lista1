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
    public partial class Salarioliquido : Form
    {
        public Salarioliquido()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    double horas;
                    double ht;
                    double pd;
                    double salbruto;
                    double saliq;
                    horas = Convert.ToDouble(textBox1.Text);
                    ht = Convert.ToDouble(textBox2.Text);
                    pd = Convert.ToDouble(textBox3.Text);
                    salbruto = horas * ht;
                    pd = pd / 100 * salbruto;
                    saliq = salbruto - pd;
                    pd = pd / 100 * salbruto;
                    label10.Text = pd.ToString("F2");
                    label8.Text = salbruto.ToString("F2");
                    label5.Text = saliq.ToString("F2");
                    Math.Round(saliq, 2);

                }
                catch (FormatException)
                {
                    MessageBox.Show("Por favor, insira valores válidos para horas trabalhadas, valor da hora e percentual de desconto.", "Erro",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            label5.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
