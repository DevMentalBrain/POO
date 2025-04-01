using partida_volei.Classes;

Random random = new Random();

Console.WriteLine("Bem vindo(a) ao simulador de Partidas de Volei!");

Console.Write("Informe o nome da Partida: ");
string nomePartida = Console.ReadLine();

//Instancia time de casa
Console.Write("Informe o nome Time da casa: ");
string nomeTimeCasa = Console.ReadLine();
Dictionary<int, Jogador> listaDeJogadoresCasa = new Dictionary<int, Jogador>();
Time timeDaCasa = new Time(nomeTimeCasa , listaDeJogadoresCasa);

//Instancia time de fora
Console.Write("Informe o nome Time da fora: ");
string nomeTimeFora = Console.ReadLine();
Dictionary<int, Jogador> listaDeJogadoresFora = new Dictionary<int, Jogador>();
Time timeDeFora = new Time(nomeTimeCasa, listaDeJogadoresFora);

//Instancia a partida
Partida novaPartida = new Partida(timeDaCasa, timeDeFora);

//Adiciona os jogadores do time de Casa
for(int i = 0;i < 6; i++)
{
    Console.WriteLine("Informe os jogadores do time da casa!");
    Console.Write($"Informe o nome do {i + 1} Jogador: ");
    string nomeJogador = Console.ReadLine();
    Console.Write($"Informe o numero da camisa do {nomeJogador}: ");
    int numeroDaCamisa = Convert.ToInt32(Console.ReadLine());
    Console.Write($"Informe a altura do {nomeJogador}: ");
    double alturaJogador = Convert.ToDouble(Console.ReadLine());

    Jogador novoJogador = new Jogador(nomeJogador, numeroDaCamisa, alturaJogador);
    timeDaCasa.AdicionarJogador(novoJogador);
}

//Adiciona os jogadores do time de Fora
for (int i = 0; i < 6; i++)
{
    Console.WriteLine("Informe os jogadores do time da fora!");
    Console.Write($"Informe o nome do {i + 1} Jogador: ");
    string nomeJogador = Console.ReadLine();
    Console.Write($"Informe o numero da camisa do {nomeJogador}: ");
    int numeroDaCamisa = Convert.ToInt32(Console.ReadLine());
    Console.Write($"Informe a altura do {nomeJogador}: ");
    double alturaJogador = Convert.ToDouble(Console.ReadLine());

    Jogador novoJogador = new Jogador(nomeJogador, numeroDaCamisa, alturaJogador);
    timeDeFora.AdicionarJogador(novoJogador);
}

novaPartida.IniciarPartida();

//Partida em andamento
do
{
    //Sorteia de quem e a vez do turno
    int moeda = random.Next(1, 3);
    switch (moeda)
    {
        case 1:
            timeDaCasa.AlterarVez(true);
            
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Vez do time {timeDaCasa.nome}");
                Console.WriteLine($"\nQual jogador quer usar: ");
                string nomeDoJogador = Console.ReadLine();

                if (timeDaCasa.VerificarJogador(nomeDoJogador))
                {
                    Console.WriteLine($"(1)Sacar (2)Levantar (3)Atacar");
                    Console.Write($"Informe o que deseja fazer: ");
                }
                

            }

            break;
        case 2:
            timeDeFora.AlterarVez(true);
            break;
    }

} while (timeDaCasa.pontos < 25 && timeDeFora.pontos < 25);