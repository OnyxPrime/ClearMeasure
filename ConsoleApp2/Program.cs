namespace ConsoleApp2
{
    using ClassLibrary1;
    internal class Program
    {
        static void Main(string[] args)
        {
            List<(int, string)> modulators = new List<(int, string)> {
                (3, "Ryan"),
                (5, "Overton")
            };

            var results = Class1.GetNumbers(50000000, modulators.ToArray());
            foreach (var result in results)
            {
                Console.WriteLine(result);
            }
        }
    }
}
