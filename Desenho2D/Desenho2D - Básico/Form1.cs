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
        public frmDesenho()
        {
            InitializeComponent();
        }

        private void btnDesenhar_Click(object sender, EventArgs e)
        {
            Graphics g = pbCaixaDesenho.CreateGraphics();
            Pen caneta = new Pen(Color.Green, 5);
            
            g.DrawLine(caneta,
                new Point(0, 0),
                new Point(100, 100)
            );
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Graphics g = pbCaixaDesenho.CreateGraphics();
            g.Clear(SystemColors.ActiveCaption);
        }
    }
}