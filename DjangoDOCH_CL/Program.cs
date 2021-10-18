using System;

namespace ConsoleApp2
{
    class Mains
    {
        static void Main(string[] args)
        {
            Loh x1 = new Loh();
            Loh.Checker();
            Lohnessie y1 = new Lohnessie();
            Lohnessie.Ruler();
            Loshok z1 = new Loshok();
            Loshok.Writer();
            
            
        }
    }
    class Employee
    {
        public static void Checker()
        {
            Console.Write("Ахмат-....?  : ");
            string a1 = Console.ReadLine();
            if  (a1.ToLower() == "сила")
                {
                Console.WriteLine("Ахмат Сила!");
            }
            else 
                {
                     Console.WriteLine($"Ты че это такое ляпнул? Что еще за \"{a1}\" ? Тебе самому не стыдно? Д1авигал иза массаж е цуна "); 
                }
                      
            Console.ReadKey();
            Console.WriteLine();
        }
        public static void Ruler()
        {
            Console.WriteLine("Мы тут рулим");
            Console.ReadKey();
            Console.WriteLine();
        }
        public static void Writer()
        {
            Console.Write("Напиши 2 :  ");
            Console.ReadLine();
            Console.Write("Напиши 2 еще раз :  ");
            Console.ReadLine();
            Console.Write("Спасибо, что отдали ваш голос за Единую Россию!");
            Console.ReadKey();
            Console.WriteLine();
        }

    }
    class Loh : Employee
    {

    }
    class Lohnessie : Employee
    {

    }
    class Loshok : Employee
    {

    }
}