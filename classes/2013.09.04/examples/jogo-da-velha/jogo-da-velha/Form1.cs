using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P_R_O_J_E_T_Ã_O_DA_VELHA
{
    public partial class Form1 : Form
    {
        string x = "X";
        int cont = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void b1_Click(object sender, EventArgs e)
        {
            if (b1.Text == "")
            {
                b1.Text = x;
                if (x == "X")
                {
                    x = "O";
                }
                else
                {
                    x = "X";
                }
                cont++;
                b1.Enabled = false;
                conferir();
                
            }
            }

        private void b2_Click(object sender, EventArgs e)
        {
        if (b2.Text == "")
            {
                b2.Text = x;
                if (x == "X")
                {
                    x = "O";
                }
                else
                {
                    x = "X";
                }
                cont++;
                b2.Enabled = false;
                conferir();
                
            }
        }

        private void b3_Click(object sender, EventArgs e)
        {
            if (b3.Text == "")
            {
                b3.Text = x;
                if (x == "X")
                {
                    x = "O";
                }
                else
                {
                    x = "X";
                }
                cont++;
                b3.Enabled = false;
                conferir();
                
            }
        }

        private void zerar()
        {
            if (MessageBox.Show("Jogar novamente ?", "Continuar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                cont = 0;
                b1.Enabled = true; b1.Text = "";
                b2.Enabled = true; b2.Text = "";
                b3.Enabled = true; b3.Text = "";
                b4.Enabled = true; b4.Text = "";
                b5.Enabled = true; b5.Text = "";
                b6.Enabled = true; b6.Text = "";
                b7.Enabled = true; b7.Text = "";
                b8.Enabled = true; b8.Text = "";
                b9.Enabled = true; b9.Text = "";
                
            }
            else
            {
                Application.Exit();
            }
        }


    private void conferir()
{
    
        if (b1.Text == "X" && b2.Text == "X" && b3.Text == "X")
        {
            MessageBox.Show("O jogador X venceu!");
            zerar();
        }
        if (b4.Text == "X" && b5.Text == "X" && b6.Text == "X")
        {
            MessageBox.Show("O jogador X venceu!");
            zerar();
        }
        if (b7.Text == "X" && b8.Text == "X" && b9.Text == "X")
        {
            MessageBox.Show("O jogador X venceu!");
            zerar();
        }
        if (b1.Text == "X" && b4.Text == "X" && b7.Text == "X")
        {
            MessageBox.Show("O jogador X venceu!");
            zerar();
        }
        if (b2.Text == "X" && b5.Text == "X" && b8.Text == "X")
        {
            MessageBox.Show("O jogador X venceu!");
            zerar();
        }
        if (b3.Text == "X" && b6.Text == "X" && b9.Text == "X")
        {
            MessageBox.Show("O jogador X venceu!");
            zerar();
        }
        if (b1.Text == "X" && b5.Text == "X" && b9.Text == "X")
        {
            MessageBox.Show("O jogador X venceu!");
            zerar();
        }
        if (b3.Text == "X" && b5.Text == "X" && b7.Text == "X")
        {
            MessageBox.Show("O jogador X venceu!");
            zerar();
        }


        if (b4.Text == "O" && b5.Text == "O" && b6.Text == "O")
        {
            MessageBox.Show("O jogador O venceu!");
            zerar();
        }
        if (b7.Text == "O" && b8.Text == "O" && b9.Text == "O")
        {
            MessageBox.Show("O jogador O venceu!");
            zerar();
        }
        if (b1.Text == "O" && b4.Text == "O" && b7.Text == "O")
        {
            MessageBox.Show("O jogador O venceu!");
            zerar();
        }
        if (b2.Text == "O" && b5.Text == "O" && b8.Text == "O")
        {
            MessageBox.Show("O jogador X venceu!");
            zerar();
        }
        if (b3.Text == "O" && b6.Text == "O" && b9.Text == "O")
        {
            MessageBox.Show("O jogador O venceu!");
            zerar();
        }
        if (b1.Text == "O" && b5.Text == "O" && b9.Text == "O")
        {
            MessageBox.Show("O jogador O venceu!");
            zerar();
        }
        if (b3.Text == "O" && b5.Text == "O" && b7.Text == "O")
        {
            MessageBox.Show("O jogador O venceu!");
            zerar();
        }
        if (b1.Enabled == false && b2.Enabled == false && b3.Enabled == false && b4.Enabled == false && b5.Enabled == false && b6.Enabled == false && b7.Enabled == false && b8.Enabled == false && b9.Enabled == false)
        {
            MessageBox.Show("Deu velha");
            zerar();
        }
      
   
}

    private void Form1_FormClosing(object sender, FormClosingEventArgs e)
    {
        Application.Exit();
    }

    private void b4_Click(object sender, EventArgs e)
    {
        if (b4.Text == "")
        {
            b4.Text = x;
            if (x == "X")
            {
                x = "O";
            }
            else
            {
                x = "X";
            }
            cont++;
            b4.Enabled = false;
            conferir();
            
        }
    }

    private void b5_Click(object sender, EventArgs e)
    {
        if (b5.Text == "")
        {
            b5.Text = x;
            if (x == "X")
            {
                x = "O";
            }
            else
            {
                x = "X";
            }
            cont++;
            b5.Enabled = false;
            conferir();
            
        }
    }

    private void b6_Click(object sender, EventArgs e)
    {
        if (b6.Text == "")
        {
            b6.Text = x;
            if (x == "X")
            {
                x = "O";
            }
            else
            {
                x = "X";
            }
            cont++;
            b6.Enabled = false;
            conferir();
            
        }
    }

    private void b7_Click(object sender, EventArgs e)
    {
        if (b7.Text == "")
        {
            b7.Text = x;
            if (x == "X")
            {
                x = "O";
            }
            else
            {
                x = "X";
            }
            cont++;
            b7.Enabled = false;
            conferir();
            
        }
    }

    private void b8_Click(object sender, EventArgs e)
    {
        if (b8.Text == "")
        {
            b8.Text = x;
            if (x == "X")
            {
                x = "O";
            }
            else
            {
                x = "X";
            }
            cont++;
            b8.Enabled = false;
            conferir();
            
        }
    }

    private void b9_Click(object sender, EventArgs e)
    {
        if (b9.Text == "")
        {
            b9.Text = x;
            if (x == "X")
            {
                x = "O";
            }
            else
            {
                x = "X";
            }
            cont++;
            b9.Enabled = false;
            conferir();
            
        }
    }

    private void Form1_FormClosed(object sender, FormClosedEventArgs e)
    {
       
    }

    }
}
