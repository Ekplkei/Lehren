using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Песочница
{
    class Program
    {
        static int[] GetArray()
        {
            //int[] b = {2,3,5 };
            int[] b = null;
            return b;
        }

        static void insert(ref int[] array, int value, int index)
        {
            int[] new_array = new int[array.Length+1];
            new_array[index] = value;
            for (int i = 0; i < index; i++) new_array[i] = array[i];
            for (int i = index; i < array.Length; i++) new_array[i+1] = array[i];
            array = new_array;
        }
        static void Main(string[] args)
        {
            /// Null- Объединение. Если строка нулл, то выводится то, что после ??, иначе выводится строка
            /*{
                string str = null;
                string result = str ?? String.Empty;
                Console.WriteLine(result.Length);
            }*/

            /// ??=
            /*{
                string str = null;
                str ??= String.Empty;
                Console.WriteLine(str.Length);

                int[] arr = GetArray();
                arr ??= new int[0];
                Console.WriteLine(arr.Length);
            }*/

            /// Оператор условного Null
            /*{
                int[] arr = GetArray();
                Console.WriteLine("Сумма элементов массива: " + (arr?.Sum()??0));
            }*/

            //{
            //ref и out Почти одинаковые. Превращают значение в ссылку. Но в out нужно задавать значение в методе
            /*string example_code = Console.ReadLine();
            int.TryParse(example_code, out int resultat);
            Console.WriteLine(resultat);*/
            //}

            /*{ 
                int[] arr = { 4, 3, 5 };
                Array.Resize(ref arr, 2 ); //Убирает часть массива или добавляет в конец нули
            }*/

            //Добавление элемента в массив
            /*{
                int[] arr = { 4, 3, 5, 4, 654, 45 };
                insert(ref arr, 99, 2);
            }*/

            //Разница между List и Array
            /*{
                //Initialization
                List<int> myIntsList = new List<int>();
                int[] myIntsArray = new int[10];

                // Adding to Array, List
                for (int i = 0; i < 10; i++)
                {
                    myIntsArray[i] = i;
                    myIntsList.Add(i);
                }
                //Remove
                {
                    myIntsList.RemoveAt(4); // remove to index in list
                }

                //Clear
                {
                    Array.Clear(myIntsArray, 0, myIntsArray.Length); // 1-массив, 2- индекс начала опустошения, 3- количество опустошённых
                    myIntsList.RemoveRange(2, myIntsList.Count-2); // 1- индекс начала опустошения, 2- количество опустошённых
                }
                //  Find
                int target = 4;
                foreach (int num in myIntsArray)
                {
                    if (num == target) Console.WriteLine(target + " is in my ints array.");
                }
                foreach (int num in myIntsList)
                {
                    if (num == target) Console.WriteLine(target + " is in my ints list.");
                }

                //traversing all elements in an array, list
                for(int i = 0; i< myIntsArray.Length; i++)
                {
                    Console.WriteLine("myIntsArray[" + i + "]= " + myIntsArray[i]);
                }
                Console.WriteLine();
                for (int i = 0; i < myIntsList.Count; i++)
                {
                    Console.WriteLine("myIntsList[" + i + "]= " + myIntsList[i]);
                }
            }*/

            // Lambda expressions
            {
                var numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
                Func<int, int> square =  x => x* x;
                Console.WriteLine(square(4));
                Func<int, bool> nechet = i => i%2!=0;
                var Odd = numbers.Where(nechet).ToList();
                Action<int> printOdd = x =>
                {
                    var cube = x * x * x;
                    var square = x * x;
                    Console.WriteLine($"X: {x} square: {square} cube: {cube}");
                };
                //Odd.ForEach(x => Console.WriteLine(x); 
                Odd.ForEach(printOdd);
                //Console.WriteLine(numbers.Where(nechet).ToList());
            }
        }
    }
}

