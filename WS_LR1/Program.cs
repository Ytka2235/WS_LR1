internal class Program
{
    private static void Main(string[] args)
    {
        double N = Convert.ToDouble(Console.ReadLine());
        double x = Convert.ToDouble(Console.ReadLine());
        double result = -(Math.PI/2);
        for(int i = 0;i<=N;i++)
        {
            result += (Math.Pow(-1, i + 1)) / ((2 * i + 1) * Math.Pow(x, 2 * i + 1));
        }
        Console.WriteLine(result);
    }
}