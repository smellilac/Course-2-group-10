**1. Простой калькулятор:**
Создайте калькулятор, который принимает два числа от пользователя, сохраняет их в переменных, складывает их и выводит результат.

**2. Игра угадай число:**
Загадайте случайное число в переменной и попросите пользователя угадать это число, предоставляя подсказки (больше/меньше).

*Для каждого упражнения создай отдельное консольное приложние*







namespace c
{
    internal class Program
    {
        static void Main(string[] args)
        {
            B();
            
        }
        static void A()
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(a + b);
        }
        static void B()
        {
            Random numb = new Random();
            int numbR = numb.Next(1,5);
            Console.WriteLine("Введите число");
            int numbEnd = Convert.ToInt32(Console.ReadLine());
            while (numbEnd != numbR)
            {
                if (numbEnd == numbR)
                {
                    break;
                }
                else if (numbEnd > numbR)
                {
                    Console.WriteLine("Число меньше");
                     numbEnd = Convert.ToInt32(Console.ReadLine());
                }
                else if (numbEnd < numbR)
                {
                    Console.WriteLine("Число больше");
                    numbEnd = Convert.ToInt32(Console.ReadLine());
                }

            }
            Console.WriteLine("Вы угадали");
        }

    }
    
}
