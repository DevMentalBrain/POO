using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistema_bibliotecario.Classes
{
    internal class LivroAlugado : Livro
    {
        public DateTime dataAluguel { get; set; }
        public DateTime prazoDevolucao { get; set; }

        public LivroAlugado(string titulo, double valorMulta, int qtdExemplaresTotal, int qtdExemplaresDisponiveis, string tipoLivro, DateTime dataAluguel) 
            : base(titulo, valorMulta, qtdExemplaresTotal, qtdExemplaresDisponiveis, tipoLivro)
        { 
            this.dataAluguel = dataAluguel;
        }
    }
}
