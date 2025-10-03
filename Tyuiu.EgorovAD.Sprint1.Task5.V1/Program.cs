using Tyuiu.EgorovAD.Sprint1.Task5.V1.Lib;
namespace Tyuiu.EgorovAD.Sprint1.Task5.V1
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
            double x1, y1, x2, y2;
            Console.WriteLine("Введите x1:");
            x1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите y1:");
            y1 = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Введите x2:");
            x2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите y2:");
            y2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Результат:                                                              *");
            Console.WriteLine("***************************************************************************");
            int res = Convert.ToInt32(ds.DistanceBetweenDots(x1, y1, x2, y2));
            Console.WriteLine(res);
            Console.ReadLine();
        }
    }
}
