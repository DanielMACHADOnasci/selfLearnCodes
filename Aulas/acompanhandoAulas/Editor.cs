using System;
using System.Text;

namespace acompanhandoAulas
{
    public static class Editor
    {
        public static void Show()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine("EDITOR MODE");
            Console.WriteLine("-----------");
            Start();

        }

        public static void Start()
        {
            var file = new StringBuilder();

            do
            {
                file.Append(Console.ReadLine());
                file.Append(Environment.NewLine);
            }while(Console.ReadKey(true).Key != ConsoleKey.Escape);
            SaveOrNot(file);
        }

        public static void SaveOrNot(StringBuilder file)
        {
            char option;
            Console.Clear();
            Console.WriteLine("-------------------");
            Console.WriteLine("Deseja Salvar?(s/n)");
            option = char.Parse(Console.ReadLine());
            switch (option)
            {
                case 's':
                {
                    Console.WriteLine("texto salvo"); 
                    Viewer.Show(file.ToString());
                    break;
                }
                case 'n': Console.WriteLine("texto descartado"); break;
                default: SaveOrNot(file); break;
                
            }
        }
    }
}