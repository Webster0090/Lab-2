using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            while (i == 0)
            {

                Console.WriteLine("Welcome to Grand Circus' Room Detail Generator");

                Console.WriteLine("Please Enter the Length of the Room");

                double length = double.Parse(Console.ReadLine());

                Console.WriteLine("Please enter the Width of the Room");

                double width = double.Parse(Console.ReadLine());

                Console.WriteLine("Area of Room: " + length * width);

                double perimeter = length * 2 + width * 2;

                Console.WriteLine("Perimeter of room: " + perimeter);

                Console.WriteLine("Would You Like to Run the Program Again? Please Enter Y or N");
                Console.WriteLine("If You Would Like to Calculate Volume, Press V");

               string loop = Console.ReadLine();
                if(loop == "N"||loop == "n")
                {
                    i = i + 1;

                }
                else if(loop == "V" || loop == "v")
                {
                    Console.WriteLine("Please Enter the Height of the Room");

                    double height = double.Parse(Console.ReadLine());

                    double volume = height * width * length;

                    Console.WriteLine("The Volume of the Room is " + volume);

                    Console.WriteLine("Would You Like to Run the Program Again? Please Press Y or N");

                    string loop2 = Console.ReadLine();

                    if(loop2 == "N" || loop2 == "n")

                    {
                        i = i + 1;
                    }
                    

                    
                }
            }
        }
    }
}