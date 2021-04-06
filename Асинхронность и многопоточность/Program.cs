using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;

namespace Асинхронность_и_многопоточность
{
    class Program
    {
        public static object locker = new object();
        static void Main(string[] args)
        {
            #region Многопоточность
            /*Thread thread = new Thread(new ThreadStart(DoWork));
            thread.Start();
            Thread thread2 = new Thread(new ParameterizedThreadStart(DoWork2));
            thread2.Start(int.MaxValue);

            int j = 0;
            for (int i = 0; i < int.MaxValue; i++)
            {
                j++;
                if (j % 100000000 == 0) Console.WriteLine("Main");
            }*/
            #endregion
            #region Async/await
            /*Console.WriteLine("Begin main");
            DoWorkAsync(15);
            Console.WriteLine("Continue Main");

            for (int i = 0; i < 10; i++)
            {
                 Console.WriteLine("Main");
            }

            Console.WriteLine("End main");*/
            #endregion

            var result = SaveFileAsync("D:\\test.txt");
            var input = Console.ReadLine();
            Console.WriteLine(result.Result);

            Console.ReadLine();
        }

        static async Task<bool> SaveFileAsync(string path)
        {
            var result = await Task<bool>.Run(() => SaveFile(path));
            return result;
        }

        static bool SaveFile(string path)
        {
            lock (locker) { 

                var rnd = new Random();
                var text = "";
                for (int i = 0; i < 50000; i++)
                {
                    text += rnd.Next(0, 9);
                }
            }
            using (var sw = new StreamWriter(path, false, Encoding.UTF8))
            {
                sw.WriteLine();
            }
            return true;
        }
        static async Task DoWorkAsync(int max)
        {
            Console.WriteLine("Begin Async");
            await Task.Run(() => DoWork(max));
            Console.WriteLine("End Async");
        }
        static void DoWork(int max)
        {
            for (int i = 0; i < max; i++)
            {
                
                Console.WriteLine("Do Work");
            }
        }
        static void DoWork2(object max)
        {
            int j = 0;
            for (int i = 0; i < (int)max; i++)
            {
                j++;
                if (j % 100000000 == 0) Console.WriteLine("Do Work2");
            }
        }
    }
}
