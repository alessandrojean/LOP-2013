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
    public partial class Form1 : Form
    {
        Form2 f2 = new Form2(); //Define uma variável que instancia a Form2
        public Form1()
        {
            InitializeComponent();
        }

        private void Incluir_Click(object sender, EventArgs e)
        {
            f2.listBox1.Items.Add(txtrm.Text); //Adiciona o conteúdo de txtrm em listbox1
            f2.listBox2.Items.Add(txtnome.Text); //Adiciona o conteúdo de txtnome em listbox2
            f2.listBox3.Items.Add(txtend.Text); //Adiciona o conteúdo de txtend em listbox3
        }

        private void button1_Click(object sender, EventArgs e)
        {
            f2.Visible = true;
        }
    }
}
