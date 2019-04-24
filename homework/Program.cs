using System;


namespace homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Student person = new Student();
            Console.WriteLine("Please, enter your name");
            string name = Console.ReadLine();
            Console.WriteLine("Please, enter your surname");
            string surname =  Console.ReadLine();
            Console.WriteLine("Please, enter your group number");
            string group =  Console.ReadLine();
            Console.WriteLine($"Salam {name} {surname}. Sizin qrupunuz: {group}");
            Console.ReadLine();
        }
    }
     



    class Group
    {
        string _Name;
    }
    class Student
    {
        string _Name;
        string _Surname;
        string _Group;

    }

   
    
}
