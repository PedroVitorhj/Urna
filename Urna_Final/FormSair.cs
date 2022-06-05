using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Urna_Final
{
    public partial class FormSair : Form
    {
        private Voto voto;

        public FormSair(Voto voto)
        {
            InitializeComponent();
            this.voto = voto;
        }

        private void FormSair_Load(object sender, EventArgs e)
        {


            string digitos1 = "1234";
            Candidato cand1 = voto.PesquisarDigitos(digitos1);

            txtfed1.Text = cand1.getNome();
            txtvotofed1.Text = cand1.getVotos().ToString();

            string digitos2 = "5678";
            Candidato cand2 = voto.PesquisarDigitos(digitos2);

            txtfed2.Text = cand2.getNome();
            txtvotofed2.Text = cand2.getVotos().ToString();

            string digitos3 = "12345";
            Candidato cand3 = voto.PesquisarDigitos(digitos3);

            txtest1.Text = cand3.getNome();
            txtvotoest1.Text = cand3.getVotos().ToString();

            string digitos4 = "54321";
            Candidato cand4 = voto.PesquisarDigitos(digitos4);

            txtest2.Text = cand4.getNome();
            txtvotoest2.Text = cand4.getVotos().ToString();


            string digitos5 = "789";
            Candidato cand5 = voto.PesquisarDigitos(digitos5);

            txtsen1.Text = cand5.getNome();
            txtvotosen1.Text = cand5.getVotos().ToString();


            string digitos6 = "456";
            Candidato cand6 = voto.PesquisarDigitos(digitos6);

            txtsen2.Text = cand6.getNome();
            txtvotosen2.Text = cand6.getVotos().ToString();


            string digitos7 = "45";
            Candidato cand7 = voto.PesquisarDigitos(digitos7);

            txtgov1.Text = cand7.getNome();
            txtvotogov1.Text = cand7.getVotos().ToString();


            string digitos8 = "50";
            Candidato cand8 = voto.PesquisarDigitos(digitos8);

            txtgov2.Text = cand8.getNome();
            txtvotogov2.Text = cand8.getVotos().ToString();


            string digitos9 = "13";
            Candidato cand9 = voto.PesquisarDigitos(digitos9);

            txtpres1.Text = cand9.getNome();
            txtvotopres1.Text = cand9.getVotos().ToString();

            string digitos10 = "17";
            Candidato cand10 = voto.PesquisarDigitos(digitos10);

            txtpres2.Text = cand10.getNome();
            txtvotopres2.Text = cand10.getVotos().ToString();


            txtnulo1.Text = "Deputado Federal";
            txtvotonulo1.Text = voto.getVotonulodepfed().ToString();

            txtnulo2.Text = "Deputado Estadual";
            txtvotonulo2.Text = voto.getVotonulodepest().ToString();

            txtnulo3.Text = "Senador";
            txtvotonulo3.Text = voto.getVotonulosen().ToString();

            txtnulo4.Text = "Governador";
            txtvotonulo4.Text = voto.getVotonulogov().ToString();

            txtnulo5.Text = "Presidente";
            txtvotonulo5.Text = voto.getVotonulopres().ToString();

            txtbranco1.Text = "Deputado Federal";
            txtvotobranco1.Text = voto.getVotobrancoDepFed().ToString();

            txtbranco2.Text = "Deputado Estadual";
            txtvotobranco2.Text = voto.getVotobrancoDepest().ToString();

            txtbranco3.Text = "Senador";
            txtvotobranco3.Text = voto.getVotobrancosen().ToString();

            txtbranco4.Text = "Governador";
            txtvotobranco4.Text = voto.getVotobrancosgov().ToString();

            txtbranco5.Text = "Presidente";
            txtvotobranco5.Text = voto.getVotobrancospres().ToString();

        }

        private void btnSai_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label14_Click(object sender, EventArgs e) {

        }

        private void label12_Click(object sender, EventArgs e) {

        }

        private void textBox2_TextChanged(object sender, EventArgs e) {

        }

        private void label13_Click(object sender, EventArgs e) {

        }

        private void textBox3_TextChanged(object sender, EventArgs e) {

        }

        private void textBox1_TextChanged(object sender, EventArgs e) {

        }

        private void textBox4_TextChanged(object sender, EventArgs e) {

        }
    }
}
