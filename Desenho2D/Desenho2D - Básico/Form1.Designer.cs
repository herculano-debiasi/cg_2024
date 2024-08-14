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
            this.btnLimpar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbCaixaDesenho)).BeginInit();
            this.SuspendLayout();
            // 
            // pbCaixaDesenho
            // 
            this.pbCaixaDesenho.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbCaixaDesenho.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pbCaixaDesenho.Location = new System.Drawing.Point(12, 12);
            this.pbCaixaDesenho.MaximumSize = new System.Drawing.Size(300, 300);
            this.pbCaixaDesenho.MinimumSize = new System.Drawing.Size(300, 300);
            this.pbCaixaDesenho.Name = "pbCaixaDesenho";
            this.pbCaixaDesenho.Size = new System.Drawing.Size(300, 300);
            this.pbCaixaDesenho.TabIndex = 0;
            this.pbCaixaDesenho.TabStop = false;
            // 
            // btnDesenhar
            // 
            this.btnDesenhar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDesenhar.Location = new System.Drawing.Point(12, 321);
            this.btnDesenhar.Name = "btnDesenhar";
            this.btnDesenhar.Size = new System.Drawing.Size(75, 23);
            this.btnDesenhar.TabIndex = 1;
            this.btnDesenhar.Text = "Desenhar";
            this.btnDesenhar.UseVisualStyleBackColor = true;
            this.btnDesenhar.Click += new System.EventHandler(this.btnDesenhar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLimpar.Location = new System.Drawing.Point(237, 321);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 3;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // frmDesenho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 351);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnDesenhar);
            this.Controls.Add(this.pbCaixaDesenho);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmDesenho";
            this.Text = "Desenho 2D - Básico";
            ((System.ComponentModel.ISupportInitialize)(this.pbCaixaDesenho)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbCaixaDesenho;
        private System.Windows.Forms.Button btnDesenhar;
        private System.Windows.Forms.Button btnLimpar;
    }
}

