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
            // Step 3.1: Declare and initialize variables
            string userName; // Variable to Store the user's name
            int useAge; // Variable to store the user's age
            double productprice; // Variable to store the products price
            bool isStudent; // Variable to store if the user is a student (true/false)

            //Prompt the user to enter their name
            Console.Write("Enter your name: ");
            userName = Console.ReadLine(); // Read and assign the user's input to username

            // Prompt the user to enter their age
            Console.Write("enter your age: ");
            useAge = int.Parse(Console.ReadLine()); // Convert and assign the user's input to userAge

            // Prompt the user to enter the product price
            Console.Write("Enter the price of the product: ");
            productprice = double.Parse(Console.ReadLine()); // Convert and assign the user's input to productPrice

            // Prompt the user to indicate if they are a student
            Console.Write("Are you a student? (true/false)");
            isStudent = bool.Parse(Console.ReadLine()); // Convert and assign the user's input to isstudent

            // Step 3.2: Perform calculations
            int futureAge = useAge + 5; // Calcultae the user's age in 5 years
            bool isAdult = useAge >= 18; // Determine if the user is 18 or older
            bool isAdultStudent = isStudent && isAdult; // Determine if the user is both a student and an adult

            // Step 3.3: Display outputs using string interpolation 
            Console.WriteLine($"\nHello, {userName}!"); // Greet the user with their name
            Console.WriteLine($"You are currently {useAge} years old. In 5 years, you will be {futureAge}."); // Display current and future age
            Console.WriteLine($"Are you 18 or older? {isAdult}"); // Display if the user is 18 or older
            Console.WriteLine($"Are you both a Student and 18 or older? {isAdultStudent}"); // Display if the user is both a student and an adult
            
        }
    }
}
