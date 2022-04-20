using System;

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

            //Console.WriteLine("Entre com os dados do Produto:");
            //Console.Write("Nome:");
            //var nome = Console.ReadLine();

            //Console.WriteLine("Preco:");
            //var preco = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Produto produto = new Produto(nome, preco);

            ////Sitaxe alternativa para instanciar objeto.
            // // Produto produto1 = new Produto
            // //{
            // //    Nome = "Radio",
            // //    Preco = 2.30,
            // //    Quantidade = 10
            // //};


            //Console.WriteLine($"Dados do produto: {produto}");

            //Console.WriteLine();

            //Console.Write("Digite a qauntidade de produto a ser adicionado ao estoque:");
            //int qtd = int.Parse(Console.ReadLine());
            //produto.AdicionarProduto(qtd);
            //Console.WriteLine();
            //Console.WriteLine($"Dados do produto atualizados: {produto}");

            //Console.WriteLine();

            //Console.Write("Digite a qauntidade de produto a ser removido do estoque:");
            //qtd = int.Parse(Console.ReadLine());
            //produto.RemoverProduto(qtd);
            //Console.WriteLine();
            //Console.WriteLine($"Dados do produto atualizados: {produto}");

            #endregion

            #region Retaangulo

            //Retangulo retangulo = new Retangulo();

            //Console.WriteLine("Digite altura e largura do retangulo!");
            //retangulo.Largura = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //retangulo.Alura = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Console.WriteLine();
            //Console.WriteLine($"{retangulo}");

            #endregion

            #region Conta bancaria

            //string dpInicial;
            //double deposito;
            //Conta conta = new Conta();

            //Console.WriteLine("Digite dados da conta:");

            //Console.Write("Titular da conta: ");
            //conta.NomeTitularConta = Console.ReadLine();

            //Console.Write("Numero da conta: ");
            //conta.NumeroConta = int.Parse(Console.ReadLine());

            //Console.WriteLine("Haverá deposito inicial(S/N) ?");
            //dpInicial = Console.ReadLine();
            //if (dpInicial.Equals("S") || dpInicial.Equals("s") || dpInicial == null)
            //{
            //    Console.WriteLine("Valor deposito inicial");
            //    deposito = Double.Parse(Console.ReadLine());
            //    conta.Deposito(deposito);
            //    Console.WriteLine("Dados da conta atualizados");
            //    Console.WriteLine(conta);
            //    Console.WriteLine();
            //}

            //    Console.WriteLine("Digite valor que deseja depositar");
            //    deposito = Double.Parse(Console.ReadLine());
            //    conta.Deposito(deposito);
            //    Console.WriteLine("Dados da conta atualizados");
            //    Console.WriteLine(conta);

            //    Console.WriteLine();

            //    Console.WriteLine("Entre com um valor para saque...");
            //    double saque = Double.Parse(Console.ReadLine());
            //    conta.Saque(saque);
            //    Console.WriteLine("Dados da conta atualizados");
            //    Console.WriteLine(conta);

            #endregion

            #region Vetores 1

            //Console.WriteLine("Digite o tamanho do vetor");
            //int n = int.Parse(Console.ReadLine());

            ////Declarando vetor
            //double[] vet = new double[n];

            //for (int i = 0; i < n; i++)
            //{
            //    vet[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //    Console.WriteLine($"Posicao do vetor '{i}' = '{vet.GetValue(i)}'");
            //}

            //double soma = 0.0;

            //for (int i = 0; i < n; i++)
            //{
            //    soma += vet[i];
            //}

            //double avg = soma / 2;

            //Console.WriteLine($"Media das alturas {avg.ToString("F2", CultureInfo.InvariantCulture)}");

            #endregion

            #region Vetores Exercicio

            //int n = int.Parse(Console.ReadLine());

            //Produto[] produtos = new Produto[n];

            //for (int i = 0; i < n; i++)
            //{
            //    Console.WriteLine("Nome do produto");
            //    string nome = Console.ReadLine();
            //    Console.WriteLine("Preco produto");
            //    double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //    produtos[i] = new Produto
            //    {
            //        Nome = nome,
            //        Preco = preco
            //    };
            //}

            //double precoMedio = 0.0;

            //for (int i = 0; i < n; i++)
            //{
            //    precoMedio += produtos[i].Preco;
            //}

            //double media = precoMedio / n;

            //Console.WriteLine($"Preco medio {media.ToString("F2", CultureInfo.InvariantCulture)}");

            #endregion

            #region Exercicio proposto

            //Estudante[] estudantes = new Estudante[10];

            //Console.WriteLine("Quantos quartos serão alugados?");
            //int n = int.Parse(Console.ReadLine());

            //for (int i = 0; i < n; i++)
            //{
            //    Console.WriteLine();
            //    Console.WriteLine($"Aluguel #{i}:");
            //    Console.WriteLine("Nome: ");
            //    string nome = Console.ReadLine();
            //    Console.WriteLine("Email: ");
            //    string email = Console.ReadLine();
            //    Console.WriteLine("Quarto: ");
            //    int quarto = int.Parse(Console.ReadLine());

            //    estudantes[quarto] = new Estudante(nome, email);
            //}
            //Console.WriteLine();
            //Console.WriteLine("Quartos ocupados:");
            //for (int i = 0; i < 10; i++)
            //{
            //    if (estudantes[i] != null)
            //    {
            //        Console.WriteLine(i + ": " + estudantes[i]);
            //    }
            //}


            #endregion

            #region Operado de coalescencia nula '??'

            /// <summary>
            /// O operador de coalescência nula ?? retornará o valor do operando esquerdo se não for null;
            /// caso contrário, ele avaliará o operando direito e retornará seu resultado. 
            /// O operador ?? não avaliará o operando do lado direito se o operando esquerdo for avaliado como não nulo.
            /// </summary> 

            //bool? a =  true;
            //bool? b = false;

            //var x = b ?? a;

            //Console.WriteLine(x);

            #endregion

            #region Sintaxe alternativa - switch-case

            int x = int.Parse(Console.ReadLine());
            string day;

            switch (x)
            {
                case 1:
                    day = "Domingo";
                    break;
                case 2:
                    day = "Segunda-Feira";
                    break;
                case 3:
                    day = "Terça-Feira";
                    break;
                case 4:
                    day = "Quarta-Feira";
                    break;
                case 5:
                    day = "Quinta-Feira";
                    break;
                case 6:
                    day = "Sexta-Feira";
                    break;
                case 7:
                    day = "Sabado";
                    break;
                default:
                    day = "Valor não tratado";
                    break;
            }

            Console.WriteLine("Dia da semana: " + day);

            #endregion


        }
    }
}
