﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Preservação_da_naturezona
{
    public partial class Form1 : Form
    {
        int op = 0;
        int seg = 120, min = 0;
        int pontos = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox1.Width = 100; //Aumenta a largura da imagem
            pictureBox1.Height = 100; //Aumenta a altura da imagem
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Width = 50;
            pictureBox1.Height = 50;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (op == 0)
            {
                op = 2;
            }
            else
            {
                op = 0;
            }
        }

        private void pictureBox2_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox2.Width = 100;
            pictureBox2.Height = 100;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {

            pictureBox2.Width = 50;
            pictureBox2.Height = 50;
        }

        private void pictureBox3_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox3.Width = 100;
            pictureBox3.Height = 100;

        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.Width = 50;
            pictureBox3.Height = 50;
        }

        private void pictureBox4_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox4.Width = 100;
            pictureBox4.Height = 100;
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            pictureBox4.Width = 50;
            pictureBox4.Height = 50;
        }

        private void pictureBox5_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox5.Width = 100;
            pictureBox5.Height = 100;

        }

        private void pictureBox5_MouseLeave(object sender, EventArgs e)
        {
            pictureBox5.Width = 50;
            pictureBox5.Height = 50;
        }

        private void pictureBox6_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox6.Width = 100;
            pictureBox6.Height = 100;

        }

        private void pictureBox6_MouseLeave(object sender, EventArgs e)
        {
            pictureBox6.Width = 50;
            pictureBox6.Height = 50;
        }

        private void pictureBox7_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox7.Width = 100;
            pictureBox7.Height = 100;

        }

        private void pictureBox7_MouseLeave(object sender, EventArgs e)
        {
            pictureBox7.Width = 50;
            pictureBox7.Height = 50;
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            if (op == 0)
            {
                op = 8;
            }
            else
            {
                op = 0;
            }
        }

        private void pictureBox8_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox8.Width = 100;
            pictureBox8.Height = 100;
        }

        private void pictureBox8_MouseLeave(object sender, EventArgs e)
        {
            pictureBox8.Width = 50;
            pictureBox8.Height = 50;
        }

        private void pictureBox9_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox9.Width = 100;
            pictureBox9.Height = 100;
        }

        private void pictureBox9_MouseLeave(object sender, EventArgs e)
        {
            pictureBox9.Width = 50;
            pictureBox9.Height = 50;
        }

        private void pictureBox10_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox10.Width = 100;
            pictureBox10.Height = 100;
        }

        private void pictureBox10_MouseLeave(object sender, EventArgs e)
        {
            pictureBox10.Width = 50;
            pictureBox10.Height = 50;
        }

        private void pictureBox11_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox11.Width = 100;
            pictureBox11.Height = 100;
        }

        private void pictureBox11_MouseLeave(object sender, EventArgs e)
        {
            pictureBox11.Width = 50;
            pictureBox11.Height = 50;
        }

        private void pictureBox12_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox12.Width = 100;
            pictureBox12.Height = 100;
        }

        private void pictureBox12_MouseLeave(object sender, EventArgs e)
        {
            pictureBox12.Width = 50;
            pictureBox12.Height = 50;
        }

        private void pictureBox13_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox13.Width = 100;
            pictureBox13.Height = 100;
        }

        private void pictureBox13_MouseLeave(object sender, EventArgs e)
        {
            pictureBox13.Width = 50;
            pictureBox13.Height = 50;
        }

        private void pictureBox14_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox14.Width = 100;
            pictureBox14.Height = 100;
        }

        private void pictureBox14_MouseLeave(object sender, EventArgs e)
        {
            pictureBox14.Width = 50;
            pictureBox14.Height = 50;
        }

        private void pictureBox15_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox15.Width = 100;
            pictureBox15.Height = 100;
        }

        private void pictureBox15_MouseLeave(object sender, EventArgs e)
        {
            pictureBox15.Width = 50;
            pictureBox15.Height = 50;
        }

        private void pictureBox16_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox16.Width = 100;
            pictureBox16.Height = 100;
        }

        private void pictureBox16_MouseLeave(object sender, EventArgs e)
        {
            pictureBox16.Width = 50;
            pictureBox16.Height = 50;
        }

        private void pictureBox17_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox17.Width = 100;
            pictureBox17.Height = 100;
        }

        private void pictureBox17_MouseLeave(object sender, EventArgs e)
        {
            pictureBox17.Width = 50;
            pictureBox17.Height = 50;
        }

        private void pictureBox18_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox18.Width = 100;
            pictureBox18.Height = 100;
        }

        private void pictureBox18_MouseLeave(object sender, EventArgs e)
        {
            pictureBox18.Width = 50;
            pictureBox18.Height = 50;
        }

        private void pictureBox19_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox19.Width = 100;
            pictureBox19.Height = 100;
        }

        private void pictureBox19_MouseLeave(object sender, EventArgs e)
        {
            pictureBox19.Width = 50;
            pictureBox19.Height = 50;
        }

        private void pictureBox20_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox20.Width = 100;
            pictureBox20.Height = 100;
        }

        private void pictureBox20_MouseLeave(object sender, EventArgs e)
        {
            pictureBox20.Width = 50;
            pictureBox20.Height = 50;
        }

        private void pictureBox21_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox21.Width = 100;
            pictureBox21.Height = 100;
        }

        private void pictureBox21_MouseLeave(object sender, EventArgs e)
        {
            pictureBox21.Width = 50;
            pictureBox21.Height = 50;
        }

        private void pictureBox22_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox22.Width = 100;
            pictureBox22.Height = 100;
        }

        private void pictureBox22_MouseLeave(object sender, EventArgs e)
        {
            pictureBox22.Width = 50;
            pictureBox22.Height = 50;
        }

        private void pictureBox23_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox23.Width = 100;
            pictureBox23.Height = 100;
        }

        private void pictureBox23_MouseLeave(object sender, EventArgs e)
        {
            pictureBox23.Width = 50;
            pictureBox23.Height = 50;
        }

        private void pictureBox24_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox24.Width = 100;
            pictureBox24.Height = 100;
        }

        private void pictureBox24_MouseLeave(object sender, EventArgs e)
        {
            pictureBox24.Width = 50;
            pictureBox24.Height = 50;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (op == 0)
            {
                op = 1;
            }
            else
            {
                op = 0;
            }
        }

        private void Form1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (op == 0)
            {
                op = 3;
            }
            else
            {
                op = 0;
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (op == 0)
            {
                op = 4;
            }
            else
            {
                op = 0;
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (op == 0)
            {
                op = 5;
            }
            else
            {
                op = 0;
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (op == 0)
            {
                op = 6;
            }
            else
            {
                op = 0;
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if (op == 0)
            {
                op = 7;
            }
            else
            {
                op = 0;
            }
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            if (op == 0)
            {
                op = 9;
            }
            else
            {
                op = 0;
            }
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            if (op == 0)
            {
                op = 10;
            }
            else
            {
                op = 0;
            }
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            if (op == 0)
            {
                op = 11;
            }
            else
            {
                op = 0;
            }
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            if (op == 0)
            {
                op = 12;
            }
            else
            {
                op = 0;
            }
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            if (op == 0)
            {
                op = 13;
            }
            else
            {
                op = 0;
            }
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            if (op == 0)
            {
                op = 14;
            }
            else
            {
                op = 0;
            }
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            if (op == 0)
            {
                op = 15;
            }
            else
            {
                op = 0;
            }
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            if (op == 0)
            {
                op = 16;
            }
            else
            {
                op = 0;
            }
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            if (op == 0)
            {
                op = 17;
            }
            else
            {
                op = 0;
            }
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            if (op == 0)
            {
                op = 18;
            }
            else
            {
                op = 0;
            }
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            if (op == 0)
            {
                op = 19;
            }
            else
            {
                op = 0;
            }
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            if (op == 0)
            {
                op = 20;
            }
            else
            {
                op = 0;
            }
        }

        private void pictureBox21_Click(object sender, EventArgs e)
        {
            if (op == 0)
            {
                op = 21;
            }
            else
            {
                op = 0;
            }
        }

        private void pictureBox22_Click(object sender, EventArgs e)
        {
            if (op == 0)
            {
                op = 22;
            }
            else
            {
                op = 0;
            }
        }

        private void pictureBox23_Click(object sender, EventArgs e)
        {
            if (op == 0)
            {
                op = 23;
            }
            else
            {
                op = 0;
            }
        }

        private void pictureBox24_Click(object sender, EventArgs e)
        {
            if (op == 0)
            {
                op = 24;
            }
            else
            {
                op = 0;
            }
        }

        private void azul_Click(object sender, EventArgs e)
        {
            if (op == 5 || op == 12 || op == 15 || op == 24 || op == 23 || op == 18) //Em 5,12,15,24,23,18 colocar o valor correspondente as Picture Box corretas, esse IF verifica se a variável é igual ao número das correspondentes Picture Box
            {
                MessageBox.Show("Acertou"); 
                pontos = pontos + 10; 
                pontuacao.Text = pontos.ToString(); 
                if (op == 5) 
                {
                    pictureBox5.Visible = false; 
                }
                if (op == 12) 
                {
                    pictureBox12.Visible = false; 
                }
                if (op == 15) 
                {
                    pictureBox15.Visible = false; 
                }
                if (op == 24) 
                {
                    pictureBox24.Visible = false; 
                }
                if (op == 23) 
                {
                    pictureBox23.Visible = false; 
                }
                if (op == 18) 
                {
                    pictureBox18.Visible = false; 
                }
                op = 0;
            }
            else 
            {
                MessageBox.Show("Errou"); 
                pontos = pontos - 5; 
                pontuacao.Text = pontos.ToString(); 
            }


        }

        private void metal_Click(object sender, EventArgs e)
        {
            if (op == 2 || op == 6 || op == 21)
            {
                MessageBox.Show("Acertou");
                pontos = pontos + 10;
                pontuacao.Text = pontos.ToString();
                if (op == 2)
                {
                    pictureBox2.Visible = false;
                }
                if (op == 6)
                {
                    pictureBox6.Visible = false;
                }
                if (op == 21)
                {
                    pictureBox21.Visible = false;
                }
                op = 0;
            }
            else
            {
                MessageBox.Show("Errou");
                pontos = pontos - 5;
                pontuacao.Text = pontos.ToString();
            }
        }

        private void vermelho_Click(object sender, EventArgs e)
        {
            if (op == 4 || op == 14 || op == 13 || op == 11 || op == 9 || op == 20)
            {
                MessageBox.Show("Acertou");
                pontos = pontos + 10;
                pontuacao.Text = pontos.ToString();
                if (op == 4)
                {
                    pictureBox4.Visible = false;
                }
                if (op == 14)
                {
                    pictureBox14.Visible = false;
                }
                if (op == 13)
                {
                    pictureBox13.Visible = false;
                }
                if (op == 11)
                {
                    pictureBox11.Visible = false;
                }
                if (op == 9)
                {
                    pictureBox9.Visible = false;
                }
                if (op == 20)
                {
                    pictureBox20.Visible = false;
                }
                op = 0;
            }
            else
            {
                MessageBox.Show("Errou");
                pontos = pontos - 5;
                pontuacao.Text = pontos.ToString();
            }
        }

        private void verde_Click(object sender, EventArgs e)
        {
            if (op == 3 || op == 7 || op == 8 || op == 10 || op == 16 || op == 17)
            {
                MessageBox.Show("Acertou");
                pontos = pontos + 10;
                pontuacao.Text = pontos.ToString();
                if (op == 3)
                {
                    pictureBox3.Visible = false;
                }
                if (op == 7)
                {
                    pictureBox7.Visible = false;
                }
                if (op == 8)
                {
                    pictureBox8.Visible = false;
                }
                if (op == 10)
                {
                    pictureBox10.Visible = false;

                }
                if (op == 16)
                {
                    pictureBox16.Visible = false;
                }
                if (op == 17)
                {
                    pictureBox17.Visible = false;
                }
                op = 0;
            }
            else
            {
                MessageBox.Show("Errou");
                pontos = pontos - 5;
                pontuacao.Text = pontos.ToString();
            }
        }

        private void marrom_Click(object sender, EventArgs e)
        {
            if (op == 1 || op == 19 || op == 22)
            {
                MessageBox.Show("Acertou");
                pontos = pontos + 10;
                pontuacao.Text = pontos.ToString();
                if (op == 1)
                {
                    pictureBox1.Visible = false;
                }
                if (op == 19)
                {
                    pictureBox19.Visible = false;
                }
                if (op == 22)
                {
                    pictureBox22.Visible = false;
                }
                op = 0;
               
            }
            else
            {
                MessageBox.Show("Errou");
                pontos = pontos - 5;
                pontuacao.Text = pontos.ToString();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            MessageBox.Show("O tempo acabou");
            timer1.Enabled = false;
            Application.Exit();            
        }

        private void pontos_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            min = 0;
            seg = 0;
            op = 0;
            pontos = 0;
            pontuacao.Text = "";
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            pictureBox3.Visible = true;
            pictureBox4.Visible = true;
            pictureBox5.Visible = true;
            pictureBox6.Visible = true;
            pictureBox7.Visible = true;
            pictureBox8.Visible = true;
            pictureBox9.Visible = true;
            pictureBox10.Visible = true;
            pictureBox11.Visible = true;
            pictureBox12.Visible = true;
            pictureBox13.Visible = true;
            pictureBox14.Visible = true;
            pictureBox15.Visible = true;
            pictureBox16.Visible = true;
            pictureBox17.Visible = true;
            pictureBox18.Visible = true;
            pictureBox19.Visible = true;
            pictureBox20.Visible = true;
            pictureBox21.Visible = true;
            pictureBox22.Visible = true;
            pictureBox23.Visible = true;
            pictureBox24.Visible = true;
            timer1.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (op == 1)
            {
                pictureBox1.Left = e.X; //comando para arrastar
                pictureBox1.Top = e.Y;
            }
            else
                if (op == 2)
            {
                pictureBox2.Left = e.X;
                pictureBox2.Top = e.Y;
            }
            else
                    if (op == 3)
            {
                pictureBox3.Left = e.X;
                pictureBox3.Top = e.Y;
            }
            else
                        if (op == 4)
            {
                pictureBox4.Left = e.X;
                pictureBox4.Top = e.Y;
            }
            else
                            if (op == 5)
            {
                pictureBox5.Left = e.X;
                pictureBox5.Top = e.Y;
            }
            else
                                if (op == 6)
            {
                pictureBox6.Left = e.X;
                pictureBox6.Top = e.Y;
            }
            else
                                    if (op == 7)
            {
                pictureBox7.Left = e.X;
                pictureBox7.Top = e.Y;
            }
            else
                                        if (op == 8)
            {
                pictureBox8.Left = e.X;
                pictureBox8.Top = e.Y;
            }
            else
                                            if (op == 9)
            {
                pictureBox9.Left = e.X;
                pictureBox9.Top= e.Y;
            }
            else
                                                if (op == 10)
            {
                pictureBox10.Left = e.X;
                pictureBox10.Top = e.Y;
            }
            else
                                                    if (op == 11)
            {
                pictureBox11.Left = e.X;
                pictureBox11.Top = e.Y;
            }
            else
                                                        if (op == 12)
            {
                pictureBox12.Left = e.X;
                pictureBox12.Top = e.Y;
            }
            else
                                                            if (op == 13)
            {
                pictureBox13.Left = e.X;
                pictureBox13.Top = e.Y;
            }
            else
                                                                if (op == 14)
            {
                pictureBox14.Left = e.X;
                pictureBox14.Top = e.Y;
            }
            else
                                                                    if (op == 15)
            {
                pictureBox15.Left = e.X;
                pictureBox15.Top = e.Y;
            }
            else
                                                                        if (op == 16)
            {
                pictureBox16.Left = e.X;
                pictureBox16.Top = e.Y;
            }
            else
                                                                            if (op == 17)
            {
                pictureBox17.Left = e.X;
                pictureBox17.Top = e.Y;
            }
            else
                                                                                if (op == 18)
            {
                pictureBox18.Left = e.X;
                pictureBox18.Top = e.Y;
            }
            else
                                                                                    if (op == 19)
            {
                pictureBox19.Left = e.X;
                pictureBox19.Top = e.Y;
            }
            else
                                                                                        if (op == 20)
            {
                pictureBox20.Left = e.X;
                pictureBox20.Top = e.Y;
            }
            else
                                                                                            if (op == 21)
            {
                pictureBox21.Left = e.X;
                pictureBox21.Top = e.Y;
            }
            else
                                                                                                if (op == 22)
            {
                pictureBox22.Left = e.X;
                pictureBox22.Top = e.Y;
            }
            else
                                                                                                    if (op == 23)
            {
                pictureBox23.Left = e.X;
                pictureBox23.Top = e.Y;
            }
            else
                                                                                                        if (op == 24)
            {
                pictureBox24.Left = e.X;
                pictureBox24.Top = e.Y;
            }
            
        }
    }
}
