using System;

namespace Calc_App
{
    class Program
    {

        double selectedNumber;

        static void Main(string[] args)
        {
            FirstScreen();
            
        }
        //methods
        public FirstScreen(number){
            Console.WriteLine("Select a number");
           double number = Int32.Parse(Console.ReadLine());
            Console.WriteLine(selectedNumber);
            return number;
            }
        
}
}
