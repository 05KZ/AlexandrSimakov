using System;
namespace Calc
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Привет, я миникалькулятор"); //приветствие
            DoYouWantCalc(); //метод спрашивающий о необходимости счета
        }
        public static void DoYouWantCalc()
        {
            Console.WriteLine("Хочешь посчитать жми Y, если нет, жми N");
            string selection = Console.ReadLine();
            switch (selection)
            {
                case "Y":
                case "y":
                    Values();
                    break;
                case "N":
                case "n":
                    SayGoodBye();
                    break;
                default:
                    Console.WriteLine("Неизвестная команда");
                    DoYouWantCalc();
                    break;
            }
            static void Values()
            {
                Console.WriteLine("Введите выражение вставляя пробел между символами");
                var str = Console.ReadLine();
                var array = str.Split(' ');

                if (array[1] == "+")
                {
                    var x = Convert.ToInt32(array[0]) + Convert.ToInt32(array[2]);
                    Console.WriteLine(x);
                }
                else if (array[1] == "-")
                {
                    var x = Convert.ToInt32(array[0]) - Convert.ToInt32(array[2]);
                    Console.WriteLine(x);
                }
                else if (array[1] == "*")
                {
                    var x = Convert.ToInt32(array[0]) * Convert.ToInt32(array[2]);
                    Console.WriteLine(x);
                }
                else if (array[1] == "/")
                {
                    try
                    {
                        var x = Convert.ToInt32(array[0]) / Convert.ToInt32(array[2]);
                        Console.WriteLine(x);
                    }
                    catch (DivideByZeroException) when (Convert.ToInt32(array[2]) == 0)
                    {
                        Console.WriteLine("На ноль делить нельзя!");
                    }
                    DoYouWantCalc();
                }
                else if (array[1] == "%")
                {
                    var x = Convert.ToInt32(array[0]) % Convert.ToInt32(array[2]);
                    Console.WriteLine(x);
                }
                else
                {
                    Console.WriteLine("Введите данные через пробел. В качестве оператора необходимо ввести +, -, *, / или %");
                }
                DoYouWantCalc();
            }

            static void SayGoodBye()
            {
                Console.WriteLine("Пока!");
                Console.ReadLine();
            }

        }
    }
}
