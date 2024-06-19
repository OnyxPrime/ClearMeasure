namespace ConsoleApp2
{
    using ClassLibrary1;
    internal class Program
    {

        public class MyValue
        {
            public string Value { get; set; } = "";

            public  MyValue(string value)
            {
                Value = value;
            }

            public override string ToString()
            {
                return Value; 
            }
        }

        static void Main(string[] args)
        {
            var results = Class1.GetNumbers(short.MaxValue, [(3, "Ryan"), (5, "Overton")]);
            foreach (var result in results)
            {
                Console.WriteLine(result);
            }
        }
    }
}
