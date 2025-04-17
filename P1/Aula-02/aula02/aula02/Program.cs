// See https://aka.ms/new-console-template for more information
using System.Security.Principal;

Random dado = new Random();

Console.WriteLine("Programa dos Dados!");
Console.Write("\nInforme quantas jogadas deseja: ");

string numeroDeJogadas = Console.ReadLine();
int jogadas = Convert.ToInt32(numeroDeJogadas);
int valorDado;
int[] qtdValorDado = new int[6];

for(int i = 0; i < jogadas; i++){
    valorDado = dado.Next(1, 7);
    qtdValorDado[valorDado - 1] += 1;
}

for(int i = 0; i < qtdValorDado.Length ; i++)
{
    Console.WriteLine($"Numero {i} = {qtdValorDado[i]}");
}