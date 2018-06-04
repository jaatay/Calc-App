using System;

namespace Calc_App
{
    class Program
    {
        //global number to track through operations
       static class totalNumber
        {
            public static double number;
        }

        //main program to run
        static void Main(string[] args)
        {
            FirstScreen();
            Console.ReadLine();
            
        }
        //methods to use on total number
        private static void FirstScreen(){
            Console.WriteLine("Select a number");
           totalNumber.number = Int32.Parse(Console.ReadLine());
            Console.WriteLine(totalNumber.number);
        
            }
        
}
}
