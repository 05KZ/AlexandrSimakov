using System;
namespace App
{
    class Program
    {
        public static void Main(string[] args)
        {
            Arr();
        }
        static void Arr()
        {
            Console.WriteLine("Введите длину массива");
            if (!Int32.TryParse(Console.ReadLine(), out var result))
            {
                Console.WriteLine("Нельзя писать буквы");
                Arr();
                return;
            }
            if (result < 2)
            {
                Console.WriteLine("Введите значение не менее 2");
                Arr();
                return;
            }
            ArrElements(result);
        }
        static void ArrElements(int result)
        {
            var array = new int[result];

            Console.WriteLine("Введите элементы массива");
            for (int i = 0; i < array.Length; i++)
            {
                if (!int.TryParse(Console.ReadLine(), out array[i]))
                {
                    Console.WriteLine("только целые числа");
                    ArrElements(result);
                    return;
                }
            }
            Array.Sort(array);
            int a = array.Length - 2;
            Console.WriteLine($"второй набольший элемент массива {array[a]}");
            Console.ReadLine();
        }
    }
}