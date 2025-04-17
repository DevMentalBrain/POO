
using sistema_bibliotecario.Classes;

//Constantes de Variaveies
bool userOnline = true;
Biblioteca biblioteca;
int usuarioOuAdm;

Dictionary<int, Livro> catalogoLivros = new Dictionary<int, Livro>();

biblioteca = new Biblioteca(catalogoLivros);

Console.WriteLine("Bem vindo(a) a Biblioteca!");
Console.WriteLine("Como deseja entrar: ");
Console.WriteLine("(1)Usuario \n(2)ADM");
usuarioOuAdm = Convert.ToInt32(Console.ReadLine());
switch (usuarioOuAdm)
{
    //Usuario
    case 1:
        //Cadastro do usuario
        Console.WriteLine("Bem vindo(a) ao cadastro na biblioteca!");
        Console.Write("Informe seu nome: ");
        string nomeUsuario = Console.ReadLine();
        Pessoa novoUsuario = new Pessoa(nomeUsuario);
        novoUsuario.livrosAlugados = new Dictionary<int, LivroAlugado>();

        //Sistema é executado ate usuario fechar
        do
        {
            Console.WriteLine($"\nOlá {nomeUsuario}, o que gostaria de fazer hoje?");
            Console.WriteLine("(0)Fechar \n(1)Ver Meus Livros Alugados \n(2)Alugar um livro");
            Console.Write("Selecione uma opcao: ");
            int acaoUsuario = Convert.ToInt32(Console.ReadLine());

            switch (acaoUsuario)
            {
                case 0:
                    userOnline = false;
                    Console.WriteLine("Obrigado por utilizar nosso sistema, até a proxima!");
                    return;
                case 1:
                    Dictionary<int, LivroAlugado> livrosAlugadosUsuario = novoUsuario.VerLivrosAlugados();
                    if (livrosAlugadosUsuario.Count > 0)
                    {
                        for (int i = 0; i < livrosAlugadosUsuario.Count; i++)
                        {
                            Console.WriteLine(livrosAlugadosUsuario[i].titulo);
                        }
                    }
                    else
                    {
                        Console.WriteLine("\nParece que você não alugou nenhum livro ainda.");
                    }
                    break;
                case 2:
                    Console.Write("\nQual o nome do livro deseja alugar: ");
                    string nomeLivroRecebido = Console.ReadLine();
                    string respostaLivroAlugado = biblioteca.AlugarLivro(novoUsuario, nomeLivroRecebido, novoUsuario.livrosAlugados);
                    Console.WriteLine($"\n{respostaLivroAlugado}");
                    break;
                default:
                    Console.WriteLine("Por favor, selecione uma opção válida!");
                    break;
            }
        } while (userOnline == true);
        break;
    //ADM
    case 2:
        break;
    default:
        Console.WriteLine("Opção inválida, programa encerrado!");
        return;
}

