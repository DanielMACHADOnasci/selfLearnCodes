// See https://aka.ms/new-console-template for more information

using System.Diagnostics;

namespace projeto_cronometro;

internal class Program
{
    public static void Main(string[] args)
    {
       Menu();
    }

    static void Menu()
    {
        
        int numero;
        string EscolhaENumero;
        char escolha;
        Console.Clear();
        Console.WriteLine("------------Cronometro------------");
        Console.WriteLine("Digite o modo desejado:");
        Console.WriteLine(" ");
        Console.WriteLine("S - Segundos");
        Console.WriteLine("M - Minutos");
        Console.WriteLine("OBS: digite a letra referente ao tempo desejado");
        Console.WriteLine("ex: 10s = sec ou 12m = minutos ");
        Console.WriteLine(" ");
        Console.WriteLine("C - Creditos");
        Console.WriteLine("0 - SAIR.");
        Console.WriteLine("----------------------------------");
     
        
        // Para separar letra e numero                                   
        EscolhaENumero = Console.ReadLine().ToLower();
        escolha = char.Parse(EscolhaENumero.Substring(EscolhaENumero.Length - 1,1));
        numero = int.Parse(EscolhaENumero.Substring(0,EscolhaENumero.Length - 1));

        //validar se foi inserido numero correto e direcionar para min ou sec
        if (numero > 0)
        {
            switch (escolha)
            {
                case 's': Start(numero); break;
                case 'm':
                    numero = numero * 60;
                    Start(numero); 
                    break;
                case 'c': credito(); break;
                default: Menu(); break;
            }    
        }
        else if ( numero < 0)
        {
            Console.Clear();
            Console.WriteLine("-------- foi inserido numero negativo :( --------");
            Console.WriteLine("lembre se...");
            Console.WriteLine("");
            Console.WriteLine("\"O tempo, quando passa, é irrevogável.\"");
            Console.WriteLine("-Sêneca");
            Console.WriteLine("---precione qualquer tecla para voltar ao menu---");
            Console.ReadKey();
            Menu();
        }
        else
        {
            Console.Clear();
            Console.WriteLine("-------- Obrigado por usar meu Cronometro --------");
            Console.WriteLine("-beba agua");
            Thread.Sleep(2500);
            Environment.Exit(0); 
            
        }
       

       
    }
    static void credito()
    {
        Console.Clear();
        Console.WriteLine("------Obrigado por utilizar meu cronometro------");
        Console.WriteLine(" ");
        Console.WriteLine("-Codigo por: Daniel Machado Nascimento");
        Console.WriteLine("-E-mail: machadonascimentodaniel@gmail.com");
        Console.WriteLine(" ");
        Console.WriteLine("supervisionado por: Cássio Oshiro");
        Console.WriteLine(" ");
        Console.WriteLine("-Inspirado por curso do Balta.io");
        Console.WriteLine(" ");
        Console.WriteLine("---precione qualquer tecla para voltar ao menu---");
        Console.ReadKey();
        Menu();
            
    }
    static void Start(int time)
    {
        int currentTime = 0;
        while (currentTime != time)
        {
            Console.Clear();
            currentTime++;
            Console.WriteLine(currentTime);
            Thread.Sleep(1000);
        }
        Console.Clear();
        Console.WriteLine("------Tempo Finalizado!!!------");
        Thread.Sleep(1000);
        Menu();
        
    }
}