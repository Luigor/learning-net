using System;

namespace Week2Lesson4
{
    public class Program
    {
        public static void Main(string[] args)
        {
        }

        /*
         * Create a program in which you declare variables related to the company's employee data. Data
         * you want to keep are:
         * a. Name,
         * b. Surname
         * c. Age
         * d. Gender ('m' or 'k')
         * e. PESEL
         * f. Employee number (e.g. 2509324094)
         * Declare variables of the appropriate types that can hold this information
        */
        public static void Task1()
        {
            string firstName;
            string lastName;
            byte age;
            Gender gender;
            int pesel;
            uint id;
        }

        /* 
         * Write a program in which you create 3 variables with one letter, and then write them in
         * reverse order than declared.
        */
        public static void Task2()
        {
            char a = 'a';
            char b = 'b';
            char c = 'c';

            Console.WriteLine($"{c}, {b}, {a}");
        }

        /* 
         * Write a program that will calculate the length based on the given width and length of the rectangle
         * diagonal. (To calculate the square of a number use the Math.Sqrt () method)
        */
        public static void Task3()
        {
            double length;
            double width;

            Console.WriteLine("Set length:");
            length = double.Parse(Console.ReadLine());
            Console.WriteLine("Set width:");
            width = double.Parse(Console.ReadLine());

            Console.WriteLine($"{Math.Sqrt(Math.Pow(length, 2) + Math.Pow(width, 2))}");
        }

        /* 
         * Write a program where you create 2 numeric variables and one text variable, and then
         * you assign them the following values:
         * a. 10
         * b. Dotnet School
         * c. 12.5
         * Remember to use the correct data types.
        */
        public static void Task4()
        {
            int numberOne = 10;
            double numberTwo = 12.5;
            string text = "Szkoła Dotneta";

            Console.WriteLine($"{numberOne}, {text}, {numberTwo}");
        }

        /* 
         * Write a program in which you will ask the user for his personal data, i.e. name, surname,
         * phone number, email address, height, weight (e.g. 85.7), etc. (try to come up with as many as possible)
         * and try to convert the answer to the appropriate data type using the method:
         * typDanych.Parse ().
        */
        public static void Task5()
        {
            string firstName;
            string lastName;
            byte age;
            string email;
            double height;
            double weight;
            int phone;

            Console.WriteLine("Set first name:");
            firstName = Console.ReadLine();
            Console.WriteLine("Set last name:");
            lastName = Console.ReadLine();
            Console.WriteLine("Set age:");
            Byte.TryParse(Console.ReadLine(), out age);
            Console.WriteLine("Set email:");
            email = Console.ReadLine();
            Console.WriteLine("Set height (cm):");
            Double.TryParse(Console.ReadLine(), out height);
            Console.WriteLine("Set weight (kg):");
            Double.TryParse(Console.ReadLine(), out weight);
            Console.WriteLine("Set phone number:");
            int.TryParse(Console.ReadLine(), out phone);
        }

    }

    enum Gender
    {
        m,
        f
    }
}