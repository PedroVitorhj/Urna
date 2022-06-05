﻿using System;
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
    public partial class FormPres : Form
    {
        private Voto voto;
        private bool condicao = false;
        private string base_url = "";

        public FormPres(Voto voto)
        {
            InitializeComponent();
            this.voto = voto;
            this.base_url = Application.StartupPath;
        }

        private void FormPres_Load(object sender, EventArgs e)
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
            btnConfirma.Enabled = true;
        }

        private void btnLimpa_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox1.Focus();
        }

        private async void btnConfirma_Click(object sender, EventArgs e)
        {
            string digitos = textBox1.Text.ToString();
            digitos += textBox2.Text.ToString();
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
                voto.incrementaNulo(5);

                this.condicao = true;
                await Task.Delay(1000);
            }

            if (this.condicao)
            {
                FormSair frmsair = new FormSair(voto);
                frmsair.ShowDialog();
            }
        }

        private async void btnBranco_Click(object sender, EventArgs e)
        {
            voto.incrementaBranco(5);
            txtmsgcon.Visible = true;

            txtmsgcon.Text = "Voto Branco!";

            this.condicao = true;
            await Task.Delay(1000);

            FormSair frmSair = new FormSair(voto);
            frmSair.ShowDialog();
        }
    }
}
