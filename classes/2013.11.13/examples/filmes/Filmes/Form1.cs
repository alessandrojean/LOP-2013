using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Filmes
{
    public partial class Form1 : Form
    {
        Form2 f2 = new Form2();
        static public int valor = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            valor = valor+ int.Parse(textBox3.Text);
            f2.txtvalor.Text = valor.ToString();
            f2.listBox1.Items.Add("Código: " + textBox1.Text + " Nome: " + textBox2.Text + " Valor: " + textBox3.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            f2.Show();
        }
    }
}
