using Microsoft.VisualBasic;
using sistema_escolar.Classes;

Escola senac = new Escola();

//Variaveis e constantes
int acaoUsuario = 0;
string nomeNovoAluno = "";
string cpfNovoAluno = "";

Console.WriteLine("Bem vindo(a) ao Sistema Escolar\n");
Console.WriteLine("O que gostaria de fazer hoje?");
Console.WriteLine("(1) Cadastrar Aluno");
Console.WriteLine("(0) Sair!");

int acaoRecebida = Convert.ToInt32(Console.ReadLine());
if (acaoRecebida != null)
    acaoUsuario = acaoRecebida;

switch (acaoUsuario)
{
    case 0:
        Console.WriteLine("Obrigado por utilizar nosso sistema!");
        break;
    case 1:
        Console.WriteLine("\n\nInformações do Aluno:");
        Console.WriteLine("Nome: ");

        senac.CadastrarAluno(nomeNovoAluno, cpfNovoAluno);
        break;
}


