// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!"); //Printa texto e pula linha
Console.Write("Hello, World!"); //Printa texto e NÂO pula linha

//Tipos de Variaveis
int numero = 10; //Tipo Inteiro. ( 4 Bytes = 32 bits )

string nome = "Cauã"; //Tipo String ( Texto ). ( 1 Byte por caractere )

double peso = 78.95; //Tipo decimal. ( 8 Bytes = 64 Bits )

bool ativo = true; //Tipo boleano. ( 1 Bit )

//Concatenação
string nome2 = "Cauã";
string sobrenome = "Mendes";

//Através do operador ( + )
Console.WriteLine(nome + " " + sobrenome);

//Através do indice ( chaves ) { } Onde o indice inicia em 0 após a string
Console.WriteLine("Meu nome completo é: {0} {1}", nome, sobrenome);
