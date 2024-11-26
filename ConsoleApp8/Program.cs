using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        // Метод сортировки массива по возрастанию
        public static int[] SortAscending(int[] array)
        {
            Array.Sort(array);
            return array;
        }

        // Метод сортировки массива по убыванию
        public static int[] SortDescending(int[] array)
        {
            Array.Sort(array);
            Array.Reverse(array);
            return array;
        }

        // Метод объединения двух массивов
        public static int[] MergeArrays(int[] array1, int[] array2)
        {
            int[] mergedArray = new int[array1.Length + array2.Length];
            array1.CopyTo(mergedArray, 0);
            array2.CopyTo(mergedArray, array1.Length);
            return mergedArray;
        }

        // Метод для расчёта абсолютной разности
        public static int CalculateDifference(int n)
        {
            int difference = Math.Abs(n - 123);
            return n > 123 ? difference * 3 : difference;
        }

        static void Main()
        {
            Console.WriteLine("Работа с массивами:");
            int[] array1 = { 5, 2, 9, 1 };
            int[] array2 = { 8, 6, 3 };

            Console.WriteLine("Исходный массив 1: " + string.Join(", ", array1));
            Console.WriteLine("Исходный массив 2: " + string.Join(", ", array2));

            // Сортировка по возрастанию
            int[] sortedAsc = SortAscending((int[])array1.Clone());
            Console.WriteLine("Массив по возрастанию: " + string.Join(", ", sortedAsc));

            // Сортировка по убыванию
            int[] sortedDesc = SortDescending((int[])array1.Clone());
            Console.WriteLine("Массив по убыванию: " + string.Join(", ", sortedDesc));

            // Объединение массивов
            int[] mergedArray = MergeArrays(array1, array2);
            Console.WriteLine("Объединенный массив: " + string.Join(", ", mergedArray));

            // Расчет абсолютной разности
            Console.WriteLine("\nРасчёт абсолютной разности:");
            Console.Write("Введите число n: ");
            if (int.TryParse(Console.ReadLine(), out int n))
            {
                int result = CalculateDifference(n);
                Console.WriteLine($"Результат: {result}");
            }
            else
            {
                Console.WriteLine("Некорректный ввод. Введите целое число.");
            }
            Console.ReadKey();
        }
    }
}
