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
        public string CadastrarNovoLivro(Livro novoLivroRecebido) {
            
            //Verifica se tem o livro no catalogo
            for (int i = 0; i < catalogoLivros.Count; i++) {
                if (catalogoLivros[i] == novoLivroRecebido) {
                    return "Esse livro já foi cadastrado!";
                }
            }

            //Caso não tenha adiciona ele com o id da ultima posição
            catalogoLivros.Add((catalogoLivros.Count + 1),novoLivroRecebido);
            return $"Livro {novoLivroRecebido.titulo} cadastrado com sucesso! id: {catalogoLivros.Count + 1}";
        }

        public string AlugarLivro(Pessoa pessoaRecebida, string nomeLivro, Dictionary<int, LivroAlugado> livrosAlugados) {
            
            //Cria uma copia de livros alugados que será retornada
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
                    DateTime prazoDevolucao = dataDoAluguel.AddDays(15);
                    string nomeLivroAlugado = catalogoLivros[i].titulo;
                    double valorMultaLivroAlugado = catalogoLivros[i].valorMulta;
                    int qtdExemplaresTotal = catalogoLivros[i].qtdExemplaresTotal;
                    int qtdExemplaresDisponivel = catalogoLivros[i].qtdExemplaresDisponiveis;
                    string tipoLivro = catalogoLivros[i].tipoLivro;
                    LivroAlugado novoLivroAlugado = new LivroAlugado(nomeLivroAlugado, valorMultaLivroAlugado, qtdExemplaresTotal, qtdExemplaresDisponivel, tipoLivro, dataDoAluguel, prazoDevolucao);

                    //Adiciona o livro alugado no dictionary
                    livrosAlugadosRecebidos.Add(i, novoLivroAlugado);
                    if (livrosAlugados.ContainsKey(i))
                    {
                        pessoaRecebida.livrosAlugados = livrosAlugadosRecebidos;
                        return $"Parabéns {pessoaRecebida.nome} alugou o livro {catalogoLivros[i].titulo} com sucesso!";
                    }
                }
            }
            //Caso não encontre o livro
            return "Não temos esse livro em nossa biblioteca!";
        }

    }
}
