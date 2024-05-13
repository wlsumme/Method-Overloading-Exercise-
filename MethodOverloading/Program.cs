using System.Security;

namespace MethodOverloading
{
    public class Program
    {
        static void Main(string[] args)
        {
            var intAdd = Add(4, 6);
            Console.WriteLine(intAdd);

            var decimalAdd = Add(7.89m, 8.58m);
            Console.WriteLine(decimalAdd);

            var boolAdd = Add(0, 1, true);
            Console.WriteLine(boolAdd);

            var boolAddDollars = Add(8, 1, true);
            Console.WriteLine(boolAddDollars);

            var boolAddFalse = Add(0, 1, false);
            Console.WriteLine(boolAddFalse);
        }

        public static int Add(int a, int b)
        {
            return a + b;

        }

        public static decimal Add(decimal a, decimal b)
        {
            return a + b;
        }

        public static string Add(int a, int b, bool c)
        {
           var sum = a + b;

           if(c && sum > 1)
            {
                return $"{sum} dollars";
            }
        
            else if(c && sum == 1)
            {
                return $"{sum} dollar";
            }
            else
            {
                return sum.ToString();
            }

        }
    }
}
