using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exemplo_listbox
{
    public partial class Form2 : Form
    {
        int indice = -1;
        public Form2()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (indice != -1)
            {
                listBox1.Items.RemoveAt(indice);
                listBox2.Items.RemoveAt(indice);
                listBox3.Items.RemoveAt(indice);
            }
            else
            {
                MessageBox.Show("Selecione um RM para remover");
            }
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void listBox1_Click(object sender, EventArgs e)
        {
            indice = listBox1.SelectedIndex;
            listBox2.SelectedIndex = indice;
            listBox3.SelectedIndex = indice;
        }
    }
}
