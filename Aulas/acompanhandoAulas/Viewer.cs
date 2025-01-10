using System;
using System.Text;
using System.Text.RegularExpressions;

namespace acompanhandoAulas
{
    public class Viewer
    {
        public static void Show(string text)
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Clear();
            Console.WriteLine("MODO VISUALIZAÇÃO");
            Console.WriteLine("------------------");
            Replace(text);
            Console.WriteLine("------------------");
            Console.ReadKey();
            Menu.Show();
        }

        public static void Replace(string text)
        {
            var strong = new Regex(@"<\s*strong[^>]*>(.*?)<\s*/\s*strong>");
            var words = text.Split(' ');
            //por fazer split do texto vamos rodar um for nesse vet de string para procurar o "strong"
            for (var i = 0; i < words.Length; i++)
            {
                //se achar palavra strong vamos "negritar" o que tiver entre EX:"<strong> ... <\strong>"
                if (strong.IsMatch(words[i]))
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write
                    (
                        words[i].Substring(
                            words[i].IndexOf('>')+1,(
                                (words[i].LastIndexOf('<')-1) - 
                                words[i].IndexOf('>')
                            )
                        )
                    );
                    Console.Write(" ");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.Write(words[i]);
                    Console.Write(" ");
                }
            }
        }
    }
}