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
    public partial class Form5 : Form
    {
        Form6 f6=new Form6();
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton4.Checked == true)
            {
                MessageBox.Show("Acertou");
                Form1.acerto++;
            }
            else
            {
                MessageBox.Show("Errou");
                Form1.erro++;
            }
            this.Visible = false;
            f6.Visible = true;
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void Form5_Activated(object sender, EventArgs e)
        {
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
        }
    }
}
