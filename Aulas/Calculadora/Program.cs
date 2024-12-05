
     internal class Program
    {
        public static void Main(string[] args)
        {
            menu();
        }

        static void menu()
        {
            short opcao;
            
            Console.Clear();
            Console.WriteLine("------Menu Calculadora------");
            Console.WriteLine("1 - SOMA");
            Console.WriteLine("2 - SUBITRAÇÃO");
            Console.WriteLine("3 - DIVISÃO");
            Console.WriteLine("4 - MULTIPLICAÇÃO");
            Console.WriteLine(" ");
            Console.WriteLine("0 - Sair");
            Console.WriteLine("----------------------------");
            opcao = short.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1: soma(); break;
                case 2: subtracao(); break;
                case 3: divisao(); break;
                case 4: multiplicacao(); break;
                case 0: 
                    Console.WriteLine("fechou a calculadora");
                    Environment.Exit(0); 
                    break;
                default: menu();break;
            }
           
        }
        static void soma()
        {
            double valor1, valor2,resultado;
            Console.Clear();
             Console.WriteLine("calculadora de SOMA de dois valores, insira os valores como solicitado");
             Console.WriteLine("Primeiro valor:");
            valor1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Segundo valor:");
            valor2 = double.Parse(Console.ReadLine());
            resultado = valor1 + valor2;
            Console.WriteLine("Resultado:"+resultado);
            Console.ReadKey();
            menu();
        }
        static void subtracao()
        {
            double valor1, valor2, resultado;
            Console.Clear();
            Console.WriteLine("calculadora de SUBITRAÇÃO de dois valores, insira os valores como solicitado");
            Console.WriteLine("Primeiro valor:");
            valor1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Segundo valor:");
            valor2 = double.Parse(Console.ReadLine());
            resultado = valor1 - valor2;
            Console.WriteLine("Resultado:" + resultado);
            Console.ReadKey();
            menu();
        }
        static void divisao()
        {
            double valor1, valor2, resultado;
            Console.Clear();
            Console.WriteLine("Digite o primeiro valor:");
            valor1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor:");
            valor2 = double.Parse(Console.ReadLine());
            resultado = valor1 / valor2;
            Console.WriteLine("Resultado:" + resultado);
            Console.ReadKey();
            menu();
        }
        static void multiplicacao()
        {
            double valor1, valor2, resultado;
            Console.Clear();
            Console.WriteLine("digite o primeiro valor:");
            valor1 = double.Parse(Console.ReadLine());
            Console.WriteLine("digite o segundo valor:");
            valor2 = double.Parse(Console.ReadLine());
            resultado = valor1 * valor2;
            Console.WriteLine("Resultado:" + resultado);
            Console.ReadKey();
            menu();
        }
    }   
