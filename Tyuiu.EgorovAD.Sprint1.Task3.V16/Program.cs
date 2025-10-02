using Tyuiu.EgorovAD.Sprint1.Task3.V16.Lib;
namespace Tyuiu.EgorovAD.Sprint1.Task3.V16
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
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #16                                                             *");
            Console.WriteLine("* Выполнил: Егоров.А.Д. | СМАРТб25-1                                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Условие:                                                                *");
            Console.WriteLine("* Написать программу, которая вычисляет и печатает коэффициент            *");
            Console.WriteLine("* приведенного квадратного уравнения, корнями которого являются введенные *");
            Console.WriteLine("*  пользователем два вещественных числа (для справки: b=-x1-x2).          *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            double x1, x2;
            Console.WriteLine("Введите x1:");
            x1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите x2:");
            x2 = Convert.ToInt32(Console.ReadLine());



            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Результат:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(ds.CoeffOfQuadraticEquation(x1, x2));

            Console.ReadLine();
        }
    }
}
