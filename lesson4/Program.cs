using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество элементов массива: ");
            int elementCount = int.Parse(Console.ReadLine());
            int[] myArray = new int[elementCount];
            Random random = new Random();
            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = random.Next(-100, 100);
            }

            Console.WriteLine("Вывод массива: ");

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine(myArray[i]);
            }

            // нематематические операции:

            int minValue = myArray.Min();
            Console.WriteLine("\n минимальное значение в массиве: " + minValue);

            int maxValue = myArray.Max();
            Console.WriteLine("максимальное значение в массиве: " + maxValue);

            int sumValue = myArray.Sum();
            Console.WriteLine("сумма всех элементов в массиве: " + sumValue);

            double averageValue = myArray.Average();
            Console.WriteLine("среднее арифметическое элементов в массиве: " + averageValue);


            // математические операции:
            Console.WriteLine("\n А теперь математические операции: ");

            int minValue1 = myArray[0];
            for (int i = 1; i < myArray.Length; i++)
            {
                if (myArray[i] < minValue1)
                { minValue1 = myArray[i]; }
            }
            Console.WriteLine("\n минимальное значение в массиве: " + minValue1);

            int maxValue1 = myArray[0];
            for (int i = 1; i < myArray.Length; i++)
            {
                if (myArray[i] > maxValue1)
                { maxValue1 = myArray[i]; }
            }
            Console.WriteLine("максимальное значение в массиве: " + maxValue1);

            int sumValue1 = 0;
            for (int i = 0; i < myArray.Length; i++)
            { sumValue1 = (sumValue1) + (myArray[i]); }
            Console.WriteLine("сумма всех элементов в массиве " + sumValue1);

            double sumValue2 = (double)(sumValue1);
            double averageValue1 = (double)(sumValue2 / elementCount);
            Console.WriteLine("среднее арифметическое элементов в массиве: " + averageValue1);


            // сортировка элементов по убыванию
            Console.WriteLine("\n сортировка по убыванию: ");

            for (int i = 0; i < myArray.Length; i++)
            {
                for (int j = i + 1; j < myArray.Length; j++)
                    if (myArray[i] < myArray[j])
                    {
                        int temp = myArray[i];
                        myArray[i] = myArray[j];
                        myArray[j] = temp;

                    }
                Console.WriteLine(myArray[i]);

            }


            Console.ReadKey();
        }
    }
}
