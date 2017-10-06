using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menu
{
    public partial class Form1 : Form
    {
        Form2 f2 = new Form2();
        Form3 f3 = new Form3();
        Form4 f4 = new Form4();
        Form5 f5 = new Form5();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void açãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f2.Show();
        }

        private void romanticoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f3.Show();
        }

        private void aventuraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f4.Show();
        }

        private void infantilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f5.Show();
        }
    }
}
