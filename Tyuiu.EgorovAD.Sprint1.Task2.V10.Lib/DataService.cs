using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.EgorovAD.Sprint1.Task2.V10.Lib
{
    public class DataService : ISprint1Task2V10
    {
        public double ConvertMetreToInchs(int value)
        {
            // перевод
            return Math.Round(value * 39.37, 3);
        }
    }
}
