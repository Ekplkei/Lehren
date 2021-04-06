using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            var cars = new List<ICar>();
            cars.Add(new Lada_seven());
            cars.Add(new BMW_seven());

            foreach (var car in cars)
            {
                // msdn справочник по всем ключевым словам
                Console.WriteLine(car.Move(200));
            }
            Cyborg cyborg = new Cyborg();
            Console.WriteLine(((ICar)cyborg).Move(100)); // Без приведения интерфейса не реализует ни один из них
            Console.WriteLine(((IPerson)cyborg).Move(100));
            Console.ReadLine();
        }
    }
}
