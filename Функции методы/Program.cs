using System;
using System.Linq;

namespace Функции_методы
{
    class Program
    {
        static string znak(string a, int b)
        {
            string c ="";
            for (int i = 0; i < b; i++) c+=a;
            return c;
        }

        static int ind (int[] a)
        {
            Random rnd = new Random();
            int r = rnd.Next(10);
            int z = Array.FindIndex(a, i => i == r);
            Console.WriteLine("\nРандомное число: " + r);
            return z;
        }
        static void Main(string[] args)
        {
            /*Console.Write("Введите строку: ");
            string a = Console.ReadLine();
            Console.Write("Введите количество символов: ");
            int b = Int16.Parse(Console.ReadLine());
            Console.WriteLine( znak(a, b));*/

            Random rnd = new Random();

            int[] arr = new int[rnd.Next(10,100)];
            for (int i = 0; i < arr.Length; i++) arr[i] = rnd.Next(10);
            for (int i = 0; i < arr.Length; i++) Console.Write(arr[i]+ " ");

            Console.WriteLine("\n" + ind(arr));

        }
    }
}
