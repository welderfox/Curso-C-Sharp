using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Curso
{
    public class Produto
    {
        //Propriedades
        public string Nome { get; set; }
        public double Preco { get; set; }
        public int Quantidade { get; set; }

        //Construtores
        public Produto()
        {

        }

        public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }
        //Construtor recebendo referencia de outro construtor usando a palavra 'this'
        public Produto(string nome, double preco, int quantidade) : this(nome, preco)
        {
            Quantidade = quantidade;
        }

        //Metodos
        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }

        public void AdicionarProduto(int qdt)
        {
            Quantidade += qdt;
        }

        public void RemoverProduto(int qdt)
        {
            Quantidade -= qdt;
        }

        public override string ToString()
        {
            return "Nome:" + Nome
                           + ", Preço $"
                           + Preco.ToString("F2", CultureInfo.InvariantCulture)
                           + ", Quantidade: "
                           + Quantidade
                           + " unidade, Total: $"
                           + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
