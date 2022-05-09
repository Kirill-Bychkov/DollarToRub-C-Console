using System;

namespace MyFirstGit
{
    class Program
    {
        static void Main(string[] args)
        {
            double rub, sum;
            const double kurs_dollar = 70;

            Console.WriteLine("Введите кол-во $: ");

            rub = double.Parse(Console.ReadLine());

            sum = rub * kurs_dollar;

            Console.WriteLine("$" + rub + " = " + sum);
            
            Console.ReadLine();
  
        }
    }
}
