// See https://aka.ms/new-console-template for more information

using _1000_carros;
Random random = new Random();
int[] qtdCarrosPorCor = new int[3];

List<Carro> listCar = new List<Carro>();

for (int i = 0; i < 1000; i++)
{
    listCar.Add(new Carro());
}

for (int i = 0; i < 1000; i++)
{
    int numeroSorteado = random.Next(1, 4);
    switch (numeroSorteado)
    {
        case 1:
            listCar[i].cor = "Azul";
            qtdCarrosPorCor[numeroSorteado - 1]++;
            break;
        case 2:
            listCar[i].cor = "Vermelho";
            qtdCarrosPorCor[numeroSorteado - 1]++;
            break;
        case 3:
            listCar[i].cor = "Verde";
            qtdCarrosPorCor[numeroSorteado - 1]++;
            break;
    }
}

for (int i = 0; i < qtdCarrosPorCor.Length; i++)
{
    switch (i)
    {
        case 0:
            Console.WriteLine($"A quantidade de carros na cor Azul é: {qtdCarrosPorCor[i]}");
            break;
        case 1:
            Console.WriteLine($"A quantidade de carros na cor Vermelho é: {qtdCarrosPorCor[i]}");
            break;
        case 2:
            Console.WriteLine($"A quantidade de carros na cor Verde é: {qtdCarrosPorCor[i]}");
            break;
    }
}