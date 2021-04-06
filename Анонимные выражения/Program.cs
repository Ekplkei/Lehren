using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Анонимные_выражения
{
    class Program
    {
        delegate int MyHandler(int i);
        static void Main(string[] args)
        {
            if (int.TryParse(Console.ReadLine(), out int result))
            {
                 MyHandler handler = (i) =>  //i*i; // Эта строка и нижняя процедура - синонимичны
                //MyHandler handler = delegate (int i) // (тип_аргумента аргумент1, тип_аргумента аргумент2...)
                {
                    // Реализация анонимного метода
                    var r = i * i;
                    Console.WriteLine(r);
                    return r;
                };

                handler += Method;

                handler(result);
            }
            Console.ReadLine();
        }
        public static int Method (int i)
        {
            var r = i * i * i;
            Console.WriteLine(r);
            return r;
        }
    }
}
