namespace mainF
{
    class Mainf
    { 
        public static void Main(string[] args)
        {
            Console.WriteLine(practic.A.Sum(5, 10));
            practic.A.Greet("Иван"); 
            Console.WriteLine(practic.A.Max(15, 20)); 
            Console.WriteLine(practic.A.isPositive(22));
            Console.WriteLine(practic.A.CelsiusToFahrenheit(25)); 
            Console.WriteLine(practic.A.ReverseString("Hello")); 
            Console.WriteLine(practic.A.CountSymbol("Hello World"));
            Console.WriteLine(practic.A.Factorial(5));
            Console.WriteLine(practic.A.IsPrime(7)); 
            Console.WriteLine(practic.A.GenerateRandomNumber(1, 10));
            Console.WriteLine(practic.A.isPositive(22));


        }
    
    }



}



namespace practic
{
    class A
    {
        public static int Sum(int num1, int num2)
        {
            return num1 + num2;
        }
        public static void Greet(string name)
        {
            Console.WriteLine($"Привет, {name}!");
        }
        public static int Max(int num1, int num2)
        {
            return num1 > num2 ? num1 : num2;
        }
        public static Predicate<int> isPositive = (int number) =>  number % 2 == 0;

        public static double CelsiusToFahrenheit(double celsius)
        {
            return (celsius * 9 / 5) + 32;
        }
        public static string ReverseString(string str)
        {
            return new string(str.ToCharArray().Reverse().ToArray());
        }
        public static int CountSymbol(string str)
        {
            int count = 0;
            foreach (char c in str)
            {
                    count++;
            }
            return count;
        }
        public static int Factorial(int n)
        {
            if (n == 1) return 1;

            return n * Factorial(n - 1);
        }
        public static bool IsPrime(int number)
        {
            bool prost = true;
            Console.WriteLine("Введите число\n");
            int n = number;
            for (int i = 2; i <= n / 2; i++)
            {
                if (n % i == 0)
                {
                    prost = false;
                    break;
                }
            }
            return prost;
        }
        public static int GenerateRandomNumber(int min, int max)
        {
            Random rnd = new Random();
            return rnd.Next(min, max + 1);
        }
        class B
        { 
            
        
        }







    }















}