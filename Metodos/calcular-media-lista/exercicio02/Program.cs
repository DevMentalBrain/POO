// See https://aka.ms/new-console-template for more information
using System.Collections.Generic;

List<double> notas = new List<double>();
double mediaAluno = 0;

//Solicita e verifica se informou nota valida
double solicitarNota(string aluno, int numeroNota)
{
    bool verificarNota = false;
    double notaAluno = 0;
    string notaTeste = "";
    do
    {
        Console.Write($"Informe a {numeroNota + 1} nota do aluno {aluno}: ");
        notaTeste = Console.ReadLine();
        if (double.TryParse(notaTeste, out notaAluno) == false)
            notaAluno = Convert.ToDouble(notaTeste);
        return notaAluno;
    } while (double.TryParse(notaTeste, out notaAluno) == false);
}

Console.WriteLine("Bem vindo(a)!\nInforme 5 notas e iremos exibir sua média!");
Console.Write("\nInforme seu nome: ");
string nomeAluno = Console.ReadLine();

//Solicitar notas ( Entrada de Dados )
for (int i = 0; i < 5 ; i++)
{
    notas.Add(solicitarNota(nomeAluno, i));
}

//Printar notas ( Saida de Dados )
for (int i = 0; i < 5 ; i++)
{
    Console.WriteLine($"[{i + 1}]{notas[i]}");
}

//Somar notas do aluno
foreach (int nota in notas)
{
    mediaAluno += nota;
}

Console.WriteLine($"Sua média é: {mediaAluno / 5}");

