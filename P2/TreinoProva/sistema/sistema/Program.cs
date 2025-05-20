using System.Text.RegularExpressions;
using sistema.Classes;

Loja loja = new Loja();

Produto produto1 = new Eletronico("Samsung", "preto", 2500.0, true);
Produto produto2 = new Roupa("Renner", "verde", 70, "PP");
Produto produto3 = new Roupa("Renner", "verde", 70, "GG");
Produto produto4 = new Alimento("Burguer King", "amarelo", 35, new DateTime(2024, 10, 5));
Produto produto5 = new Alimento("Burguer King", "amarelo", 35, new DateTime(2024, 10, 5));

loja.AdicionarProduto(produto1);
loja.AdicionarProduto(produto2);
loja.AdicionarProduto(produto3);
loja.AdicionarProduto(produto4);
loja.AdicionarProduto(produto5);

List<Produto> produtosSamsung = loja.ProcurarProduto("Samsung");
Console.WriteLine("Quantidade de produtos Samsung: " + produtosSamsung.Count);

List<Produto> produtosBurgerKingAmarelosEDe35Reais = loja.ProcurarProduto("Burguer King", 35, "amarelo");
Console.WriteLine("Quantidade de produtos do Burguer King amarelos e de R$ 35: " + produtosBurgerKingAmarelosEDe35Reais.Count);

loja.RemoverProduto(produto3);
loja.RemoverProduto(produto5);

loja.Descrever();