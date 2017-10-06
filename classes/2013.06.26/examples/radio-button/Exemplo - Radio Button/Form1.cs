using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exemplo___Radio_Button
{
    public partial class Form1 : Form
    {
        int t1 = 0, t2 = 0, t3 = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioacao.Checked == true)
            {
                progresso.Value = (0);
                progresso.Style = ProgressBarStyle.Blocks;
                progresso.Value = (100);             
                t1++;
                textacao.Text = (t1).ToString();
                radioacao.Checked = (false);
                textnome.Text = "";
            }
            else
                if (radioromance.Checked == true)
                {
                    progresso.Value = (0);
                    progresso.Style = ProgressBarStyle.Blocks;
                    progresso.Value = (100);
                    t2++;
                    textromance.Text = (t2).ToString();
                    radioromance.Checked = (false);
                    textnome.Text = "";
                }
                else
                    if (radiooutros.Checked == true)
                    {
                        progresso.Value = (0);
                        progresso.Style = ProgressBarStyle.Blocks;
                        progresso.Value = (100);
                        t3++;
                        textoutros.Text = (t3).ToString();
                        radiooutros.Checked = (false);
                        textnome.Text = "";                        
                    }
        }

        private void radioacao_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("açao.jpg");
        }

        private void radioromance_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("romance.jpg");
        }

        private void radiooutros_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("outros.jpg");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
