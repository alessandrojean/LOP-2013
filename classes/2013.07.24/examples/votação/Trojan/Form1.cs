using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trojan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            imagem.Image = Image.FromFile("foto1.jpg");
            componentes.Text = ("Kurt Cobain, Krist Novoselic, Dave Ghrol");
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            imagem.Image = Image.FromFile("foto2.jpg");
            componentes.Text = ("M. Shadows, Synister Gates, Jimmy 'The Rev' Sullivan");
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            imagem.Image = Image.FromFile("foto3.jpg");
            componentes.Text = ("João, Shandallas e Kinderman");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            radioButton1.Checked = false;
            imagem.Image = Image.FromFile("vazio.jpg");
            componentes.Text = "";
        }
    }
}
