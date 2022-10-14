namespace Making_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(MyMethods.Reverse("Hello World!"));
            List<double> list = new List<double>() { 3.0,5,4,};
            foreach (double i in list)
            {
                Console.Write($"{i}, ");
            }
            Console.WriteLine();
            Console.WriteLine(MyMethods.Average(list));
        }
    }
}