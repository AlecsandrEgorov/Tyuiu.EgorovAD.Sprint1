using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.EgorovAD.Sprint1.Task6.V18.Lib
{
    public class DataService : ISprint1Task6V18
    {
        public bool CheckNumber(string value)
        {
            foreach (char c in value)
            {
                if (!char.IsDigit(c))
                    return false;
            }
            return true;
        }
    }
}
