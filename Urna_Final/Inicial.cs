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
    public partial class Inicial : Form
    {
        public Inicial()
        {
            InitializeComponent();
        }

        private Voto voto;

        private void Inicial_Load(object sender, EventArgs e)
        {
            voto = new Voto();
            voto.LoadCanditados();

            string digitos1 = "1234";
            Candidato cand1 = voto.PesquisarDigitos(digitos1);

            txtfed1.Text = cand1.getNome();
            txtvotofed1.Text = cand1.getVotos().ToString();
            digit1.Text = cand1.getDigitos().ToString();

            string digitos2 = "5678";
            Candidato cand2 = voto.PesquisarDigitos(digitos2);

            txtfed2.Text = cand2.getNome();
            txtvotofed2.Text = cand2.getVotos().ToString();
            digit2.Text = cand2.getDigitos().ToString();

            string digitos3 = "12345";
            Candidato cand3 = voto.PesquisarDigitos(digitos3);

            txtest1.Text = cand3.getNome();
            txtvotoest1.Text = cand3.getVotos().ToString();
            digit3.Text = cand3.getDigitos().ToString();

            string digitos4 = "54321";
            Candidato cand4 = voto.PesquisarDigitos(digitos4);

            txtest2.Text = cand4.getNome();
            txtvotoest2.Text = cand4.getVotos().ToString();
            digit4.Text = cand4.getDigitos().ToString();


            string digitos5 = "789";
            Candidato cand5 = voto.PesquisarDigitos(digitos5);

            txtsen1.Text = cand5.getNome();
            txtvotosen1.Text = cand5.getVotos().ToString();
            digit5.Text = cand5.getDigitos().ToString();


            string digitos6 = "456";
            Candidato cand6 = voto.PesquisarDigitos(digitos6);

            txtsen2.Text = cand6.getNome();
            txtvotosen2.Text = cand6.getVotos().ToString();
            digit6.Text = cand6.getDigitos().ToString();


            string digitos7 = "45";
            Candidato cand7 = voto.PesquisarDigitos(digitos7);

            txtgov1.Text = cand7.getNome();
            txtvotogov1.Text = cand7.getVotos().ToString();
            digit7.Text = cand7.getDigitos().ToString();


            string digitos8 = "50";
            Candidato cand8 = voto.PesquisarDigitos(digitos8);

            txtgov2.Text = cand8.getNome();
            txtvotogov2.Text = cand8.getVotos().ToString();
            digit8.Text = cand8.getDigitos().ToString();


            string digitos9 = "13";
            Candidato cand9 = voto.PesquisarDigitos(digitos9);

            txtpres1.Text = cand9.getNome();
            txtvotopres1.Text = cand9.getVotos().ToString();
            digit9.Text = cand9.getDigitos().ToString();

            string digitos10 = "17";
            Candidato cand10 = voto.PesquisarDigitos(digitos10);

            txtpres2.Text = cand10.getNome();
            txtvotopres2.Text = cand10.getVotos().ToString();
            digit10.Text = cand10.getDigitos().ToString();

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void btnVotar_Click(object sender, EventArgs e)
        {
            FormDepFed frmdepfed = new FormDepFed(voto);
            frmdepfed.ShowDialog();
        }

        private void txtfed1_TextChanged(object sender, EventArgs e)
        {
            


        }
        private void txtvotofed1_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtfed2_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void txtvotofed2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtest2_TextChanged(object sender, EventArgs e) 
        {

        }

        private void txtsen1_TextChanged(object sender, EventArgs e) 
        {

        }

        private void txtsen2_TextChanged(object sender, EventArgs e) 
        {

        }

        private void txtgov1_TextChanged(object sender, EventArgs e) 
        {
        
        }

        private void txtgov2_TextChanged(object sender, EventArgs e) 
        {
           
        }

        private void txtpres1_TextChanged(object sender, EventArgs e) 
        {
           
        }

        private void txtpres2_TextChanged(object sender, EventArgs e) 
        {
        
        }
    }
}
