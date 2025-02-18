// See https://aka.ms/new-console-template for more information
using System.Collections.Generic;

List<string> animais = new List<string>();

int acaoUsuario = 0;

void ImprimirAnimais(List<string> animaisCadastrados)
{
    Console.WriteLine("\n\nLista de animais Cadastrados:\n");

    if (animaisCadastrados.Count == 0)
        Console.WriteLine("\nNenhum animal foi cadastrado!\n\n");
    else
    {
        foreach(string animais in animaisCadastrados)
        {
            Console.WriteLine($"{animais}\n");
        }
    }
}

void CadastrarAnimal(List<string> animaisCadastrados)
{
    Console.Write("\nInforme o nome do animal: ");
    string nomeAnimalRecebido = Console.ReadLine();
    if (animaisCadastrados.Contains(nomeAnimalRecebido) == true)
    {
        Console.WriteLine($"\nO animal {nomeAnimalRecebido} já foi cadastrado no sistema.");
    }
    else
    {
        animaisCadastrados.Add(nomeAnimalRecebido);
        Console.WriteLine($"\nO animal {nomeAnimalRecebido} foi cadastrado com sucesso!");
    }
}

do
{
    Console.WriteLine("\nDeseja Cadastrar um animal? \n\n(1) Sim \n(2) Ver animais cadastrados \n(0) Não");
    Console.Write("\nInforme a ação: ");
    acaoUsuario = Convert.ToInt32(Console.ReadLine());
    switch (acaoUsuario)
    {
        case 1:
            CadastrarAnimal(animais);    
            break;
        case 2:
            ImprimirAnimais(animais);
            break;

    }
}while (acaoUsuario != 0);

