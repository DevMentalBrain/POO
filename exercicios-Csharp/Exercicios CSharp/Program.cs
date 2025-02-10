// See https://aka.ms/new-console-template for more information

/*
    Objetivo: usando uma aplicação do tipo console do dotnet, criar uma calculadora simples
que terá as operações de soma, subtração, multiplicação e divisão. Faça o controle de
versionamento da sua aplicação com git e suba a mesma para o github.

 */

//Variaveis e Constantes
double opcaoUsuario = 0;
double numero1Usuario = 0;
double numero2Usuario = 0;
bool verificarNumero = false;
string numeroRecebido;

double somar(double numero1 ,double numero2 ){
    return numero1 + numero2;
}

double subtrair(double numero1, double numero2){
    return numero1 - numero2; 
}

double multiplicar(double multiplicando, double multiplicador){
    return multiplicando * multiplicador;
}

double dividir(double dividendo,double divisor){
    return dividendo / divisor;
}

void solicitarNumero(){
    for(int i = 0; i < 2; i++){
        Console.Write($"\nInforme o {i + 1} numero:");
        if(i == 0){
            do
            {
                numeroRecebido = Console.ReadLine();
                verificarNumero = double.TryParse(numeroRecebido, out numero1Usuario);
                if (verificarNumero == true)
                    numero1Usuario = Convert.ToDouble(numeroRecebido);
                else
                    Console.Write("\nInforme um numero válido:");
            } while (verificarNumero == false);
        }
        else{
            do
            {
                numeroRecebido = Console.ReadLine();
                verificarNumero = double.TryParse(numeroRecebido, out numero2Usuario);
                if (verificarNumero == true)
                    numero2Usuario = Convert.ToDouble(numeroRecebido);
                else
                    Console.Write("\nInforme um numero válido:");
            } while (verificarNumero == false);
        }
    }

    /*do {
        Console.Write($"Informe o {numberUser} numero:");
        numeroRecebido = Console.ReadLine();
        verificarNumero = double.TryParse(numeroRecebido, out numero1Usuario);
        numero1Usuario = Convert.ToDouble(numero1Recebido);
    } while(verificarNumero == false);*/
}

//Menu
Console.WriteLine("Calculadora em C#!\n\n");
Console.WriteLine("Selecione a opção desejada:\n");
Console.WriteLine("(1) Somar (2) Subtrair (3) Multiplicar (4) Dividir (0) Sair\n");
Console.Write("Opção: ");
opcaoUsuario = Convert.ToDouble(Console.ReadLine());

//Resolução
switch (opcaoUsuario){
    case 0:
        Console.WriteLine("Programa encerrado, até uma proxima!");
        break;
    case 1:
        solicitarNumero();
        Console.WriteLine($"\nA soma de {numero1Usuario} + {numero2Usuario} = {somar(numero1Usuario, numero2Usuario)}");
        break;
    case 2:
        solicitarNumero();
        Console.WriteLine($"\nA subtracao de {numero1Usuario} - {numero2Usuario} = {subtrair(numero1Usuario, numero2Usuario)}");
        break;
    case 3:
        solicitarNumero();
        Console.WriteLine($"\nA multiplicacao de {numero1Usuario} + {numero2Usuario} = {multiplicar(numero1Usuario, numero2Usuario)}");
        break;
    case 4:
        solicitarNumero();
        Console.WriteLine($"\nA dividir de {numero1Usuario} + {numero2Usuario} = {dividir(numero1Usuario, numero2Usuario)}");
        break;
}