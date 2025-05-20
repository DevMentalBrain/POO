using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistema.Classes
{
    internal class Loja
    {
        private List<Produto> produtos;

        public Loja()
        {
            produtos = new List<Produto>();
        }
        public void AdicionarProduto(Produto novoProduto)
        {
            if(novoProduto == null)
            {
                return;
            }
            produtos.Add(novoProduto);
        }
        public List<Produto> ProcurarProduto(string marca)
        {
            List<Produto> produtosDaMarca = new List<Produto>();

            foreach(Produto produto in produtos)
            {
                if(produto.Marca == marca)
                {
                    produtosDaMarca.Add(produto);
                }
            }
            return produtosDaMarca;
        }
        public List<Produto> ProcurarProduto(string marca, double valor, string cor)
        {
            List<Produto> produtosDaMarca = new List<Produto>();

            foreach (Produto produto in produtos)
            {
                if (produto.Marca == marca && produto.Valor == valor && produto.Cor == cor)
                {
                    produtosDaMarca.Add(produto);
                }
            }
            return produtosDaMarca;
        }
        public void RemoverProduto(Produto produtoARemover)
        {
            produtos.Remove(produtoARemover);
        }
        public void Descrever()
        {
            Console.WriteLine("\nProdutos Cadastrados:\n");
            foreach (Produto produto in produtos)
            {
                if(produto is Eletronico)
                {
                    Eletronico eletronico = (Eletronico)produto;
                    Console.WriteLine($"Marca: {eletronico.Marca}, Cor: {eletronico.Cor}, Preço: {eletronico.Valor}, Bivolt: {eletronico.Bivolt}");
                }
                else if(produto is Roupa)
                {
                    Roupa roupa = (Roupa)produto;
                    Console.WriteLine($"Marca: {roupa.Marca}, Cor: {roupa.Cor}, Preço: {roupa.Valor}, Tamanho: {roupa.Tamanho}");
                }
                else if(produto is Alimento)
                {
                    Alimento alimento = (Alimento)produto;
                    Console.WriteLine($"Marca: {alimento.Marca}, Cor: {alimento.Cor}, Preço: {alimento.Valor}, Data de Vencimento: {alimento.DataVencimento}");
                }
            }
        }
    }
}