using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.EgorovAD.Sprint1.Task7.V15.Lib
{
    public class DataService : ISprint1Task7V15
    {
        public double Calculate(double x)
        {
            double result = Math.Abs((Math.Pow(x, 2)) - (Math.Pow(x, 3)));
            double rus = (Math.Cos(Math.Pow(x, 3)) + (7 * Math.Pow(x, 2))) ;
            double vin = Math.Pow(x, 3) - 15 * x;
            return  Math.Round((result) - (rus/ vin), 3);
        }
    }
}
