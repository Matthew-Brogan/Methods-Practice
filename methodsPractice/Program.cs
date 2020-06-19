using System;
using System.Globalization;

namespace methodsPractice
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("how many numbers would you like to input?");
            int userAmount = int.Parse(Console.ReadLine());
            int[] number = new int[userAmount];

            for(int i = 0; i < userAmount; i++)
            {
                Console.WriteLine("Enter a Number");
                int userNumber = int.Parse(Console.ReadLine());
                number[i] = userNumber;
            }

            int total = Sum(number);
            Console.WriteLine(total);

            Console.WriteLine("Whats your name?");
            string name = Console.ReadLine();
            Console.WriteLine("How old are you?");
            string age = Console.ReadLine();
            Console.WriteLine("Whats your favorite animal?");
            string animal = Console.ReadLine();




            var message = MyMessage(name, age, animal);

            Console.WriteLine(message);


            var addition = MySum(3, 5);
            var multiply = MyMult(5, 5);
            Console.WriteLine(addition);
            Console.WriteLine(multiply);
        }

        public static void MyMethod(string text)
        {
            Console.WriteLine(text);
        }
        public static string MyMessage(string name, string age, string animal)
        {
            return $"Hello {name}, how does it feel to be {age}? I heard your favorite animal is {animal}! I love dogs myself, although their fur tends to mess up my fans!!!";
        }
        public static int MySum(int x, int y)
        {
            int sum = x + y;
            return sum;
        }
        public static int MyMult(int i, int j)
        {
            int mult = i * j;
            return mult;
        }
        public static int Sum(params int[] args)
        {
            int sum = 0;

            foreach (int num in args)
            {
                sum += num;
            }
            return sum;
        }
       


    }
}
