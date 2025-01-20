/*
 Author: James Limos
 Course: COMP-003A
 Faculty: Jonathan Cruz
 Purpose: A program demonstrating statements, variables, and operators.
*/
// Namespace level
namespace ConsoleApp2
{
    internal class Program
    {
        //main level
        static void Main(string[] args)
        {
            string userName;
            int useAge;
            double productprice;
            bool isStudent;

            Console.Write("Enter your name: ");
            userName = Console.ReadLine();

            Console.Write("enter your age: ");
            useAge = int.Parse(Console.ReadLine());

            Console.Write("Enter the price of the product: ");
            productprice = double.Parse(Console.ReadLine());

            Console.Write("Are you a student? (true/false)");
            isStudent = bool.Parse(Console.ReadLine());

            int futureAge = useAge + 5;
            bool isAdult = useAge >= 18;
            bool isAdultStudent = isStudent && isAdult;

            Console.WriteLine($"\nHello, {userName}!");
            Console.WriteLine($"You are currently {useAge} years old. In 5 years, you will be {futureAge}.");
            Console.WriteLine($"Are you 18 or older? {isAdult}");
            Console.WriteLine($"Are you both a Student and 18 or older? {isAdultStudent}");
            
        }
    }
}
