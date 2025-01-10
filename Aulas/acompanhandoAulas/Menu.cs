using System;

namespace acompanhandoAulas;

public static class Menu
{
    public static void Show()
    {
        short option;
        
        Console.Clear();
        Console.BackgroundColor = ConsoleColor.Blue;
        Console.ForegroundColor = ConsoleColor.Black;
        DrawScreen();
        WriteOptions();
        option = short.Parse(Console.ReadLine());
        MenuHandler(option);
    }

    public static void DrawScreen()
    {
        Linha(); 
        Coluna();
        Linha();
    }

    public static void Linha()
    {
        Console.Write("+");
        for (int i = 0; i < 30; i++)
        {
            Console.Write("=");
        }
        Console.Write("+");
        Console.Write("\n");
    }

    public static void Coluna()
    {
        for (int i = 0; i < 10; i++)
        {
            Console.Write("|");
            //"meio da tela"/entre as colunas
            for (int j = 0; j < 30; j++)
            {
                Console.Write(" ");
            }
            Console.Write("|");
            Console.Write("\n");
            
        }  
    }

    public static void WriteOptions()
    {
        Console.SetCursorPosition(3, 1);
        Console.WriteLine("EDITOR HTML DO PERIGO");
        Console.SetCursorPosition(1, 2);
        Console.WriteLine("------------------------------");
        Console.SetCursorPosition(2, 3);
        Console.WriteLine("<xX_SELECIONE UMA OPÇÃO_Xx>");
        Console.SetCursorPosition(1, 5);
        Console.WriteLine("1 - novo arquivo");
        Console.SetCursorPosition(1, 6);
        Console.WriteLine("2 - Abrir");
        Console.SetCursorPosition(1, 7);
        Console.WriteLine("0 - Sair");
        Console.SetCursorPosition(1, 8);
    }

    public static void MenuHandler(short option)
    {
        
        switch (option)
        {
            case 1: Editor.Show(); break;
            case 2: Console.WriteLine("content"); break;
            case 0:
            {
                Console.Clear();
                Environment.Exit(0);
                break;
            }
            default: Show(); break;    
        }
            
        
    }
}
