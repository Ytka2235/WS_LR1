internal class Program
{
    private static void Main(string[] args)
    {
        double N = Convert.ToDouble(Console.ReadLine());
        double x = Convert.ToDouble(Console.ReadLine());
        double result = 0;
        for(double i = 0;i<=N;i++)
        {
            result += (Math.Pow(-1, i) * Math.Pow(x,2*i)) / factorial(i);
            Console.WriteLine(result);
        }
        Console.WriteLine(result);
    }
    static double factorial(double x)
    {
        double result = 1;
        for(int i = 1;i<=x; i++)
        {
            result *= i;
        }
        return result;
    }
}