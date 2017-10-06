using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jogo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void foto_Click(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                foto.Top = foto.Top - 10;
            }
            if (e.KeyCode == Keys.Down)
            {
                foto.Top = foto.Top + 10;
            }
            if (e.KeyCode == Keys.Right)
            {
                foto.Left = foto.Left + 10;
            }
            if (e.KeyCode == Keys.Left)
            {
                foto.Left = foto.Left - 10;
            }
            if (foto.Top>194)
            {
                foto.Top = 194;
            }
            if (foto.Top < 0)
            {
                foto.Top = 0;
            }
            if (foto.Left > 185)
            {
                foto.Left = 185;
            }
            if (foto.Left < 0)
            {
                foto.Left = 0;
            }

        }
    }
}
