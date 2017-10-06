using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nave
{
    public partial class Form1 : Form
    {
        int tentativa = 0;
         public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (txtlogin.Text == "alessandro" && txtsenha.Text == "123")
            {
                Form2 f2 = new Form2();
                this.Visible = false;
                f2.Show();
            }
            else
            {
                MessageBox.Show("Usuário ou senha inválidos");
                tentativa++; //Adiciona 1, para cada tentativa falha 
                if (tentativa == 3) //Quando chegar a 3 errada, fecha o aplicativo
                {
                    MessageBox.Show("O limite de tentativas foi atingido");
                    Application.Exit();
                }
            }
        }
    }
}

