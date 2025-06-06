namespace MathsLib
{
    public class Math
    {
        public int Sum(int a, int b)
        {
            return a + b;
        }
        public int Subtract(int a, int b)
        {
            return a - b;
        }
        public int Multiply(int a, int b)
        {
            return a * b;
        }
        public double Divide(int a, int b)
        {
            if(b == 0)
            {
                Console.WriteLine("second number is not valid");
            }
            return (double) a / b;
        }
    }
}
