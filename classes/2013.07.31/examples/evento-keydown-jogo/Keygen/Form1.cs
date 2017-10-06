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
    public partial class Form1 : Form
    { //Área de definição de Variáveis
        Random coluna = new Random(300); //Define o número randômico, entre 0 e 300
        Random linha = new Random(300);  //Define o número randômico, entre 0 e 300
        int total = 50; //Variável para contar os pontos
        string vf = "s";
        int tempo = 30;
        int vezes=0;
        public Form1()
        {
            InitializeComponent();
        }

        private void jill_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {


        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        { //Evento Key Down serve para acionar o controle de teclas especiais
            label3.Visible = false;
            txtpontos.Text = total.ToString();
            txttempo.Text = tempo.ToString();
            txtvezes.Text=vezes.ToString();
            timertempo.Enabled = true;
            if (e.KeyCode==Keys.Up)
            {
                jill.Top = jill.Top -15; //Subtrai 10 na linha
            }
            if (e.KeyCode == Keys.Down)
            {
                jill.Top = jill.Top + 15; //Soma 10 na linha
            }
            if (e.KeyCode == Keys.Left)
            {
                jill.Left = jill.Left - 15; //Subtrai 10 na coluna
            }
            if (e.KeyCode == Keys.Right)
            {
                jill.Left = jill.Left + 15; //Soma 10 na coluna
            }
            if (jill.Top < -97)
            {
                jill.Top = 260;
            }
            if (jill.Left < -100)
            {
                jill.Left = 284;
            }
            if (jill.Top > 260)
            {
                jill.Top = -97;
            }
            if (jill.Left > 284)
            {
                jill.Left = -100;
            }
            if (foto2.Left + foto2.Width >= jill.Left && foto2.Left <= jill.Left + jill.Width && foto2.Top + foto2.Height >= jill.Top && foto2.Top <= jill.Top + foto2.Height)
            {
                foto3.Left = jill.Left;
                foto3.Top = jill.Top;
                total = total - 5;
                if (total <= 0)
                {
                    foto3.Visible = true;
                    txtpontos.Text = total.ToString();
                    MessageBox.Show("Perdeu aê, hein fera");
                    Application.Exit();
                    total = 50;
                    
                }
                txtpontos.Text = total.ToString();
                foto2.Left = foto4.Left;
                foto2.Top = foto4.Top;

                

            }
            if (foto4.Left + foto4.Width >= jill.Left && foto4.Left <= jill.Left + jill.Width && foto4.Top + foto4.Height >= jill.Top && foto4.Top <= jill.Top + foto4.Height)
            {
                foto3.Left = jill.Left;
                foto3.Top = jill.Top;
                total = total - 50;
                if (total <= 0)
                {
                    foto3.Visible = true;
                    txtpontos.Text = total.ToString();
                    MessageBox.Show("Perdeu aê, hein fera");
                    timertempo.Enabled = false;
                    Application.Exit();
                    total = 50;
                }
                txtpontos.Text = total.ToString();
                
            }   
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void jill_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            foto2.Left = coluna.Next(300);
            foto2.Top = coluna.Next(300);
        }

        private void foto4_Click(object sender, EventArgs e)
        {
            
        }

        private void timertempo_Tick(object sender, EventArgs e)
        {
        }

        private void timertempo_Tick_1(object sender, EventArgs e)
        {
            tempo = tempo - 1;
            txttempo.Text = tempo.ToString();
            if (tempo == 0 && total > 0)
            {
                total = total + 5;
                txtpontos.Text = total.ToString();
                txtvezes.Text = vezes.ToString();
                tempo = 30;
                vezes = vezes + 1;
                if (vezes == 5)
                {
                    MessageBox.Show("Ganhou aê, hein fera");
                    timertempo.Enabled = false;
                    Application.Exit();
                }
                timertempo.Enabled = false;
            }

      
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

    }
}
