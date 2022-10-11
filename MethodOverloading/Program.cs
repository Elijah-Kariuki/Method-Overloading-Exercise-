using System.ComponentModel;

namespace MethodOverloading
{
    internal class Program
    {
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
            int sum = a + b;
            if (c == true)
            {

                if (sum > 1)
                {
                    return $"The sum is {sum} dollars";
                }
                else
                    return $"The sum is {sum} dollar";
            }
            return $"The sum of {a} plus {b} is {sum}";

        }   
        static void Main(string[] args)
        {
            Console.WriteLine(Add(32.0m, .7m));
        }
        
    }
}