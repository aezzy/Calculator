using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A simple handy calculator");
            bool isAlive = true;
            while (isAlive)
            {

                int a, b;
                int choice;
                double result;
                string userInput = "";
                Console.WriteLine("enter first number");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter second number");
            b = Convert.ToInt32(Console.ReadLine());

           

            Console.WriteLine("---Menu----");
            Console.WriteLine("Please choose from 1-4");
            Console.WriteLine("1: Addittion");
            Console.WriteLine("2: Substraction");
            Console.WriteLine("3: Multiplication");
            Console.WriteLine("4: Division");

            Console.WriteLine();

         choice = Int32.Parse(Console.ReadLine());
          

                switch (choice)
            {
                case 1: 
                    result = GetAddition(a, b);
                    
                        Console.WriteLine(a.ToString() + " " + "+" + " " + b.ToString() + " = " +  result.ToString());


                        break;

                case 2:
                    result = GetSubstraction(a, b);
                    
                        Console.WriteLine( a.ToString() + " " + "-" + " " + b.ToString() + " = " + result.ToString());
                        break;

                case 3:
                    result = GetMultiplication(a, b);
                        
                        Console.WriteLine(a.ToString() + " " + "*" + " " +  b.ToString() + " = "  + result.ToString());
                        break;

                case 4:
                    result = GetDivision(a, b);
                       
                        Console.WriteLine( a.ToString() + " " + "/" + " " +  b.ToString() + " = " + result.ToString());
                        break;

                    default:
                        
                        userInput = Console.ReadLine();

                        if (userInput == "Q" || userInput == "q")
                        {
                            
                            isAlive = false;
                            
                        }

                        
                        break;
            }

                //    Console.ReadKey();
                
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("continue");
                Console.WriteLine();
            }
        }

        //Addition 
        static int GetAddition(int a, int b)
        {
            int result;
            result = a + b;
            return result;
        }

        //Substraction 
        static int GetSubstraction(int a, int b)
        {
            int result;
            result = a - b;
            return result;
        }

        //Multiplication
        static int GetMultiplication(int a, int b)
        {
            int result;
            result = a * b;
            return result;
        }

        // Division
       static double GetDivision(int a, int b)
        {
            double result;
            result = a / b;
            return result;
        }
    }
}
