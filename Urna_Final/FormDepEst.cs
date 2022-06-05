using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Urna_Final
{
    public partial class FormDepEst : Form
    {
        private Voto voto;
        private bool condicao = false;
        private string base_url = "";

        public FormDepEst(Voto voto)
        {
            InitializeComponent();

            this.voto = voto;
            this.base_url = Application.StartupPath;

        }

        private void FormDepEst_Load(object sender, EventArgs e)
        {
            textBox1.Focus();
            txtNomePartido.Visible = false;
            txtmsgcon.Visible = false;
            txtNomeCand.Visible = false;
            btnConfirma.Enabled = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != null)
            {
                textBox2.Focus();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text != null)
            {
                textBox3.Focus();
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text != null)
            {
                textBox4.Focus();
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (textBox4.Text != null)
            {
                textBox5.Focus();
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            btnConfirma.Enabled = true;
        }

        private void btnLimpa_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox1.Focus();
        }

        private async void btnConfirma_Click(object sender, EventArgs e)
        {
            string digitos = textBox1.Text.ToString();
            digitos += textBox2.Text.ToString();
            digitos += textBox3.Text.ToString();
            digitos += textBox4.Text.ToString();
            digitos += textBox5.Text.ToString();

            Candidato cand = voto.PesquisarDigitos(digitos);

            if (cand != null)
            {
                txtNomePartido.Visible = true;
                txtmsgcon.Visible = true;
                txtNomeCand.Visible = true;
                FotoCand.BackgroundImage = Image.FromFile(base_url + cand.getUrl());
                txtNomePartido.Text = cand.getPart();
                txtNomeCand.Text = cand.getNome();
                cand.IncrementaVoto();
                txtmsgcon.Visible = true;
                txtmsgcon.Text = "Voto Computado!";

                this.condicao = true;

                await Task.Delay(2000);

            }
            else
            {
                txtmsgcon.Visible = true;
                txtmsgcon.Text = "Voto Anulado!";
                voto.incrementaNulo(2);

                this.condicao = true;
                await Task.Delay(1000);
            }

            if (this.condicao)
            {
                FormSen frmsen = new FormSen(voto);
                frmsen.ShowDialog();
            }
        }

        private async void btnBranco_Click(object sender, EventArgs e)
        {
            voto.incrementaBranco(2);
            txtmsgcon.Visible = true;

            txtmsgcon.Text = "Voto Branco!";
            this.condicao = true;
            await Task.Delay(1000);


            FormSen frmsen = new FormSen(voto);
            frmsen.ShowDialog();
        }
    }
}
