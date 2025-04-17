using Exercicio1.Classes;

List<Animal> animaisRecebidos = new List<Animal>();

Console.Write("Informe o nome do cachorro:");
string nomeCachorro = Console.ReadLine();
Console.Write("Informe a idade do cachorro:");
int idadeCachorro = Convert.ToInt32(Console.ReadLine());
Cachorro novoCachorro = new Cachorro(nomeCachorro, idadeCachorro);
animaisRecebidos.Add(novoCachorro);

Console.Write("Informe o nome do gato:");
string nomeGato = Console.ReadLine();
Console.Write("Informe a idade do gato:");
int idadeGato = Convert.ToInt32(Console.ReadLine());
Gato novoGato = new Gato(nomeGato, idadeGato);
animaisRecebidos.Add(novoGato);

Console.Write("Informe o nome do peixe:");
string nomePeixe = Console.ReadLine();
Console.Write("Informe a idade do peixe:");
int idadePeixe = Convert.ToInt32(Console.ReadLine());
Peixe novoPeixe = new Peixe(nomePeixe, idadePeixe);
animaisRecebidos.Add(novoPeixe);

Console.Write("Informe o nome do passaro:");
string nomePassaro = Console.ReadLine();
Console.Write("Informe a idade do passaro:");
int idadePassaro = Convert.ToInt32(Console.ReadLine());
Passaro novoPassaro = new Passaro(nomePassaro, idadePassaro);
animaisRecebidos.Add(novoPassaro);

AnimaisCadastrados animaisCadastrados = new AnimaisCadastrados(animaisRecebidos);

foreach (Animal animal in animaisCadastrados.ListarAnimaisCadastrados())
{
    animal.EmitirSom();
}