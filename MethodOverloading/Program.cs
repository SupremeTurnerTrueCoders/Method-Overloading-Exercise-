namespace MethodOverloading
{
    public class Program
    {
        public static int add(int a, int b)
        {
            return a + b;
        }
        public static Decimal Add(Decimal a, Decimal b)
        {



            return a + b;



        }
        public static string Add(int a, int b, bool withDollars)
        {
            if (withDollars && (a + b) != 1)
            {
                return $"{a + b} dollars";
            }
            else if (withDollars && (a + b) == 1)
            {
                return $"{a + b} dollars";
            }
            else
            {
                return $"{a + b}";
            }

        }
    }
}
