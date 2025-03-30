using Calculo_de_Area.Classes;

//Constantes e Variaveis
CalculadoraGeometrica calculadoraGeometrica = new CalculadoraGeometrica();
int opcaoUsuario = 0;

Console.WriteLine("Bem vindo(a) ao programa Calculadora Geometrica!");
Console.WriteLine("\n(1)Área Triangulo \n(2)Área Circulo \n(3)Área Quadrado \n(0)Encerrar\n");
Console.Write("Selecione uma opção: ");
opcaoUsuario = Convert.ToInt32(Console.ReadLine());

switch (opcaoUsuario)
{
    case 0:
        return;
    case 1: //Triangulo
        double alturaTrianguloRecebida;
        double baseTrianguloRecebida;

        Console.Write("\nInforme a altura do triangulo: ");
        alturaTrianguloRecebida = Convert.ToDouble(Console.ReadLine());
        Console.Write("\nInforme a base do triangulo: ");
        baseTrianguloRecebida = Convert.ToDouble(Console.ReadLine());

        Triangulo novoTrianguloUsuario = new Triangulo(baseTrianguloRecebida, alturaTrianguloRecebida);

        double areaTrianguloCalculada = calculadoraGeometrica.CalcularAreaTriangulo(baseTrianguloRecebida, alturaTrianguloRecebida);

        Console.WriteLine($"A área do triangulo é: {areaTrianguloCalculada}");
        break;
    case 2: // Circulo
        double raioCirculoRecebido;

        Console.Write("\nInforme o raio do circulo: ");
        raioCirculoRecebido = Convert.ToDouble(Console.ReadLine());

        Circulo novoCirculoUsuario = new Circulo(raioCirculoRecebido);

        double areaCirculoCalculada = calculadoraGeometrica.CalcularAreaCirculo(raioCirculoRecebido);
        
        Console.WriteLine($"A área do circulo é: {areaCirculoCalculada}");
        break;
    case 3: // Quadrado
        double alturaQuadradoRecebida;
        double segmentoQuadradoRecebida;

        Console.Write("\nInforme a altura do quadrado: ");
        alturaQuadradoRecebida = Convert.ToDouble(Console.ReadLine());
        Console.Write("\nInforme a base do quadrado: ");
        segmentoQuadradoRecebida = Convert.ToDouble(Console.ReadLine());

        Quadrado novoQuadradoUsuario = new Quadrado(segmentoQuadradoRecebida, alturaQuadradoRecebida);

        double areaQuadradoCalculada = calculadoraGeometrica.CalcularAreaQuadrado(segmentoQuadradoRecebida, alturaQuadradoRecebida);

        Console.WriteLine($"A área do quadrado é: {areaQuadradoCalculada}");
        break;
}