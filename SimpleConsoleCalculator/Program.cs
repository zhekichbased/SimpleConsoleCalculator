


using System;


namespace Program
{


    public class Calculator
    {


        static void Main()
        {

            bool loop = true;

            do
            {
                try
                {
                    Console.WriteLine("This is simple calculator, please enter numbers and operator + - / *");
                    Console.Write("Enter first number : ");
                    int firstInput = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter operator : ");

                    string mathOperator = Convert.ToString(Console.ReadLine());



                    string[] arguments = { "+", "-", "*", "/" };

                    if (Array.IndexOf(arguments, mathOperator) == -1)
                    {
                        Console.WriteLine("Use operators + - / * ");
                        continue;
                    }
                    Console.Write("Enter second number : ");
                    int secondInput = Convert.ToInt32(Console.ReadLine());

                    if (mathOperator == "+")
                    {
                        Console.WriteLine($"The result is : {firstInput + secondInput}");
                    }
                    else if (mathOperator == "-")
                    {
                        Console.WriteLine($"The result is : {firstInput - secondInput}");
                    }
                    else if (mathOperator == "/")
                    {
                        Console.WriteLine($"The result is : {firstInput / secondInput}");
                    }
                    else if (mathOperator == "*")
                    {
                        Console.WriteLine($"The result is : {firstInput * secondInput}");
                    }
                }

                catch (Exception e)
                {
                    Console.WriteLine("Please write numbers");
                }
            } while (loop);



        }



    }



}
