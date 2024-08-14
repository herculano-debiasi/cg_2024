using Desenho2D_Básico;
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
    public partial class frmDesenhoAvancado : Form
    {
        enum Acoes
        {
            DESENHAR,
            LIMPAR
        }
        private Acoes acao = Acoes.LIMPAR;

        private int count = 1;
        public frmDesenhoAvancado()
        {
            InitializeComponent();
        }

        private void pbCaixaDesenho_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen caneta = new Pen(Color.Red, 5);

            if (acao == Acoes.DESENHAR)
            {
                g.DrawLine(caneta,
                    new Point((int)0, (int)0),
                    new Point((int)100, (int)100)
                );
            } 
            else if (acao == Acoes.LIMPAR)
            {
                g.Clear(SystemColors.ActiveCaption);
            }

            // Desenha uma borda
            g.DrawRectangle(caneta, 0, 0,
                        pbCaixaDesenho.Width - 1,
                        pbCaixaDesenho.Height - 1);

            System.Diagnostics.Debug.WriteLine(count++);
        }

        private void btnDesenhar_Click(object sender, EventArgs e)
        {
            acao = Acoes.DESENHAR;
            pbCaixaDesenho.Invalidate();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            acao = Acoes.LIMPAR;
            pbCaixaDesenho.Invalidate();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            Pessoa p = new Pessoa(tbNome.Text,
                                  Int32.Parse(tbIdade.Text));
            lbObjetos.Items.Add(p);

            tbNome.Text = "";
            tbIdade.Text = "";
        }

        private void btnMostrarInfos_Click(object sender, EventArgs e)
        {
            int posicao = lbObjetos.SelectedIndex;
            if (posicao != -1)
            {
                Pessoa p = (Pessoa)lbObjetos.SelectedItem;
                MessageBox.Show(p.Nome + " - " +
                                p.Idade + "\n" +
                                "Caixa polígono está " + (ckbxPoligono.Checked ? "marcada" : "desmarcada") + "\n" +
                                "Número de itens na caixa: " + lbObjetos.Items.Count + "\n" +
                                "Índice selecionado: " + posicao);
            }
            else
            {
                //JOptionPane.showMessageDialog(null, "Nenhum item selecionado!");
            }
        }
    }
}