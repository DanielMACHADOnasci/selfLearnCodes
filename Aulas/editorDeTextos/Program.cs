// See https://aka.ms/new-console-template for more information

using System.Diagnostics;
using System.IO;
using System.Net.Mime;
using static System.Console;

namespace editorDeTextos;

internal class Program
{
    public static void Main(string[] args)
    {
        Menu();
    }

    static void Menu()
    {
        short escolha;
        Console.Clear();
        Console.WriteLine("---------------------------------------------");
        Console.WriteLine("--------Bem vindo ao editor de textos--------");
        Console.WriteLine("---------------------------------------------");
        Console.WriteLine(" ");
        Console.WriteLine(" ");
        Console.WriteLine("1 - Abrir arquivo de texto");
        Console.WriteLine("2 - Criar novo arquivo de texto ");
        Console.WriteLine(" ");
        Console.WriteLine("3 - Creditos");
        Console.WriteLine("0 - Sair");
        Console.WriteLine(" ");
        Console.WriteLine(" ");
        Console.WriteLine("---------------------------------------------");
        
        escolha = short.Parse(Console.ReadLine());

        switch (escolha)
        {
            case 1: Abrir(); break;
            case 2: Editar(); break;
            case 3: Creditos(); break;
            case 0: Finalizacao(); break;
            default: Menu(); break;
        }
        
    }

    static void Abrir()
    {
        string path;
        string text;
        
            
        Console.Clear();
        Console.WriteLine("______________________________________________ ");
        Console.WriteLine("_________Qual o caminho do arquivo?___________ ");
        Console.WriteLine("______________________________________________ ");
        path = Console.ReadLine();
        
        //mesmo que um if (File.Exists(path))
        var xCaminho = string.Empty == path ? "C:" : path;
        using (var file = new StreamReader(path ?? "C:"))
        {
             text = file.ReadToEnd();
             Console.WriteLine(text);
        }
        Console.WriteLine(" ");
        Console.ReadLine();
        Menu();
    }

    static void Editar()
    {
        string text = "";
        
        Console.Clear();
        Console.WriteLine("---------------------------------------------");
        Console.WriteLine("---Digite seu texto abaixo.(ESC para sair)---");
        Console.WriteLine("---------------------------------------------");

        do
        {
            text += Console.ReadLine();
            text += Environment.NewLine;//Para quebra de linha

        } while (Console.ReadKey().Key != ConsoleKey.Escape);
        Salvar(text);
        Menu();
        
        
    }

    static void Salvar(string text)
    {
        string path = "";
        
        Console.Clear();
        Console.WriteLine("---------------------------------------------");
        Console.WriteLine("----qual o caminho para salvar o arquivo?----");
        Console.WriteLine("---------------------------------------------");
        
        path = Console.ReadLine();
        
        //using; serve para abrir e fechar o arquivo nesse contexto(tudo dentro dos parenteses).
        using (StreamWriter sw = File.CreateText(path))
        {
            sw.WriteLine(text);
        }
    }

    static void Creditos()
    {
        Clear();
        Console.WriteLine("----------------------------------------------");
        Console.WriteLine("------------------creditos--------------------");
        Console.WriteLine("----------------------------------------------");
        Console.WriteLine(" ");
        Console.WriteLine(" ");
        Console.WriteLine("-Criador: Daniel Machado Nascimento ");
        Console.WriteLine("-E-mail: machadonascimentodaniel@gmail.com ");
        Console.WriteLine(" ");
        Console.WriteLine("supervisionado por: Cássio Oshiro");
        Console.WriteLine(" ");
        Console.WriteLine("-Inspirado por curso do Balta.io");
        Console.WriteLine(" ");
        Console.WriteLine(" ");
        Console.WriteLine("--precione qualquer tecla para voltar ao menu--");
        Console.ReadKey();
        Menu();
    }

    static void Finalizacao()
    {
        Clear();
        Console.WriteLine("-----------------------------------------------------------------------");
        Console.WriteLine("---------------Obrigado por usar meu editor de textos!-----------------");
        Console.WriteLine("-----------------------------------------------------------------------");
        Console.WriteLine(" ");
        Console.WriteLine(" ");
        Console.WriteLine("-Coma frutas");
        Console.WriteLine(" ");
        Console.WriteLine(" ");
        Console.WriteLine("-----------------------------------------------------------------------");
        Thread.Sleep(2000);
        Environment.Exit(0); 
    }
}