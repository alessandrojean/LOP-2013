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
    public partial class Form3 : Form
    {
        Form4 f4 = new Form4();
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true)
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
            f4.Visible = true;
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void Form3_Activated(object sender, EventArgs e)
        {
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
        }
    }
}
