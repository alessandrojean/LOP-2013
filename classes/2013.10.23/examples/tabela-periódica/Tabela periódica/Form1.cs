using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tabela_periódica
{
    public partial class Form1 : Form
    {
        static public int erro = 0, acerto = 0;
        Form2 f2 = new Form2();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

        private void label1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nome: Hidrogênio"+"\n"+"Família: 1A " + "\n" + "Utilizado como gás em diversos usos");
        }

        private void label2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Num sei");
        }

        private void label2_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Nome: Hélio" + "\n" + "Família: 8A" + "\n" + "Utilizado como gás em mergulhos de grande profundidade");
        }

        private void label3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nome: Lítio" + "\n" + "Família: 1A" + "\n" + "Utilizado como poderoso analgésico em operações de risco.");
        }

        private void label4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nome: Berílio" + "\n" + "Família: 2A" + "\n" + "Usado nas lâminas de raio-x");
        }

        private void label5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nome: Boro" + "\n" + "Família: 3A" + "\n" + "Usado nas fabricações de fibras de vidro");
        }

        private void label6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nome: Carbono" + "\n" + "Família: 4A" + "\n" + "Usado nas indústrias siderúrgicas");
        }

        private void label7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nome: Nitrogênio" + "\n" + "Família: 5A" + "\n" + "Usado para armazenar amostras laboratoriais");
        }

        private void label8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nome: Oxigênio" + "\n" + "Família: 6A" + "\n" + "Usado como oxidante");
        }

        private void label9_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nome: Flúor" + "\n" + "Família: 7A" + "\n" + "Usado em odontologia");
        }

        private void label10_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nome: Neônio" + "\n" + "Família: 8A" + "\n" + "Usado em tubos de televisão");
        }

        private void label11_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nome: Sódio" + "\n" + "Família: 1A" + "\n" + "Usado na fabricação de detergentes");
        }

        private void label12_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nome: Magnésio" + "\n" + "Família: 2A" + "\n" + "Usado na fabricação do Leite de Magnésia");
        }

        private void label13_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nome: Alumínio" + "\n" + "Família: 3A" + "\n" + "Usado em embalagens (Papel Alumínio)");
        }

        private void label14_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nome: Silício" + "\n" + "Família: 4A" + "\n" + "Usado na produção de ligas metálicas");
        }

        private void label15_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nome: Fósforo" + "\n" + "Família: 5A" + "\n" + "Usado em palitos de fósforo");
        }

        private void label16_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nome: Enxofre" + "\n" + "Família: 6A" + "\n" + "Usado na produção de Ácido Sulfúrico");
        }

        private void label17_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nome: Cloro" + "\n" + "Família: 7A" + "\n" + "Usado em tratamentos de água");
        }

        private void label18_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nome: Argônio" + "\n" + "Família: 8A" + "\n" + "Usado como gás de enchimento em lâmpadas incandecentes");
        }

        private void label19_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nome: Potássio" + "\n" + "Família: 1A" + "\n" + "Usado em células fotoelétricas");
        }

        private void label20_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nome: Cálcio" + "\n" + "Família: 2A" + "\n" + "Usado em questões nutricionais");
        }

        private void label21_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nome: Escândio" + "\n" + "Família: 3B" + "\n" + "Usado na produção de lâmpadas de vapor de mercúrio");
        }

        private void label22_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nome: Titânio" + "\n" + "Família: 4B" + "\n" + "Usado na condutividade térmica dos computadores");
        }

        private void label23_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nome: Vanádio" + "\n" + "Família: 5B" + "\n" + "Usado na produção de aços inoxidáveis");
        }

        private void label24_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nome: Crômio" + "\n" + "Família: 6B" + "\n" + "Usado em metalurgia");
        }

        private void label25_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nome: Manganês" + "\n" + "Família: 7B" + "\n" + "Usado na fabricação de aço");
        }

        private void label26_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nome: Ferro" + "\n" + "Nome: Hidrogênio" + "\n" + "Família: 8B" + "\n" + "Usado em ligas metálicas");
        }

        private void label27_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nome: Cobalto" + "\n" + "Família: 8B" + "\n" + "Usado em secante para pinturas");
        }

        private void label28_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nome: Níquel" + "\n" + "Família: 8B" + "\n" + "Usado na fabricação de aço inoxidável");
        }

        private void label29_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nome: Cobre" + "\n" + "Família: 1B" + "\n" + "Usado como condutor em fios de cobre");
        }

        private void label30_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nome: Zinco" + "\n" + "Família: 2B" + "\n" + "Usado na produção de ligas metálicas");
        }

        private void label6_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Nome: Carbono" + "\n" + "Família: 4A" + "\n" + "Usado nas indústrias siderúrgicas");
        }

        private void label31_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nome: Gálio" + "\n" + "Família: 3A" + "\n" + "Usado na construção de espelhos");
        }

        private void label32_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nome: Germânio" + "\n" + "Família: 4A" + "\n" + "Usado e fibras ópticas");
        }

        private void label33_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nome: Arsênio" + "\n" + "Família: 5A" + "\n" + "Usado como conservante de couro");
        }

        private void label34_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nome: Selênio" + "\n" + "Família: 6A" + "\n" + "Usado em aplicações eletrônicas");
        }

        private void label35_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nome: Bromo" + "\n" + "Família: 7A" + "\n" + "Usado em aditivos de gasolina");
        }

        private void label36_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nome: Criptônio" + "\n" + "Família: 8A" + "\n" + "Usado em lâmpadas fluorecentes");
        }

        private void label54_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nome: Rubídio" + "\n" + "Família: 1A" + "\n" + "Usado em motores iônicos");
        }

        private void label53_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nome: Estrôncio" + "\n" + "Família: 2A" + "\n" + "Usado em pirotecnia");
        }

        private void label52_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nome: Ítrio" + "\n" + "Família: 3B" + "\n" + "Usado nas produção de granadas");
        }

        private void label51_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nome: Zircônio" + "\n" + "Família: 4B" + "\n" + "Usado em revestimento de reatores nucleares");
        }

        private void label50_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nome: Nióbio" + "\n" + "Família: 5B" + "\n" + "Usado em soldas elétricas");
        }

        private void label49_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nome: Molibdênio" + "\n" + "Família: 6B" + "\n" + "Usado como catalisador");
        }

        private void label48_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nome: Tecnécio" + "\n" + "Família: 7B" + "\n" + "Usado em medicina nuclear");
        }

        private void label47_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nome: Rutênio" + "\n" + "Família: 8B" + "\n" + "Usado como catalisador");
        }

        private void label46_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nome: Ródio" + "\n" + "Família: 8B" + "\n" + "Usado como material de contato elétrico");
        }

        private void label45_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nome: Paládio" + "\n" + "Família: 8B" + "\n" + "Usado em odontologia");
        }

        private void label44_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nome: Prata" + "\n" + "Família: 1B" + "\n" + "Usado em joalheria");
        }

        private void label43_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nome: Cádmio" + "\n" + "Família: 2B" + "\n" + "Usado na fabricação de baterias");
        }

        private void label42_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nome: Índio" + "\n" + "Família: 3A" + "\n" + "Usado na produção de telas de cristais líquidos");
        }

        private void label41_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nome: Estanho" + "\n" + "Família: 4A" + "\n" + "Usado na indústria automotiva");
        }

        private void label40_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nome: Antimônio" + "\n" + "Família: 5A" + "\n" + "Usado em revestimentos de cabos");
        }

        private void label39_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nome: Telúrio" + "\n" + "Família: 6A" + "\n" + "Usado em ligas metálicas");
        }

        private void label38_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nome: Iodo" + "\n" + "Família: 7A" + "\n" + "Usado na tintura de iodo");
        }

        private void label37_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nome: Xenônio" + "\n" + "Família: 8A" + "\n" + "Usado como anestésico");
        }

        private void label72_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nome: Césio" + "\n" + "Família: 1A" + "\n" + "Usado na construção de relógios atômicos");
        }

        private void label71_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nome: Bário" + "\n" + "Família: 2A" + "\n" + "Usado em velas de ignição");
        }

        private void label105_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nome: Lantânio" + "\n" + "Família: 3B" + "\n" + "Usado na indústria cinematográfica");
        }

        private void label104_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nome: Cério" + "\n" + "Família: 3B" + "\n" + "Usado na metalurgia");
        }

        private void label103_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nome: Praseodímio" + "\n" + "Família: 3B" + "\n" + "Usado em ligas metálicas");
        }

        private void label102_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nome: Neodímio" + "\n" + "Família: 3B" + "\n" + "Usado como tintura para vidros");
        }

        private void label101_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nome: Promécio" + "\n" + "Família: 3B" + "\n" + "Usado como fonte de radiações beta");
        }

        private void label100_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nome: Samário" + "\n" + "Família: 3B" + "\n" + "Usado em lâmpadas de elétrodos de carbono");
        }

        private void label99_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nome: Európio" + "\n" + "Família: 3B" + "\n" + "Usado na fabricação de plástico");
        }

        private void label98_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nome: Gadolínio" + "\n" + "Família: 3B" + "\n" + "Usado em microondas");
        }

        private void label97_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nome: Térbio" + "\n" + "Família: 3B" + "\n" + "Usado em dispositivos semicondutores");
        }

        private void label96_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nome: Disprósio" + "\n" + "Família: 3B" + "\n" + "Usado em lasers");
        }

        private void label95_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nome: Hôlmio" + "\n" + "Família: 3B" + "\n" + "Usado como aditivo em ligas metálicas");
        }

        private void label94_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nome: Érbio" + "\n" + "Família: 3B" + "\n" + "Usado em filtros fotográficos");
        }

        private void label93_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nome: Túlio" + "\n" + "Família: 3B" + "\n" + "Usado na produção de lasers");
        }

        private void label92_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nome: Itérbio" + "\n" + "Família: 3B" + "\n" + "Usado em imãs");
        }

        private void label91_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nome: Lutécio" + "\n" + "Família: 3B" + "\n" + "Usado como catalisador");
        }

        private void label69_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nome: Háfnio" + "\n" + "Família: 4B" + "\n" + "Usado em reatores nucleares");
        }

        private void label68_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nome: Tântalo" + "\n" + "Família: 5B" + "\n" + "Usado como material dielétrico");
        }

        private void label67_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nome: Tungstênio" + "\n" + "Família: 6B" + "\n" + "Usado em joalheria");
        }

        private void label66_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nome: Rênio" + "\n" + "Família: 7B" + "\n" + "Usado como material de contato elétrico");
        }

        private void label65_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nome: Ósmio" + "\n" + "Família: 8B" + "\n" + "Usado em penas de caneta de tinteiro");
        }

        private void label64_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nome: Irídio" + "\n" + "Família: 8B" + "\n" + "Usado em contatos elétricos");
        }

        private void label63_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nome: Platina" + "\n" + "Família: 8B" + "\n" + "Usado em acabamentos de armas de luxo");
        }

        private void label62_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nome: Ouro" + "\n" + "Família: 1B" + "\n" + "Usado em joalheria");
        }

        private void label61_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nome: Mercúrio" + "\n" + "Família: 2B" + "\n" + "Usado em termômetros");
        }

        private void label60_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nome: Tálio" + "\n" + "Família: 3A" + "\n" + "Usado na fabricação de fotocélulas");
        }

        private void label59_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nome: Chumbo" + "\n" + "Família: 4A" + "\n" + "Usado na fabricação de acumuladores");
        }

        private void label58_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nome: Bismuto" + "\n" + "Família: 5A" + "\n" + "Usado em cosméticos");
        }

        private void label57_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nome: Polônio" + "\n" + "Família: 6A" + "\n" + "Usado em velas");
        }

        private void label56_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nome: Astato" + "\n" + "Família: 7A" + "\n" + "Não é conhecido nenhum uso desse elemento");
        }

        private void label55_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nome: Radônio" + "\n" + "Família: 8A" + "\n" + "Usado em terapias contra o câncer");
        }

        private void label90_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nome: Frâncio" + "\n" + "Família: 1A" + "\n" + "Usado em tarefas de investigação");
        }

        private void label89_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nome: Rádio" + "\n" + "Família: 2A" + "\n" + "Usado como tinta luminiscente");
        }

        private void label120_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nome: Actínio" + "\n" + "Família: 3B" + "\n" + "Usado na medicina");
        }

        private void label119_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nome: Tório" + "\n" + "Família: 3B" + "\n" + "Usado como catalisador");
        }

        private void label118_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nome: Protactínio" + "\n" + "Família: 3B" + "\n" + "Usado em pesquisa científica básica");
        }

        private void label117_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nome: Urânio" + "\n" + "Família: 3B" + "\n" + "Usado em fotografia");
        }

        private void label116_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nome: Netúnio" + "\n" + "Família: 3B" + "\n" + "Usado como detector de nêutrons");
        }

        private void label115_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nome: Plutônio" + "\n" + "Família: 3B" + "\n" + "Usado em armas nucleares");
        }

        private void label114_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nome: Amerício" + "\n" + "Família: 3B" + "\n" + "Usado em detectores de fumaça");
        }

        private void label113_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nome: Cúrio" + "\n" + "Família: 3B" + "\n" + "Usado em geradores termoelétricos");
        }

        private void label112_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nome: Berquélio" + "\n" + "Família: 3B" + "\n" + "Não é conhecido nenhum uso");
        }

        private void label111_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nome: Califórnio" + "\n" + "Família: 3B" + "\n" + "Usado em reatores nucleares");
        }

        private void label110_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nome: Einstênio" + "\n" + "Família: 3B" + "\n" + "Não é conhecido nenhum uso");
        }

        private void label109_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nome: Férmio" + "\n" + "Família: 3B" + "\n" + "Usado em bombas");
        }

        private void label108_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nome: Mendelévio" + "\n" + "Família: 3B" + "\n" + "Não é conhecido nenhum uso");
        }

        private void label107_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nome: Nobélio" + "\n" + "Família: 3B" + "\n" + "Não é conhecido nenhum uso");
        }

        private void label106_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nome: Laurêncio" + "\n" + "Família: 3B" + "\n" + "Não é conhecido nenhum uso");
        }

        private void label87_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nome: Rutherfórdio" + "\n" + "Família: 4B" + "\n" + "Não é conhecido nenhum uso");
        }

        private void label86_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nome: Dúbnio "+ "\n" + "Família: 5B" + "\n" + "Não é conhecido nenhum uso");
        }

        private void label85_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nome: Seabórgio" + "\n" + "Família: 6B" + "\n" + "Não é conhecido nenhum uso");
        }

        private void label84_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nome: Bóhrio" + "\n" + "Família: 7B" + "\n" + "Não é conhecido nenhum uso");
        }

        private void label83_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nome: Hássio" + "\n" + "Família: 8B" + "\n" + "Não é conhecido nenhum uso");
        }

        private void label82_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nome: Meitnério" + "\n" + "Família: 8B" + "\n" + "Não é conhecido nenhum uso");
        }

        private void label81_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nome: Darmstádtio" + "\n" + "Família: 8B" + "\n" + "Não é conhecido nenhum uso");
        }

        private void label80_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nome: Roentgênio" + "\n" + "Família: 1B" + "\n" + "Não é conhecido nenhum uso");
        }

        private void label79_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nome: Compernício" + "\n" + "Família: 2B" + "\n" + "Não é conhecido nenhum uso");
        }

        private void label78_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nome: Unúntrio" + "\n" + "Família: 3A" + "\n" + "Não é conhecido nenhum uso");
        }

        private void label77_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nome: Ununquádio" + "\n" + "Família: 4A" + "\n" + "Não é conhecido nenhum uso");
        }

        private void label76_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nome: Ununpentio" + "\n" + "Família: 5A" + "\n" + "Não é conhecido nenhum uso");
        }

        private void label75_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nome: Ununhéxio" + "\n" + "Família: 6A" + "\n" + "Não é conhecido nenhum uso");
        }

        private void label74_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nome: Ununséptio" + "\n" + "Família: 7A" + "\n" + "Não é conhecido nenhum uso");
        }

        private void label73_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nome: Ununóctio" + "\n" + "Família: 8A" + "\n" + "Não é conhecido nenhum uso");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            f2.Visible = true;
        }
    }
}
