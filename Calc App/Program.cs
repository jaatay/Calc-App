using System;

namespace Calc_App
{
    class Program
    {
        //GLOBAL NUMBERS TO TRACK
       static class GlobalNumbers
        {
            public static double TotalNumber = 0;
            public static double FirstNumber;
        }

            public static class ExitProgram
        {
            public static bool LeaveProgram = false;
        }

        //MAIN PROGRAM
        static void Main(string[] args)
        {
            WelcomeMessage();
            UserNumber();

            while (ExitProgram.LeaveProgram == false)
            {
               
                NumberOperation();
            }
        }

        //METHODS

        //welcome message
        private static void WelcomeMessage()
        {
            Console.WriteLine("Welcome to this Console Calculator! We hope you enjoy your stay!");

        }

        //method to get user's first number
        private static void UserNumber(){
            Console.WriteLine("Please type a number.");
            GlobalNumbers.FirstNumber = Double.Parse(Console.ReadLine());
            Console.WriteLine(GlobalNumbers.FirstNumber);

            if (GlobalNumbers.TotalNumber == 0)
            {
                GlobalNumbers.TotalNumber = GlobalNumbers.FirstNumber;
            }
         }

        //method to select an operation and call helper function
        private static void NumberOperation()
        {

            Console.WriteLine($"Your current total is {GlobalNumbers.TotalNumber}");
            Console.WriteLine("Choose a operation to perform:");
            Console.WriteLine("1:Add  2:Subtract  3:Multiply  4:Divide  5:Clear number  6: Quit");
            int UserInput = 0;

            try
            {
                UserInput = Int32.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input, please choose one of the provided options!");
            }


            if (UserInput == 1)
            {
                AddNumber();
            } else if (UserInput == 2)
            {
                SubtractNumber();
            } else if (UserInput == 3)
            {
                MultiplyNumber();
            } else if (UserInput == 4)
            {
                DivideNumber();
            } else if (UserInput == 5)
            {
                GlobalNumbers.TotalNumber = 0;
            } else if (UserInput == 6)
            {
                ExitProgram.LeaveProgram = true;
            }
        }

        //method to add numbers
        private static void AddNumber()
        {
            Console.WriteLine($"{GlobalNumbers.TotalNumber} + (type number to add to)");
            double NumberToAdd = Double.Parse(Console.ReadLine());
            GlobalNumbers.TotalNumber += NumberToAdd;
        }

        //method to subtract numbers
        private static void SubtractNumber()
        {
            Console.WriteLine($"{GlobalNumbers.TotalNumber} - (type number to subtract from)");
            double NumberToSubtract = Double.Parse(Console.ReadLine());
            GlobalNumbers.TotalNumber -= NumberToSubtract;
        }

        //method to multiply numbers
        private static void MultiplyNumber()
        {
            Console.WriteLine($"{GlobalNumbers.TotalNumber} x (type number to multiply by)");
            double NumberToMultiply = Double.Parse(Console.ReadLine());
            GlobalNumbers.TotalNumber *= NumberToMultiply;
        }

        //method to divide numbers
        private static void DivideNumber()
        {
            Console.WriteLine($"{GlobalNumbers.TotalNumber} x (type number to divide by. WARNING: NEVER DIVIDE BY 0!!!!");
            double NumberToDivide= Double.Parse(Console.ReadLine());
           if (NumberToDivide == 0)
            {
                Console.WriteLine("We told you not to divide by 0! In a galaxy far, far away, something important just exploded. In this one: try again.");
            
            } else
            {
                GlobalNumbers.TotalNumber /= NumberToDivide;
            }
           
        }

    }
}
