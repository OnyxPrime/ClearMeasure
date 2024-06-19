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
            var t1 = DateTime.Now;
            
            var q = Array.MaxLength;
            var z = new string[q];
            for (int i = 0; i < q; i++)
            {
                String x = "";
                var val = i + 1;
                if (val % 3 == 0)
                    x += "Ryan";
                
                if (val % 5 == 0)
                    x += "Overton";

                if (string.IsNullOrEmpty(x))
                    x += val.ToString();

                z[i] = x;
            }
            var t2 = DateTime.Now;
            var ts = t2 - t1;
            Console.WriteLine(ts.TotalSeconds);

            var results = Class1.GetNumbers(short.MaxValue, [(3, "Ryan"), (5, "Overton")]);
            foreach (var result in results)
            {
                Console.WriteLine(result);
            }
        }
    }
}
