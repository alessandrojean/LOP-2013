using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tabela_periódica
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                MessageBox.Show("Acertou");
                Form1.acerto++;
            }
            else
            {
                MessageBox.Show("Errou");
                Form1.erro++;
            }
            MessageBox.Show("Você acertou " + Form1.acerto.ToString() + " questões e"+"\n" + "Errou " + Form1.erro.ToString() + " questões");
            Application.Exit();
            
        }

        private void Form6_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void Form6_Activated(object sender, EventArgs e)
        {
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
        }
    }
}
