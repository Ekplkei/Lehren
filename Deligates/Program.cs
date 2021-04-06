using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deligates
{
    public delegate void Del();
    
    public delegate int Del2(int i);

    class Program
    {


        static void Main(string[] args)
        {
            #region delegate
            Del del = Method4;
            del += Method1;
            //del();
            Del del2 = new Del(Method4);
            del2 += Method4;
            //del2.Invoke();
            var del3 = del + del2;
            //del3();
            var del0 = new Del2(Method0);
            del0(new Random().Next(10, 50));

            Action ActionDelegate = Method1; // del
            ActionDelegate();
            Action<int> act = Method3; // void/ int
            // Action перегружается до 16 раз, как и Predicate и Func
            act(2);

            //Predicate<int> predicate; // тоже самое что и public delegate bool Predicate(int value);
            Func<int, int> func = Method0; // тоже самое что и public delegate last Func(first value);
            func?.Invoke(5);
            #endregion
            Person person = new Person()
            {
                Name = "Вася"
            };
            person.GoToSleep += Person_GoToSleep;
            person.DoWork += Person_DoWork;
            person.TakeTime(DateTime.Parse("01.04.2018 18:05:30"));
            person.TakeTime(DateTime.Parse("02.04.2018 4:05:30"));
            Console.ReadLine();
        }

        private static void Person_DoWork(object sender, EventArgs e)
        {
            if (sender is Person) Console.WriteLine($"{((Person)sender).Name}, слышь, работать");
        }

        private static void Person_GoToSleep()
        {
            Console.WriteLine("Go to sleep");
        }

        public static int Method0(int i)
        {
            Console.WriteLine(i);
            return i;
        }
        public static void Method1()
        {
            Console.WriteLine("Method1");
        }public static int Method2()
        {
            Console.WriteLine("Method2");
            return 0;
        }public static void Method3(int i)
        {
            Console.WriteLine("Method3");
        }public static void Method4()
        {
            Console.WriteLine("Method4");
        }
    }
}
