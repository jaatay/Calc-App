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
            public static double SecondNumber;
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

        //get user input for first number
        private static void UserNumber(){
            Console.WriteLine("Please type a number.");
            GlobalNumbers.FirstNumber = Double.Parse(Console.ReadLine());
            Console.WriteLine(GlobalNumbers.FirstNumber);

            if (GlobalNumbers.TotalNumber == 0)
            {
                GlobalNumbers.TotalNumber = GlobalNumbers.FirstNumber;
            }
       
        
            }

        //select a operation number
        private static void NumberOperation()
        {
            string UserOperationChoice = "";

            Console.WriteLine($"Your current total is {GlobalNumbers.TotalNumber}");
            Console.WriteLine("Choose a operation to perform:");
            Console.WriteLine("1:Add  2:Subtract  3:Multiply  4:Divide  5:Clear number  6: Quit");
            int UserInput = Int32.Parse(Console.ReadLine());
            if (UserInput == 1)
            {
                UserOperationChoice = "add";
            } else if (UserInput == 2)
            {
                UserOperationChoice = "subtract";
            } else if (UserInput == 3)
            {
                UserOperationChoice = "multiply";
            } else if (UserInput == 4)
            {
                UserOperationChoice = "divide";
            } else if (UserInput == 5)
            {
                GlobalNumbers.TotalNumber = 0;
            } else if (UserInput == 6)
            {
                ExitProgram.LeaveProgram = true;
            }

        }
       
}
}
