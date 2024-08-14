using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;

namespace Desenho2D_Básico
{
    internal class Pessoa
    {
        public string Nome { get; }
        public int Idade { get; }

        public Pessoa(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }

        public override string ToString()
        {
            return "Pessoa [nome=" + Nome + ", idade=" + Idade + "]";
        }
    }
}
