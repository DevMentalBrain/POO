using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistema_bibliotecario.Classes
{
    internal class Biblioteca
    {
        Dictionary<int, Livro> catalogoLivros = new Dictionary<int, Livro>();

        public Biblioteca(Dictionary<int, Livro> catalogoLivros) {
            this.catalogoLivros = catalogoLivros;
        }

        public string AlugarLivro(string nomePessoa, string nomeLivro, Dictionary<int, LivroAlugado> livrosAlugados) {
            
            Dictionary<int, LivroAlugado> livrosAlugadosRecebidos = livrosAlugados;

            //Percorre o catalogo procurando o livro passado pelo usuario
            for (int i = 0; i < catalogoLivros.Count; i++) {
                if (catalogoLivros[i].titulo == nomeLivro) {
                    if (catalogoLivros[i].qtdExemplaresDisponiveis == 0)
                    {
                        return "Erro: Esse livro não possui exemplares disponiveis!";
                    }
                    //Informações do livro alugado
                    DateTime dataDoAluguel = DateTime.Now;
                    string nomeLivroAlugado = catalogoLivros[i].titulo;
                    double valorMultaLivroAlugado = catalogoLivros[i].valorMulta;
                    int qtdExemplaresTotal = catalogoLivros[i].qtdExemplaresTotal;
                    int qtdExemplaresDisponivel = catalogoLivros[i].qtdExemplaresDisponiveis;
                    string tipoLivro = catalogoLivros[i].tipoLivro;

                    LivroAlugado novoLivroAlugado = new LivroAlugado(nomeLivroAlugado, valorMultaLivroAlugado, qtdExemplaresTotal, qtdExemplaresDisponivel, tipoLivro, dataDoAluguel);
                   
                }
            }
        }
    }
}
