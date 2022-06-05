namespace Urna_Final
{
    partial class FormDepFed
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtmsgcon = new System.Windows.Forms.TextBox();
            this.txtNomeCand = new System.Windows.Forms.TextBox();
            this.FotoCand = new System.Windows.Forms.PictureBox();
            this.btnLimpa = new System.Windows.Forms.Button();
            this.txtNomePartido = new System.Windows.Forms.TextBox();
            this.btnConfirma = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labDepFed = new System.Windows.Forms.Label();
            this.btnBranco = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.FotoCand)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtmsgcon
            // 
            this.txtmsgcon.BackColor = System.Drawing.SystemColors.Control;
            this.txtmsgcon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtmsgcon.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmsgcon.Location = new System.Drawing.Point(45, 98);
            this.txtmsgcon.Name = "txtmsgcon";
            this.txtmsgcon.Size = new System.Drawing.Size(428, 19);
            this.txtmsgcon.TabIndex = 16;
            this.txtmsgcon.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNomeCand
            // 
            this.txtNomeCand.BackColor = System.Drawing.SystemColors.Control;
            this.txtNomeCand.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNomeCand.Enabled = false;
            this.txtNomeCand.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeCand.Location = new System.Drawing.Point(515, 348);
            this.txtNomeCand.Name = "txtNomeCand";
            this.txtNomeCand.Size = new System.Drawing.Size(245, 19);
            this.txtNomeCand.TabIndex = 15;
            this.txtNomeCand.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FotoCand
            // 
            this.FotoCand.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FotoCand.Location = new System.Drawing.Point(515, 127);
            this.FotoCand.Name = "FotoCand";
            this.FotoCand.Size = new System.Drawing.Size(244, 196);
            this.FotoCand.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.FotoCand.TabIndex = 14;
            this.FotoCand.TabStop = false;
            // 
            // btnLimpa
            // 
            this.btnLimpa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnLimpa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpa.Location = new System.Drawing.Point(45, 364);
            this.btnLimpa.Name = "btnLimpa";
            this.btnLimpa.Size = new System.Drawing.Size(113, 43);
            this.btnLimpa.TabIndex = 13;
            this.btnLimpa.Text = "LIMPA";
            this.btnLimpa.UseVisualStyleBackColor = false;
            this.btnLimpa.Click += new System.EventHandler(this.btnLimpa_Click);
            // 
            // txtNomePartido
            // 
            this.txtNomePartido.BackColor = System.Drawing.SystemColors.Control;
            this.txtNomePartido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNomePartido.Enabled = false;
            this.txtNomePartido.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomePartido.Location = new System.Drawing.Point(515, 93);
            this.txtNomePartido.Name = "txtNomePartido";
            this.txtNomePartido.Size = new System.Drawing.Size(245, 19);
            this.txtNomePartido.TabIndex = 12;
            this.txtNomePartido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnConfirma
            // 
            this.btnConfirma.BackColor = System.Drawing.Color.Green;
            this.btnConfirma.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirma.Location = new System.Drawing.Point(189, 364);
            this.btnConfirma.Name = "btnConfirma";
            this.btnConfirma.Size = new System.Drawing.Size(113, 43);
            this.btnConfirma.TabIndex = 11;
            this.btnConfirma.Text = "CONFIRMA";
            this.btnConfirma.UseVisualStyleBackColor = false;
            this.btnConfirma.Click += new System.EventHandler(this.btnConfirma_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.textBox4);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Location = new System.Drawing.Point(45, 123);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(428, 200);
            this.panel1.TabIndex = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(585, 190);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(151, 112);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(320, 48);
            this.textBox4.MaxLength = 1;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(80, 116);
            this.textBox4.TabIndex = 3;
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(223, 48);
            this.textBox3.MaxLength = 1;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(80, 116);
            this.textBox3.TabIndex = 2;
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(128, 48);
            this.textBox2.MaxLength = 1;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(80, 116);
            this.textBox2.TabIndex = 1;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(24, 48);
            this.textBox1.MaxLength = 1;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(80, 116);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // labDepFed
            // 
            this.labDepFed.AutoSize = true;
            this.labDepFed.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labDepFed.Location = new System.Drawing.Point(39, 43);
            this.labDepFed.Name = "labDepFed";
            this.labDepFed.Size = new System.Drawing.Size(722, 31);
            this.labDepFed.TabIndex = 9;
            this.labDepFed.Text = "Digite os 4 digitos do seu candidato para Deputado Federal !";
            // 
            // btnBranco
            // 
            this.btnBranco.BackColor = System.Drawing.SystemColors.Window;
            this.btnBranco.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBranco.Location = new System.Drawing.Point(332, 364);
            this.btnBranco.Name = "btnBranco";
            this.btnBranco.Size = new System.Drawing.Size(113, 43);
            this.btnBranco.TabIndex = 17;
            this.btnBranco.Text = "BRANCO";
            this.btnBranco.UseVisualStyleBackColor = false;
            this.btnBranco.Click += new System.EventHandler(this.btnBranco_Click);
            // 
            // FormDepFed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBranco);
            this.Controls.Add(this.txtmsgcon);
            this.Controls.Add(this.txtNomeCand);
            this.Controls.Add(this.FotoCand);
            this.Controls.Add(this.btnLimpa);
            this.Controls.Add(this.txtNomePartido);
            this.Controls.Add(this.btnConfirma);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labDepFed);
            this.Name = "FormDepFed";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Deputado Federal";
            this.Load += new System.EventHandler(this.FormDepFed_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FotoCand)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtmsgcon;
        private System.Windows.Forms.TextBox txtNomeCand;
        private System.Windows.Forms.PictureBox FotoCand;
        private System.Windows.Forms.Button btnLimpa;
        private System.Windows.Forms.TextBox txtNomePartido;
        private System.Windows.Forms.Button btnConfirma;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labDepFed;
        private System.Windows.Forms.Button btnBranco;
    }
}

