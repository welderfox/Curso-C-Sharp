using System;
using Curso.Entities.Post;

namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Estrutura condicional

            //int hora;
            //Console.WriteLine("Digite a Hora no formatho HH");
            //hora = int.Parse(Console.ReadLine());

            //if (hora < 12)
            //{
            //    Console.WriteLine("Bom dia!!");
            //}
            //else 
            //{
            //    Console.WriteLine("Boa tarde!!");
            //}

            #endregion

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


            //int N;
            //int[] vet;

            //N = int.Parse(Console.ReadLine());

            //vet = new int[N];

            //string[] s = Console.ReadLine().Split(' ');

            //for (int i = 0; i < N; i++)
            //{
            //    vet[i] = int.Parse(s[i]);
            //}

            ////Imprimir somente numeros negativos
            //for (int i = 0; i < N; i++)
            //{
            //    if (vet[i] < 0)
            //    {
            //        Console.WriteLine(vet[i]);
            //    }
            //}

            //int N;
            //N = int.Parse(Console.ReadLine());

            //string[] nomes = new string[N];
            //int[] idades = new int[N];
            //double[] alturas = new double[N];

            ////Leitura doas dados
            //for (int i = 0; i < N; i++)
            //{
            //    //Vetor Auxiliar
            //    string[] s = Console.ReadLine().Split(' ');
            //    nomes[i] = s[0];
            //    idades[i] = int.Parse(s[1]);
            //    alturas[i] = double.Parse(s[3], CultureInfo.InvariantCulture);
            //}

            ////Altura media
            //double soma = 0.0;
            //for (int i = 0; i < N; i++)
            //{
            //    soma = soma + alturas[i];
            //}

            //double media = soma / N;

            //Console.WriteLine("Altura media" + media.ToString("F2", CultureInfo.InvariantCulture));

            ////Porcentagem
            //int cont = 0;
            //for (int i = 0; i < N; i++)
            //{
            //    if (idades[i] < 16)
            //        cont++;
            //}

            //double prcent = (double)cont / N * 100.0;

            //Console.WriteLine("Pessoa com menos de 16 anos : " + prcent.ToString("F2", CultureInfo.InvariantCulture));

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
            //Produto[] produtos = new Produto[n];

            //for (int i = 0; i < n; i++)
            //{
            //    Console.WriteLine("Nome do produto");
            //    string nome = Console.ReadLine();
            //    Console.WriteLine("Preco produto");
            //    double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

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

            #region Matrizes

            //int N;
            ////Declarando uma Matriz
            //int[,] A;

            //N = int.Parse(Console.ReadLine());

            //A = new int[N, N];

            //for (int i = 0; i < N; i++)//For para percorrer as linhas da matriz
            //{
            //    string[] s = Console.ReadLine().Split(' ');

            //    for (int j = 0; j < N; j++)//For para percorrer as colunas da matriz
            //    {
            //        A[i, j] = int.Parse(s[j]);
            //    }
            //}

            ////Exibir diagonal principal
            //Console.WriteLine("Diagonal principal...");

            //for (int i = 0; i < N; i++)
            //{
            //    Console.Write(A[i, i] + " ");
            //    Console.WriteLine();
            //}
            ////Quantidade de numeros negativos

            //int cont = 0;

            //for (int i = 0; i < N; i++)
            //{
            //    for (int j = 0; j < N; j++)
            //    {
            //        if (A[i, j] < 0)
            //        {
            //            cont++;
            //        }
            //    }
            //}

            //Console.WriteLine("Quantidades de negativos:" + cont);

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

            //int x = int.Parse(Console.ReadLine());
            //string day;

            //switch (x)
            //{
            //    case 1:
            //        day = "Domingo";
            //        break;
            //    case 2:
            //        day = "Segunda-Feira";
            //        break;
            //    case 3:
            //        day = "Terça-Feira";
            //        break;
            //    case 4:
            //        day = "Quarta-Feira";
            //        break;
            //    case 5:
            //        day = "Quinta-Feira";
            //        break;
            //    case 6:
            //        day = "Sexta-Feira";
            //        break;
            //    case 7:
            //        day = "Sabado";
            //        break;
            //    default:
            //        day = "Valor não tratado";
            //        break;
            //}

            //Console.WriteLine("Dia da semana: " + day);

            #endregion

            #region Expressão condicional ternária

            //double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //double desconto = (preco < 20.0) ? preco * 0.1 : preco * 0.05;

            //Console.WriteLine("Desconto: " + desconto);

            #endregion

            #region DateTime

            //DateTime date = DateTime.Now;
            //Console.WriteLine("Agora são extamente: " + date);
            //Console.WriteLine("Em Ticks: " + date.Ticks);

            ////Convertendo string para DateTime

            //DateTime dateString = DateTime.Parse("2022-04-02");
            //DateTime dateString1 = DateTime.Parse("04/02/2022");
            ////DateTime formatoExato = DateTime.ParseExact("04/02/2022 13:05:59", "dd/MM/yyyyy HH:MM:ss", CultureInfo.InvariantCulture);

            //Console.WriteLine("Data em formato stgring, convertido para DateTime: " + dateString);
            //Console.WriteLine("Data em formato stgring, convertido para DateTime: " + dateString1);
            ////Console.WriteLine("Data em formato exato: " + formatoExato);

            #endregion

            #region Git

            /*
              * git init
              * git add. (stage)
              * git status
              * git commit -m "Mensagem"
              * git branch -M main (branch padrão)
              * git remote add origin git@github.com:user/usergithub.git "SSH"
              * git push -u origin main (nome da branch) envia AS ALTERAÇÕES projeto 
              * git log (verifica historico de versoes)
              * git log --oneline (verifica historico de versoes resumido)
              * git reset
              * git clean -df
              * git checkout -- .
              * git reset --hard <codigo do comit>
              * git remote add set-url <repositorio> inviar (mudar projeto para outro repositorio remoto)
              * 
            */

            #endregion

            #region Enum (Enumercoes)

            //int id = 10;
            //var moment = DateTime.Now;


            ///*Tipo especial que serve para especificar de forma literal um conjuto de constantes relacionadas */
            //Order ordem = new Order(id, moment, Order.OrderStatus.PedingPayment);

            //Order ordem1 = new Order
            //{
            //    Id = 20,
            //    Moment = DateTime.Now,
            //    Status = Order.OrderStatus.Sipped
            //};

            //Console.WriteLine($"Pedido: '{ordem.Id}' -  iniciado: '{ordem.Moment}' - Status: '{ordem.Status}'");

            //Console.WriteLine($"Pedido: '{ordem1.Id}' -  iniciado: '{ordem1.Moment}' - Status: '{ordem1.Status}'");



            #endregion

            #region Exercicio Contrato (Worker)

            //Console.Write("Enter department's name: ");
            //string deptname = Console.ReadLine();

            //Console.WriteLine("Enter worker data: ");
            //Console.Write("Name: ");
            //string name = Console.ReadLine();

            //Console.Write("Level ( Junior/Intermerdiario/Senior)");
            //Worker.WorkerLevel level = Enum.Parse<Worker.WorkerLevel>(Console.ReadLine());

            //Console.Write("Base salary");
            //double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Department dep = new Department(deptname);
            //Worker worker = new Worker(name, level, salary, dep);

            //Console.Write("how many contracts to this worker? ");
            //int n = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= n; i++)
            //{
            //    Console.Write($"Enter #{n} contract data: ");

            //    Console.Write("Data (DD/MM/YYYY) : ");
            //    DateTime date = DateTime.Parse(Console.ReadLine());

            //    Console.Write("value per hours : ");
            //    double value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //    Console.Write("Duration (hours) : ");
            //    int hours = int.Parse(Console.ReadLine());


            //    HourContract contrac = new HourContract(date, value, hours);

            //    worker.AddContract(contrac);
            //}

            //Console.Write("Enter month and year to calculete income (MM/YYYY): ");
            //string mesAno = Console.ReadLine();

            //int mes = int.Parse(mesAno.Substring(0, 2));
            //int ano = int.Parse(mesAno.Substring(3));

            //Console.WriteLine($"Name: {worker.Nome}");
            //Console.WriteLine($"Departmente: {worker.Department.Nome}");
            //Console.WriteLine($"Income for: {mesAno} : {worker.Income(mes, ano)}" );

            #endregion

            #region Exercicio resolvido 2 (String Builder)

            Comment comment1 = new Comment("Have a nice trip");
            Comment comment2 = new Comment("Wow, awesome!!!");

            Post post1 = new Post
                (
                    moment: DateTime.Parse("20/05/2022 13:05:00"),
                    title: "Traveling to USA",
                    content: "Visitando esse país maravilhoso",
                    likes: 12
                );

            post1.AddComent(comment1);
            post1.AddComent(comment2);


            Comment comment3 = new Comment("Have a good night");
            Comment comment4 = new Comment("May the force be whit you");

            Post post2 = new Post
                (
                    moment: DateTime.Parse("20/05/2022 23:05:00"),
                    title: "Good night guys",
                    content: "See you tomorrow",
                    likes: 12
                );

            post2.AddComent(comment3);
            post2.AddComent(comment4);


            Console.WriteLine(post1);
            Console.WriteLine("");
            Console.WriteLine(post2);

            #endregion

            Felino felino = new Felino("Onça","Parda", 5);

            Console.WriteLine(felino);


        }
    }
}
