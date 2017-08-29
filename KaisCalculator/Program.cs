using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaisCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hello");
            string input1;
            string input2;
            string input3;
            double solution1 = 0;
            double number1 = 0;
            double number2 = 0;
            bool error = false;

            while (true)
            {
                error = false;



                Console.WriteLine("input the first number");
                input1 = Console.ReadLine();
                Console.WriteLine("this is the first number " + input1);
                if (input1.Length > 15)
                {
                    Console.WriteLine("insufficient number ");
                    error = true;
                

                }
                if (error == false)
                {



                    Console.WriteLine("input the second number");
                    input2 = Console.ReadLine();
                    Console.WriteLine("this is the second number " + input2);

                 if (input2.Length > 15)
                    {
                        Console.WriteLine("insufficient number ");
                        error = true;
                    }
                    if (error == false)
                    {



                        Console.WriteLine("the numbers you entered are " + input1 + "and " + input2);
                        Console.WriteLine("would you like to add,subtract,divide or multiply");
                        input3 = Console.ReadLine();




                        try
                        {

                            number1 = double.Parse(input1);
                            number2 = double.Parse(input2);
                        }
                        catch (FormatException fe)
                        {
                            error = true;
                            Console.WriteLine("an error has occured");


                        }






                        switch (input3)
                        {
                            case "+":
                            case "add":
                                solution1 = number1 + number2;
                                break;
                            case "-":
                            case "subtract":
                                solution1 = number1 - number2;
                                break;
                            case "/":
                            case "divide":
                                solution1 = number1 / number2;
                                break;
                            case "*":
                            case "multiply":
                                solution1 = number1 * number2;
                                break;
                            case "^":
                                solution1 = 1;
                                for (int i = 0; i < number2; i = i + 1)
                                {
                                    solution1 = number1 * solution1;
                                }
                                break;

                            default:
                                error = true;
                                break;






                        }
                        if (error == false)
                        {
                            Console.WriteLine("the answer is" + solution1);
                        }
                    }
                }
            }
           
           
           
           
           
           //Keeps the window open
             Console.ReadKey();
        }
    }
}
