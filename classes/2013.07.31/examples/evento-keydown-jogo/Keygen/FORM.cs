using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Keygen
{
    public partial class FORM : Form
    {
        int tentativa = 0;
        public FORM()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtlogin.Text == "etec" && txtsenha.Text == "1234")
            {
                Form1 f1 = new Form1();
                this.Visible = false;
                f1.Show();
            }
            else
            {
                MessageBox.Show("Usuário ou senha inválida");
                tentativa++; //Adiciona 1, para cada tentativa falha 
                if (tentativa == 3 //Quando chegar a 3 errada, fecha o aplicativo
                {
                    MessageBox.Show("O limite de tentativas foi atingido");
                    Application.Exit();
                }
            }

        }
    }
}
