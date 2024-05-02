using calculator_nuget.Contracts;

namespace calculator_nuget
{
    public class Calcuator : ICalculator
    {
        public int Add(int x, int y)
        {
            return x + y;
        }
    }
}
