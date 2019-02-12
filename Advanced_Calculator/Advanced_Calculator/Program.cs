using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string choice;
     
            Console.WriteLine("What would you like to calculate? Maths or Shapes?");
            choice = Console.ReadLine();

            if (choice == "Maths")
            {
                int firstNumber = 0;
                int secondNumber = 0;
                float answer = 0.0f;
                string numoperation;

                Console.WriteLine("Enter the operator (+,-,/,* or %)");
                numoperation = Console.ReadLine();

                Console.WriteLine("Enter first number");
                firstNumber = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter second number");
                secondNumber = Convert.ToInt32(Console.ReadLine());

                switch (numoperation)
                {
                    case "+":
                        answer = firstNumber + secondNumber;
                        break;
                    case "-":
                        answer = firstNumber - secondNumber;
                        break;
                    case "*":
                        answer = firstNumber * secondNumber;
                        break;
                    case "/":
                        answer = firstNumber / secondNumber;
                        break;
                    case "%":
                        answer = firstNumber % secondNumber;
                        break;
                    default:

                        Console.WriteLine("This calculator does not understand this function");
                        break;
                }
                Console.WriteLine(firstNumber + " " + numoperation + " " + secondNumber + " = " + answer);
                Console.ReadLine();
            }

            else
            {
                string shapechoice;
                Console.WriteLine("What shape would you like to calculate? Trianle, Square or Rectangle");
                shapechoice = Console.ReadLine();

                if (shapechoice == "triangle")
                {
                    Console.WriteLine("Enter base");
                    double base1 = double.Parse(Console.ReadLine());

                    Console.WriteLine("Enter height");
                    double height1 = double.Parse(Console.ReadLine());

                    double areat = (0.5*base1 * height1);
                    Console.WriteLine(areat);
                    Console.Read();


                }
                else if (shapechoice == "square")
                {
                    Console.WriteLine("Enter base");
                    double base1 = double.Parse(Console.ReadLine());

                    Console.WriteLine("Enter height");
                    double height1 = double.Parse(Console.ReadLine());

                    double areas = (base1 * height1);
                    Console.WriteLine(areas);
                    Console.Read();
                }
                else
                {
                    Console.WriteLine("Enter base");
                    double base1 = double.Parse(Console.ReadLine());

                    Console.WriteLine("Enter height");
                    double height1 = double.Parse(Console.ReadLine());

                    double arear = (base1 * height1);
                    Console.WriteLine(arear);
                    Console.Read();
                }
            }
                
               
            
                

            



             
            
                
          

                 
          




                        
                
                
         
        }
    }
}
