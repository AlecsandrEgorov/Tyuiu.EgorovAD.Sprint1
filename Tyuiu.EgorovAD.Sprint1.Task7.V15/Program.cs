using Tyuiu.EgorovAD.Sprint1.Task7.V15.Lib;
namespace Tyuiu.EgorovAD.Sprint1.Task7.V15
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
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #15                                                             *");
            Console.WriteLine("* Выполнил: Егоров.А.Д. | СМАРТб25-1                                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Условие:                                                                *");
            Console.WriteLine("* Написать программу, которая вычисляет математическое выражение по       *");
            Console.WriteLine("* исходным значениям данных, вводимых пользователем                       *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("                         3          2");
            Console.WriteLine("       2    3       cos x    + 7 * x");
            Console.WriteLine("z = | x  - x |  - --------------------");
            Console.WriteLine("                    3            ");
            Console.WriteLine("                   x    -  15 * x ");

            double x;
            Console.WriteLine("Введите X:");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Результат:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(ds.Calculate(x));

            Console.ReadKey();
        }
    }
}
