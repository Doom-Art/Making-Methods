namespace Making_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Double perimeter = 3 + 4 + MyMethods.GetHypotenuse(3, 4);
            Console.WriteLine($"The perimeter is { perimeter } cm");
            Console.WriteLine(MyMethods.GetHypotenuse(3, 4));
            Console.WriteLine(MyMethods.GetLeg(5,4));
        }
    }
}