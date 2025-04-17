// See https://aka.ms/new-console-template for more information
using carros;

List<Carro> carros = new List<Carro>();
Carro celta = new Carro();
Carro corsa = new Carro();
Carro punto = new Carro();
int carroSelecionado = 0;

celta.cor = "Prata";
corsa.cor = "Vermelho";
punto.cor = "Branco";

celta.nome = "Celta";
corsa.nome = "Corsa";
punto.nome = "Punto";

carros.Add(celta);
carros.Add(corsa);
carros.Add(punto);

Console.WriteLine("Bem vindo(a) sua Garagem!");
Console.WriteLine("Carros disponiveis:");

for(int i = 0; i < 3; i++)
{
    Console.WriteLine($"({i + 1}) {carros[i].nome}");
}

Console.Write("Selecione qual carro deseja: ");
carroSelecionado = Convert.ToInt32(Console.ReadLine());

switch (carroSelecionado)
{
    case 1:
        Console.WriteLine($"Carro selecionado {carros[carroSelecionado].nome}");
        break;
    case 2:
        Console.WriteLine($"Carro selecionado {carros[carroSelecionado].nome}");
        break;
    case 3:
        Console.WriteLine($"Carro selecionado {carros[carroSelecionado].nome}");
        break;
}

Console.WriteLine("O que deseja fazer com seu carro: ");
Console.WriteLine("(1) Pintar Carro\n");

Console.Write("Escolha uma ação: ");
int acaoUsuario = Convert.ToInt32(Console.ReadLine());

switch (acaoUsuario)
{
    case 1:
        Console.WriteLine($"A cor atual do seu carro é: {carros[carroSelecionado].cor}");
        Console.WriteLine("Para qual cor deseja pintar o seu carro: ");
        string corNova = Console.ReadLine();
        carros[carroSelecionado].PintarCarro(corNova);
        if (carros[carroSelecionado].cor == corNova)
            Console.WriteLine("A cor do seu carro foi alterado com sucesso!");
        break;
}