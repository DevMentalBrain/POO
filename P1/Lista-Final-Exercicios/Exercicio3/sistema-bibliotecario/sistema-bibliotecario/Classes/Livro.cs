using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistema_bibliotecario.Classes
{
    internal class Livro
    {
        public string titulo { get; set; }
        public double valorMulta { get; set; }
        public int qtdExemplaresTotal { get; set; }
        public int qtdExemplaresDisponiveis{ get; set; }
        public string tipoLivro{ get; set; }

        //Construtor para obrigar o usuario a enviar as informações ao instanciar um novo Livro
        public Livro(string titulo, double valorMulta, int qtdExemplaresTotal,int qtdExemplaresDisponiveis, string tipoLivro)
        {
            this.titulo = titulo;
            this.valorMulta = valorMulta;
            this.qtdExemplaresTotal = qtdExemplaresTotal;
            this.qtdExemplaresDisponiveis = qtdExemplaresDisponiveis;
            this.tipoLivro = tipoLivro;
        }
    }
}
