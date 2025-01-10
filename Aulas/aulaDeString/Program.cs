// See https://aka.ms/new-console-template for more information

using System.Diagnostics;
using static System.Console;

internal class Program
{

    static void AulaDeGuids()
    {
        Console.Clear();
        Console.WriteLine("|-------------------------------------------------------------------|");
        Console.WriteLine("|------------------------------guilds-------------------------------|");
        Console.WriteLine("|-------------------------------------------------------------------|");
        //------------------------------------------------------------------/
        //guids; serve para gerar um id unico ("vai ser mais util pra POO") /
        //------------------------------------------------------------------/
        
        var id = Guid.NewGuid();
        Console.WriteLine(id);
        
        //------------------------------------------------------------------/
        //  por o guid ser de um "sistem" a variavel tem implementos        /
        //que permitem comandos serem feitos diretamente por elas.          /
        //------------------------------------------------------------------/
        
        //nesse exemplo se transforma em string
         id.ToString();
         id = new Guid("42aacef9-7ebb-4293-8ca4-3a18d37959dd");
         Console.WriteLine(id);

         //e com isso se eu quiser somente uma parte do string posso
         // anexar um comando substring
         Console.WriteLine(id.ToString().Substring(0,9));
         
         VoltarParaMenu();
    }

    static void AulaDeinterpolacao()
    {
        Console.Clear();
        //Interpolação nada mais é que unir valores a strings para N finalidades 
        //nos meus exemplos vao ser maneiras de imprimir os dados com "Console.WriteLine("x"):"
        
        var preco = 10.2 + 3;
        var texto = "o preço do exemplo custa: ";
        Console.WriteLine(texto + preco);

        var lugar = 1;
        var lugar2 = 2;
        var lugar3 = 3;
        var posicao = "Daniel ficou em :" + lugar + " lugar";
        Console.WriteLine(posicao);
        Console.WriteLine("--FORMAT--");
        
        //format permite troca de lugar o que pode ser melhor caso tenha que trocar ou caso seja grande o texto
       posicao = string.Format("Daniel :{0} ; Cassio:{1} ; André {2}",lugar,lugar2,lugar3);
       Console.WriteLine(posicao);
       
       posicao = string.Format("Daniel :{2} ; Cassio:{0} ; André {1}",lugar,lugar2,lugar3);
       Console.WriteLine(posicao);
       
       //$"texto com sifrão"
       var texto3 = $"Daniel quer {lugar} pastel com caldo de cana";
       Console.WriteLine(texto3);
       texto3 = $@"posso adicionar @ ao lado do sifrão para
                quebra da linha. sabia que um tambem pode
                ser representada por numero {lugar}";
       Console.WriteLine(texto3);
        VoltarParaMenu();
    }

    static void AulaDeComparacao()
    {
        Console.Clear();
        //função CompareTo retorna booleano de uma comparação de texto.
        string texto = "Testando";
        Console.WriteLine(texto.CompareTo("Testando"));
        Console.WriteLine(texto.CompareTo("testando"));
        
        //função Contains serve para validar partes de uma string inteira
        // "eu estou testando" ----> "testando" = true
        //A função realizará a filtragem ignorando diferenças entre letras maiúsculas e minúsculas com "StringComparison.OrdinalIgnoreCase"
        texto = "eu estou Testando";
        Console.WriteLine(texto.Contains("Testando"));
        Console.WriteLine(texto.Contains("testando"));
        Console.WriteLine(texto.Contains("Testando",StringComparison.OrdinalIgnoreCase));
        VoltarParaMenu();
    }

    static void VoltarParaMenu()    
    {
        Console.WriteLine(" ");
        Console.WriteLine("---precione qualquer tecla para voltar ao menu---");
        Console.ReadKey();
        Menu();
    }

    static void Menu()
    {
        var escolha = 0;
        Console.Clear();
        Console.WriteLine("|-------------------------------------------------------------------|");
        Console.WriteLine("|----------Aulas de strings! qual output quer conferir?-------------|");
        Console.WriteLine("|-------------------------------------------------------------------|");
        Console.WriteLine(" ");
        Console.WriteLine("1 - Guilds");
        Console.WriteLine("2 - Intermediate Strings ");
        Console.WriteLine("3 - Comparação");
        Console.WriteLine(" ");
        Console.WriteLine("0 - sair");
        Console.WriteLine(" ");
        Console.WriteLine(" ");
        escolha = int.Parse(Console.ReadLine());

        switch(escolha)
        {
            case 1: AulaDeGuids(); break;
            case 2: AulaDeinterpolacao(); break;
            case 3: AulaDeComparacao(); break;
            case 0: 
                Console.Clear();
                Console.WriteLine("obrigado!");
                Thread.Sleep(1000);
                break;
            default: Menu(); break;
        }
    }
    
    
    //main
    public static void Main(string[] args)
    {
        Menu();
    }
    
}
