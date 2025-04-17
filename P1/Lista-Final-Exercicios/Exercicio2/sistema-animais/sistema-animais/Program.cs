using sistema_animais.Classes;

Domestico cachorro = new Domestico();

Console.Write("Informe o nome do cachorro: ");
cachorro.nome = Console.ReadLine();

Console.Write("\n\nInforme a cor do cachorro: ");
cachorro.cor = Console.ReadLine();

Console.Write("\n\nInforme a especie do cachorro: ");
cachorro.especie = Console.ReadLine();

Console.Write("\n\nInforme o som que o cachorro faz: ");
cachorro.som = Console.ReadLine();

bool locomocaoCorreta;
//Verifica se o usuario informou uma locomoção valida
do {
    Console.Write("\n\nInforme como o cachorro se locomove (Anda, Voa, Nada): ");
    cachorro.locomocao = Console.ReadLine();
    switch (cachorro.locomocao)
    {
        case "Anda":
            locomocaoCorreta = true;
            break;
        case "Voa":
            locomocaoCorreta = true;
            break;
        case "Nada":
            locomocaoCorreta = true;
            break;
        default:
            Console.Write("Nop");
            locomocaoCorreta = false;
            break;
    }
}while(locomocaoCorreta == false);

Console.Write("\n\nInforme o endereco do cachorro: ");
cachorro.endereco = Console.ReadLine();

Console.WriteLine("Informações do Cachorro:");
Console.WriteLine($"Nome: {cachorro.nome}");
Console.WriteLine($"Cor: {cachorro.cor}");
Console.WriteLine($"Especie: {cachorro.especie}");
Console.WriteLine($"Som: {cachorro.som}");
Console.WriteLine($"Locomoção: {cachorro.locomocao}");
Console.WriteLine($"Endereço: {cachorro.endereco}");
Console.WriteLine($"Ação: {cachorro.MoverAnimal()}");