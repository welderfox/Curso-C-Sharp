using System;
using System.Globalization;

namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Triangulo

            //// Declarando variavel do tipo Triangulo
            //Triangulo x, y;

            ////Instanciando a classe trinagulo
            //x = new Triangulo();
            //y = new Triangulo();

            //Console.WriteLine("Entre com as medidas do tringulo 'X'");
            //x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Console.WriteLine("Entre com as medidas do tringulo 'Y'");
            //y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //double areaX = x.Area();

            //double areaY = y.Area();

            //Console.WriteLine($"Area do tringulo 'X' = {areaX}");
            //Console.WriteLine($"Area do tringulo 'Y' = {areaY}");

            #endregion

            #region Pessoa

            //// Declarando variavel do tipo Triangulo
            //Pessoa pessoa1, pessoa2;

            ////Instanciando a classe Pessoa
            //pessoa1 = new Pessoa();
            //pessoa2 = new Pessoa();

            //Console.WriteLine("Entre com dados da  1ª pessoa !");
            //pessoa1.Nome = Console.ReadLine();
            //pessoa1.Idade = int.Parse(Console.ReadLine());

            //Console.WriteLine("Entre com dados da  2ª pessoa !");
            //pessoa2.Nome = Console.ReadLine();
            //pessoa2.Idade = int.Parse(Console.ReadLine());

            //if (pessoa1.Idade > pessoa2.Idade)
            //{
            //    Console.WriteLine($"Pessoa mais velha: {pessoa1.Nome}");
            //}
            //else
            //{
            //    Console.WriteLine($"Pessoa mais velha: {pessoa2.Nome}");
            //}

            #endregion

            #region Produto em estoque
                       
            Console.WriteLine("Entre com os dados do Produto:");
            Console.Write("Nome:");
            var nome = Console.ReadLine();

            Console.WriteLine("Preco:");
            var preco = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Produto produto = new Produto(nome, preco);

            Console.WriteLine($"Dados do produto: {produto}");

            Console.WriteLine();

            Console.Write("Digite a qauntidade de produto a ser adicionado ao estoque:");
            int qtd = int.Parse(Console.ReadLine());
            produto.AdicionarProduto(qtd);
            Console.WriteLine();
            Console.WriteLine($"Dados do produto atualizados: {produto}");

            Console.WriteLine();

            Console.Write("Digite a qauntidade de produto a ser removido do estoque:");
            qtd = int.Parse(Console.ReadLine());
            produto.RemoverProduto(qtd);
            Console.WriteLine();
            Console.WriteLine($"Dados do produto atualizados: {produto}");

            #endregion

            #region Retaangulo

            //Retangulo retangulo = new Retangulo();

            //Console.WriteLine("Digite altura e largura do retangulo!");
            //retangulo.Largura = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //retangulo.Alura = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Console.WriteLine();
            //Console.WriteLine($"{retangulo}");

            #endregion
        }
    }
}
