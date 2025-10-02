using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.EgorovAD.Sprint1.Task2.V10.Lib
{
    public class DataService : ISprint1Task2V10
    {
        public double ConvertMetreToInchs(int value)
        {
            
            double numder = (value * 39.3700787402)+0.001;
            return Math.Round(numder,3);
        }
    }
}
