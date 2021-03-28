using System;

namespace Стеки_и__хип
{
    class Program
    {
        static void struc(int a)
        {
            a++;
        }
        static void Arra(int [] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = 4 + i;
            }
        }
        static void Main(string[] args)
        {
            int b = 0;
            struc(b);
            int[] arr = { 0, 1, 2, 3 };
            Arra(arr);
            //Console.WriteLine(b);
            for (int i = 0; i < arr.Length; i++) Console.WriteLine(arr[i]);
        }
    }
}
