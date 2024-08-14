namespace Desenho2D
{
    partial class frmDesenhoAvancado
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
            this.pbCaixaDesenho = new System.Windows.Forms.PictureBox();
            this.btnDesenhar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbIdade = new System.Windows.Forms.TextBox();
            this.lbObjetos = new System.Windows.Forms.ListBox();
            this.btnMostrarInfos = new System.Windows.Forms.Button();
            this.ckbxPoligono = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbCaixaDesenho)).BeginInit();
            this.SuspendLayout();
            // 
            // pbCaixaDesenho
            // 
            this.pbCaixaDesenho.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbCaixaDesenho.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pbCaixaDesenho.Location = new System.Drawing.Point(12, 12);
            this.pbCaixaDesenho.Name = "pbCaixaDesenho";
            this.pbCaixaDesenho.Size = new System.Drawing.Size(300, 300);
            this.pbCaixaDesenho.TabIndex = 0;
            this.pbCaixaDesenho.TabStop = false;
            this.pbCaixaDesenho.Paint += new System.Windows.Forms.PaintEventHandler(this.pbCaixaDesenho_Paint);
            // 
            // btnDesenhar
            // 
            this.btnDesenhar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnDesenhar.Location = new System.Drawing.Point(12, 324);
            this.btnDesenhar.Name = "btnDesenhar";
            this.btnDesenhar.Size = new System.Drawing.Size(75, 23);
            this.btnDesenhar.TabIndex = 5;
            this.btnDesenhar.Text = "Desenhar";
            this.btnDesenhar.UseVisualStyleBackColor = true;
            this.btnDesenhar.Click += new System.EventHandler(this.btnDesenhar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnLimpar.Location = new System.Drawing.Point(237, 324);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 6;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // tbNome
            // 
            this.tbNome.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.tbNome.Location = new System.Drawing.Point(371, 25);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(270, 20);
            this.tbNome.TabIndex = 1;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnAdicionar.Location = new System.Drawing.Point(420, 244);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(114, 23);
            this.btnAdicionar.TabIndex = 3;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(327, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nome:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(328, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Idade:";
            // 
            // tbIdade
            // 
            this.tbIdade.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.tbIdade.Location = new System.Drawing.Point(371, 55);
            this.tbIdade.Name = "tbIdade";
            this.tbIdade.Size = new System.Drawing.Size(97, 20);
            this.tbIdade.TabIndex = 2;
            // 
            // lbObjetos
            // 
            this.lbObjetos.FormattingEnabled = true;
            this.lbObjetos.Location = new System.Drawing.Point(330, 121);
            this.lbObjetos.Name = "lbObjetos";
            this.lbObjetos.Size = new System.Drawing.Size(311, 108);
            this.lbObjetos.TabIndex = 9;
            // 
            // btnMostrarInfos
            // 
            this.btnMostrarInfos.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnMostrarInfos.Location = new System.Drawing.Point(420, 273);
            this.btnMostrarInfos.Name = "btnMostrarInfos";
            this.btnMostrarInfos.Size = new System.Drawing.Size(114, 23);
            this.btnMostrarInfos.TabIndex = 4;
            this.btnMostrarInfos.Text = "Mostrar Infos.";
            this.btnMostrarInfos.UseVisualStyleBackColor = true;
            this.btnMostrarInfos.Click += new System.EventHandler(this.btnMostrarInfos_Click);
            // 
            // ckbxPoligono
            // 
            this.ckbxPoligono.AutoSize = true;
            this.ckbxPoligono.Location = new System.Drawing.Point(371, 82);
            this.ckbxPoligono.Name = "ckbxPoligono";
            this.ckbxPoligono.Size = new System.Drawing.Size(69, 17);
            this.ckbxPoligono.TabIndex = 10;
            this.ckbxPoligono.Text = "Polígono";
            this.ckbxPoligono.UseVisualStyleBackColor = true;
            // 
            // frmDesenhoAvancado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 359);
            this.Controls.Add(this.ckbxPoligono);
            this.Controls.Add(this.btnMostrarInfos);
            this.Controls.Add(this.lbObjetos);
            this.Controls.Add(this.tbIdade);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.tbNome);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnDesenhar);
            this.Controls.Add(this.pbCaixaDesenho);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmDesenhoAvancado";
            this.Text = "Desenho 2D";
            ((System.ComponentModel.ISupportInitialize)(this.pbCaixaDesenho)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbCaixaDesenho;
        private System.Windows.Forms.Button btnDesenhar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbIdade;
        public System.Windows.Forms.ListBox lbObjetos;
        private System.Windows.Forms.Button btnMostrarInfos;
        private System.Windows.Forms.CheckBox ckbxPoligono;
    }
}

