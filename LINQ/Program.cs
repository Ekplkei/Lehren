using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Program
    {   
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            
            var products = new List<Product>();
            for (int i = 0; i < 10; i++)
            {
                var product = new Product()
                {
                    Name = "Продукт" + i,
                    Energy = rnd.Next(10, 12)
                };
                products.Add(product);
            }

            var result = from item in products
                         where item.Energy < 200 || item.Energy > 400
                         orderby item.Energy
                         select item;
            //Равносильны
            var result2 = products.Where(item => item.Energy < 200 || item.Energy > 400)
                /*.Where(item => item % 2==0)
                .OrderByDescending(item => item)*/;

            foreach (var item in result) //Вывод первого результата
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            foreach (var item in result2) // Вывод второго результата
            {
                Console.WriteLine (item);
            }
            
            var selectCollection = products.Select(product => product.Energy); // Выводит определённое
            Console.WriteLine();
            foreach (var item in selectCollection)
            {
                Console.WriteLine(item);
            }

            var orderbyCollection = products.OrderBy(product => product.Energy).ThenByDescending(product => product.Name); // Двойгой ордер
            Console.WriteLine();
            foreach (var item in orderbyCollection)
            {
                Console.WriteLine(item);
            }

            var groupbyCollection = products.GroupBy(product => product.Energy); // Группировка
            Console.WriteLine();
            foreach(var group in groupbyCollection)
            {
                Console.WriteLine($"Ключ: {group.Key}"); // Ключ (по чему группируем)
                foreach (var item in group)
                {
                    Console.WriteLine($"\t{item}"); // Вывод группировок
                }
            }
            Console.WriteLine();
            products.Reverse();
            foreach (var item in products) // Ревёрснутый список
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            Console.WriteLine(products.All(item => item.Energy == 10)); // Все ли энерг значения равны 10
            Console.WriteLine();
            Console.WriteLine(products.Any(item => item.Energy == 10)); // Хотя бы 1 энерг значение равны 10
            var prod = new Product();
            Console.WriteLine();
            Console.WriteLine(products.Contains(products[1])); // Есть ли вхождение элемента в список True
            Console.WriteLine(products.Contains(prod)); // False

            var ar = new int[] { 1, 2, 3, 4 };
            var ar2 = new int[] { 3, 4, 5, 6 };
            Console.WriteLine();
            foreach (var item in ar) // Просто первый список
            {
                Console.WriteLine(item);
            }
            var union = ar.Union(ar2);
            Console.WriteLine();
            foreach (var item in union) // Объединённый список
            {
                Console.WriteLine(item);
            }

            var intersect = ar.Intersect(ar2);
            Console.WriteLine();
            foreach (var item in intersect) // Объединённый список (Пересечение)
            {
                Console.WriteLine(item);
            }

            var except = ar.Except(ar2);
            Console.WriteLine();
            foreach (var item in except) // Разность (ar - ar2)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            Console.WriteLine(ar.Skip(1).Sum()); // Сумма элементов массива (Без первого)
            Console.WriteLine(ar.Min()); // Минимальное значение массива
            Console.WriteLine(ar.Take(3).Max()); // Максимальное значение массива (Из первых трёх))
            Console.WriteLine(ar.Average()); // Среднее значение массива
            Console.WriteLine(ar.Aggregate((x,y) => x*y)); // Произведение всех чисел в массиве
            Console.WriteLine();
            Console.WriteLine(ar.First()); // Вывод первого элемента (FirstOrDefault Для списков, где может не быть значений)
            Console.WriteLine(ar.Last());// Вывод последнего элемента (LastOrDefault Для списков, где может не быть значений)
            //Console.WriteLine(products.Single(product => product.Energy == 10)); // Кидает ошибку тк значение не одно
            Console.WriteLine();
            Console.WriteLine(products.ElementAt(5)); // Берёт значение по номеру (не индексу)
            Console.WriteLine(ar.Distinct());
            Console.ReadLine();
        }
    }
}
