// See https://aka.ms/new-console-template for more information

internal class Program
{
    public static void Main(string[] args)
    {
        //formas de declarar vetores/array
        int[] arrayEIgualAVetor = new int[3];
        arrayEIgualAVetor[0] = 5;
        foreach (var contator in arrayEIgualAVetor)
        {
           Console.WriteLine(contator);//5,0,0;
        }
    }
}