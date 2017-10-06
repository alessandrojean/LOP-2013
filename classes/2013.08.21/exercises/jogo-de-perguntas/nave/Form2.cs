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
    public partial class Form2 : Form
    {
        int passos = 0;
        int tot = 0;
        int resp = 0;
        public Form2()
        {
            InitializeComponent();
            stiker.Image = Image.FromFile("stiker_frente.jpg");
        }

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                stiker.Image = Image.FromFile("stiker_esquerda.jpg");
                stiker.Left = stiker.Left - 15; //Subtrai 10 na coluna
            }
            if (e.KeyCode == Keys.Right)
            {
                stiker.Image = Image.FromFile("stiker_direita.jpg");
                stiker.Left = stiker.Left + 15; //Soma 10 na coluna
                passos++;
                if (passos >= 4)
                {
                    tot++;
                    pergunta.Left = stiker.Left - 20;
                    pergunta.Top = stiker.Top - 120;
                    pergunta.Visible = true;
                    pergunta.Image = Image.FromFile("pergunta.jpg");
                    if (tot == 1)
                    {
                        if (MessageBox.Show("5x5-1=20", "Pergunta 1", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                        {

                            pergunta.Visible = false;
                            passos = 0;
                            tot++;
                            resp = 1;
                        }
                        else
                        { 
                           resp = 0;
                        }
                        if (tot == 2 && resp==1)
                        {
                            tot++;
                            if (MessageBox.Show("Você é Gay?", "Pergunta 2", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {

                                pergunta.Visible = false;
                                passos = 0;
                                tot++;
                            }
                            else
                            {
                                tot = 2;
                            }
                            if (tot == 3)
                            {
                                if (MessageBox.Show("O segundo nome do Edson é Epson?", "Pergunta 3", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                {

                                    pergunta.Visible = false;
                                    passos = 0;
                                    tot++;
                                }
                                else
                                {
                                    tot = 3;
                                }
                                if (tot == 4)
                                {
                                    if (MessageBox.Show("O Pikachu é estudioso?", "Pergunta 4", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                                    {

                                        pergunta.Visible = false;
                                        passos = 0;
                                        tot++;
                                    }
                                    else
                                    {
                                        tot = 4;
                                    }
                                    if (tot == 5)
                                    {
                                        if (MessageBox.Show("DOTA>LOL", "Pergunta 5", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                                        {

                                            pergunta.Visible = false;
                                            passos = 0;
                                            tot++;
                                        }
                                        else
                                        {
                                            tot = 5;
                                        }
                                        if (tot == 6)
                                        {
                                            MessageBox.Show("Acabou ai em fera");
                                        }
                                    }
                                }
                                if (stiker.Left < 0)
                                {
                                    stiker.Left = 0;
                                }

                                if (stiker.Left > 687)
                                {
                                    stiker.Left = -100;
                                }
                            }
                        }
                    }
                }
            }
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
