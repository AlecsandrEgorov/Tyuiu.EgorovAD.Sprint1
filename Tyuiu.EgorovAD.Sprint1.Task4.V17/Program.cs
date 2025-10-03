using Tyuiu.EgorovAD.Sprint1.Task4.V17.Lib;
namespace Tyuiu.EgorovAD.Sprint1.Task4.V17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнил: Егоров.А.Д. | СМАРТб25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Базовые навики работы в C#                                        *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #17                                                             *");
            Console.WriteLine("* Выполнил: Егоров.А.Д. | СМАРТб25-1                                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Условие:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
            Console.WriteLine("* вычисляет результат по формуле и печатает его на экране.                *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            double x, y;
            Console.WriteLine("Введите x:");
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите y:");
            y = Convert.ToInt32(Console.ReadLine());



            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Результат:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("1 / sqrt( x - 5 * y) = " + ds.Calculate(x, y));

            Console.ReadLine();

        }
    }
}
