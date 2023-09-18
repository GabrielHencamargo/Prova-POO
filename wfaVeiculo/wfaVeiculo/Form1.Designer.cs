namespace wfaVeiculo
{
    partial class Form1
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
            this.rbcaminhao = new System.Windows.Forms.RadioButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.rbOnibus = new System.Windows.Forms.RadioButton();
            this.lbPlaca = new System.Windows.Forms.Label();
            this.lbAno = new System.Windows.Forms.Label();
            this.lbaltera = new System.Windows.Forms.Label();
            this.tbano = new System.Windows.Forms.TextBox();
            this.tbassentoeixo = new System.Windows.Forms.TextBox();
            this.mtplaca = new System.Windows.Forms.MaskedTextBox();
            this.btlimpar = new System.Windows.Forms.Button();
            this.btcadastrar = new System.Windows.Forms.Button();
            this.lv1 = new System.Windows.Forms.ListView();
            this.pbimagem = new System.Windows.Forms.PictureBox();
            this.Placa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Ano = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Assentos = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Eixos = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Diaria = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.pbimagem)).BeginInit();
            this.SuspendLayout();
            // 
            // rbcaminhao
            // 
            this.rbcaminhao.AutoSize = true;
            this.rbcaminhao.Location = new System.Drawing.Point(261, 39);
            this.rbcaminhao.Name = "rbcaminhao";
            this.rbcaminhao.Size = new System.Drawing.Size(89, 20);
            this.rbcaminhao.TabIndex = 0;
            this.rbcaminhao.TabStop = true;
            this.rbcaminhao.Text = "Caminhão";
            this.rbcaminhao.UseVisualStyleBackColor = true;
            this.rbcaminhao.CheckedChanged += new System.EventHandler(this.rbcaminhao_CheckedChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // rbOnibus
            // 
            this.rbOnibus.AutoSize = true;
            this.rbOnibus.Location = new System.Drawing.Point(112, 39);
            this.rbOnibus.Name = "rbOnibus";
            this.rbOnibus.Size = new System.Drawing.Size(70, 20);
            this.rbOnibus.TabIndex = 2;
            this.rbOnibus.TabStop = true;
            this.rbOnibus.Text = "Ônibus";
            this.rbOnibus.UseVisualStyleBackColor = true;
            this.rbOnibus.CheckedChanged += new System.EventHandler(this.rbOnibus_CheckedChanged);
            // 
            // lbPlaca
            // 
            this.lbPlaca.AutoSize = true;
            this.lbPlaca.Location = new System.Drawing.Point(167, 101);
            this.lbPlaca.Name = "lbPlaca";
            this.lbPlaca.Size = new System.Drawing.Size(42, 16);
            this.lbPlaca.TabIndex = 3;
            this.lbPlaca.Text = "Placa";
            // 
            // lbAno
            // 
            this.lbAno.AutoSize = true;
            this.lbAno.Location = new System.Drawing.Point(167, 137);
            this.lbAno.Name = "lbAno";
            this.lbAno.Size = new System.Drawing.Size(31, 16);
            this.lbAno.TabIndex = 4;
            this.lbAno.Text = "Ano";
            // 
            // lbaltera
            // 
            this.lbaltera.AutoSize = true;
            this.lbaltera.Location = new System.Drawing.Point(145, 186);
            this.lbaltera.Name = "lbaltera";
            this.lbaltera.Size = new System.Drawing.Size(84, 16);
            this.lbaltera.TabIndex = 5;
            this.lbaltera.Text = "qtd assentos";
            // 
            // tbano
            // 
            this.tbano.Location = new System.Drawing.Point(235, 134);
            this.tbano.Name = "tbano";
            this.tbano.Size = new System.Drawing.Size(100, 22);
            this.tbano.TabIndex = 7;
            // 
            // tbassentoeixo
            // 
            this.tbassentoeixo.Location = new System.Drawing.Point(235, 183);
            this.tbassentoeixo.Name = "tbassentoeixo";
            this.tbassentoeixo.Size = new System.Drawing.Size(100, 22);
            this.tbassentoeixo.TabIndex = 8;
            // 
            // mtplaca
            // 
            this.mtplaca.Location = new System.Drawing.Point(235, 95);
            this.mtplaca.Name = "mtplaca";
            this.mtplaca.Size = new System.Drawing.Size(100, 22);
            this.mtplaca.TabIndex = 9;
            // 
            // btlimpar
            // 
            this.btlimpar.Location = new System.Drawing.Point(434, 258);
            this.btlimpar.Name = "btlimpar";
            this.btlimpar.Size = new System.Drawing.Size(75, 23);
            this.btlimpar.TabIndex = 10;
            this.btlimpar.Text = "limpar";
            this.btlimpar.UseVisualStyleBackColor = true;
            this.btlimpar.Click += new System.EventHandler(this.btlimpar_Click);
            // 
            // btcadastrar
            // 
            this.btcadastrar.Location = new System.Drawing.Point(235, 258);
            this.btcadastrar.Name = "btcadastrar";
            this.btcadastrar.Size = new System.Drawing.Size(75, 23);
            this.btcadastrar.TabIndex = 11;
            this.btcadastrar.Text = "cadastrar";
            this.btcadastrar.UseVisualStyleBackColor = true;
            this.btcadastrar.Click += new System.EventHandler(this.btcadastrar_Click);
            // 
            // lv1
            // 
            this.lv1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Placa,
            this.Ano,
            this.Assentos,
            this.Eixos,
            this.Diaria});
            this.lv1.HideSelection = false;
            this.lv1.Location = new System.Drawing.Point(12, 292);
            this.lv1.Name = "lv1";
            this.lv1.Size = new System.Drawing.Size(695, 133);
            this.lv1.TabIndex = 12;
            this.lv1.UseCompatibleStateImageBehavior = false;
            this.lv1.View = System.Windows.Forms.View.Details;
            // 
            // pbimagem
            // 
            this.pbimagem.Image = global::wfaVeiculo.Properties.Resources.caminhao;
            this.pbimagem.Location = new System.Drawing.Point(515, 95);
            this.pbimagem.Name = "pbimagem";
            this.pbimagem.Size = new System.Drawing.Size(234, 153);
            this.pbimagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbimagem.TabIndex = 13;
            this.pbimagem.TabStop = false;
            // 
            // Placa
            // 
            this.Placa.Text = "Placa";
            this.Placa.Width = 145;
            // 
            // Ano
            // 
            this.Ano.Text = "Ano";
            this.Ano.Width = 100;
            // 
            // Assentos
            // 
            this.Assentos.Text = "Assentos";
            this.Assentos.Width = 100;
            // 
            // Eixos
            // 
            this.Eixos.Text = "Eixos";
            this.Eixos.Width = 100;
            // 
            // Diaria
            // 
            this.Diaria.Text = "Diaria";
            this.Diaria.Width = 165;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pbimagem);
            this.Controls.Add(this.lv1);
            this.Controls.Add(this.btcadastrar);
            this.Controls.Add(this.btlimpar);
            this.Controls.Add(this.mtplaca);
            this.Controls.Add(this.tbassentoeixo);
            this.Controls.Add(this.tbano);
            this.Controls.Add(this.lbaltera);
            this.Controls.Add(this.lbAno);
            this.Controls.Add(this.lbPlaca);
            this.Controls.Add(this.rbOnibus);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.rbcaminhao);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbimagem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbcaminhao;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.RadioButton rbOnibus;
        private System.Windows.Forms.Label lbPlaca;
        private System.Windows.Forms.Label lbAno;
        private System.Windows.Forms.Label lbaltera;
        private System.Windows.Forms.TextBox tbano;
        private System.Windows.Forms.TextBox tbassentoeixo;
        private System.Windows.Forms.MaskedTextBox mtplaca;
        private System.Windows.Forms.Button btlimpar;
        private System.Windows.Forms.Button btcadastrar;
        private System.Windows.Forms.ListView lv1;
        private System.Windows.Forms.PictureBox pbimagem;
        private System.Windows.Forms.ColumnHeader Placa;
        private System.Windows.Forms.ColumnHeader Ano;
        private System.Windows.Forms.ColumnHeader Assentos;
        private System.Windows.Forms.ColumnHeader Eixos;
        private System.Windows.Forms.ColumnHeader Diaria;
    }
}

