namespace MethodOverloading
{
    public class Program
    {
        static void Main(string[] args)
        {
            var add1 = Methods.Add(1, 2); 
            Console.WriteLine(add1);


            var add2 = Methods.Add(4.5m, 2.5m);
            Console.WriteLine(add2);

            var add3 = Methods.Add(1 , 5 ,true);
            Console.WriteLine(add3);
        }

        
    }
}
