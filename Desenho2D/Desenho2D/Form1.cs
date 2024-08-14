using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Desenho2D
{
    public partial class frmDesenho : Form
    {
        enum Acoes
        {
            DESENHAR,
            LIMPAR
        }
        private Acoes acao = Acoes.LIMPAR;

        private int count = 1;
        public frmDesenho()
        {
            InitializeComponent();
        }

        private void pbCaixaDesenho_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen myPen = new Pen(Color.Red, 5);

            // Apaga o desenho anterior
            //pbCaixaDesenho.Image = null;

            g.DrawRectangle(myPen, 0, 0,
                        pbCaixaDesenho.Width - 1,
                        pbCaixaDesenho.Height - 1);

            System.Diagnostics.Debug.WriteLine(count++);
        }

        private void btnDesenhar_Click(object sender, EventArgs e)
        {
            Graphics g = pbCaixaDesenho.CreateGraphics();
            Pen caneta = new Pen(Color.Green, 5);
            
            g.DrawLine(caneta,
                new Point((int)0, (int)0),
                new Point((int)100, (int)100)
            );
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Graphics g = pbCaixaDesenho.CreateGraphics();
            Pen caneta = new Pen(Color.Green, 5);

            g.Clear(SystemColors.ActiveCaption);
        }
    }
}