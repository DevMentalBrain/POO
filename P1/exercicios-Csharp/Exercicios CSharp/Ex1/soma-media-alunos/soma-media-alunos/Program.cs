// See https://aka.ms/new-console-template for more information

//Constantes e Variaveis
string numeroRecebido;
bool verificarNumero = false;
double qtdNumerosUsuario;

Console.WriteLine("Bem vindo(a) ao programa de Somar e Informar a média de numeros!\n\n");

double verificarNumeroValido(string numero, double destino) {
    verificarNumero = double.TryParse(numero, out destino);
    if (verificarNumero == true){
        destino = Convert.ToDouble(numero);
        return destino;
    }
}
do{
    Console.WriteLine("Quantos numeros deseja informar (Minimo 3 e Máximo 10): ");
    numeroRecebido = Console.ReadLine();
    verificarNumero = double.TryParse(numeroRecebido, out qtdNumerosUsuario);
    if(verificarNumero == true && (Convert.ToDouble(numeroRecebido) >= 3 && Convert.ToDouble(numeroRecebido) <= 10))
        qtdNumerosUsuario = Convert.ToDouble(numeroRecebido);
}while(verificarNumero == false);

