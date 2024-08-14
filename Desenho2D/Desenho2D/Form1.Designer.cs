namespace Desenho2D
{
    partial class frmDesenho
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.tbEscrever = new System.Windows.Forms.TextBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbDisplayList = new System.Windows.Forms.ListBox();
            this.btnMostrarInfos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbCaixaDesenho)).BeginInit();
            this.SuspendLayout();
            // 
            // pbCaixaDesenho
            // 
            this.pbCaixaDesenho.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbCaixaDesenho.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pbCaixaDesenho.Location = new System.Drawing.Point(12, 34);
            this.pbCaixaDesenho.MaximumSize = new System.Drawing.Size(285, 250);
            this.pbCaixaDesenho.MinimumSize = new System.Drawing.Size(285, 250);
            this.pbCaixaDesenho.Name = "pbCaixaDesenho";
            this.pbCaixaDesenho.Size = new System.Drawing.Size(285, 250);
            this.pbCaixaDesenho.TabIndex = 0;
            this.pbCaixaDesenho.TabStop = false;
            this.pbCaixaDesenho.Paint += new System.Windows.Forms.PaintEventHandler(this.pbCaixaDesenho_Paint);
            // 
            // btnDesenhar
            // 
            this.btnDesenhar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnDesenhar.Location = new System.Drawing.Point(12, 290);
            this.btnDesenhar.Name = "btnDesenhar";
            this.btnDesenhar.Size = new System.Drawing.Size(75, 23);
            this.btnDesenhar.TabIndex = 1;
            this.btnDesenhar.Text = "Desenhar";
            this.btnDesenhar.UseVisualStyleBackColor = true;
            this.btnDesenhar.Click += new System.EventHandler(this.btnDesenhar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(12, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "PictureBox";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnLimpar.Location = new System.Drawing.Point(222, 290);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 3;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // tbEscrever
            // 
            this.tbEscrever.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.tbEscrever.Location = new System.Drawing.Point(355, 38);
            this.tbEscrever.Name = "tbEscrever";
            this.tbEscrever.Size = new System.Drawing.Size(270, 20);
            this.tbEscrever.TabIndex = 4;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnAdicionar.Location = new System.Drawing.Point(403, 243);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(114, 23);
            this.btnAdicionar.TabIndex = 5;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(311, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nome:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(311, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Idade:";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.textBox1.Location = new System.Drawing.Point(355, 64);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(188, 20);
            this.textBox1.TabIndex = 8;
            // 
            // lbDisplayList
            // 
            this.lbDisplayList.FormattingEnabled = true;
            this.lbDisplayList.Location = new System.Drawing.Point(314, 103);
            this.lbDisplayList.Name = "lbDisplayList";
            this.lbDisplayList.Size = new System.Drawing.Size(311, 134);
            this.lbDisplayList.TabIndex = 9;
            // 
            // btnMostrarInfos
            // 
            this.btnMostrarInfos.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnMostrarInfos.Location = new System.Drawing.Point(403, 272);
            this.btnMostrarInfos.Name = "btnMostrarInfos";
            this.btnMostrarInfos.Size = new System.Drawing.Size(114, 23);
            this.btnMostrarInfos.TabIndex = 10;
            this.btnMostrarInfos.Text = "Mostrar Infos.";
            this.btnMostrarInfos.UseVisualStyleBackColor = true;
            // 
            // frmDesenho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 328);
            this.Controls.Add(this.btnMostrarInfos);
            this.Controls.Add(this.lbDisplayList);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.tbEscrever);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDesenhar);
            this.Controls.Add(this.pbCaixaDesenho);
            this.Name = "frmDesenho";
            this.Text = "Desenho 2D";
            ((System.ComponentModel.ISupportInitialize)(this.pbCaixaDesenho)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbCaixaDesenho;
        private System.Windows.Forms.Button btnDesenhar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.TextBox tbEscrever;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.ListBox lbDisplayList;
        private System.Windows.Forms.Button btnMostrarInfos;
    }
}

