using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program.cs
{
    class DayOneProgram
    {
        static void Main(string[] args)
        {
            //Creates program variables
            string name;
            string space;
            int userAge;
            int numberOne;
            int numberTwo;
            int finalNumber;

            //Writes to the screen
            Console.WriteLine("Hello World!!!!!");
            Console.WriteLine("What is your name?");

            //defines value for string variables
            name = Console.ReadLine();
            space = " ";

            //prints out greeting and "name"
            Console.WriteLine("Hello" + space +name+".");

            //Writes to screen asking user how old they are
            Console.WriteLine("How old are you?");

            /*defines value for userAge from user keyboard input and
            changes inputed value from string to int*/
            userAge = int.Parse(Console.ReadLine());
            Console.WriteLine("Thank you. You are" + space + userAge);

            //asks user for two numbers
            Console.WriteLine("Lets do some Addition");
            
            /*defines value of numberOne and numberTwo from user keyboard input 
              and changes the inputed values from string to int*/
            Console.WriteLine("What is the first number you want to be added?");
            numberOne = int.Parse(Console.ReadLine());

            Console.WriteLine("What is the second number you want to be added?");
            numberTwo = int.Parse(Console.ReadLine());
            
            //Adds the inputed numbers and applies that value to ne variable finalNumber
            finalNumber = numberOne + numberTwo;                                        

            //writes answer to addition problem above
            Console.WriteLine("Your answer is" + space + finalNumber);
            Console.WriteLine("Thank You and Good Bye");
            Console.WriteLine("Press any key to exit program");

            //pause program untill a key is pressed
            Console.ReadKey();
        }
    }
}
