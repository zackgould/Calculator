using System;

public class Hello1
{
    public static void Main(string[] args)
    {
        //Welcome
        Console.WriteLine("Welcome to My Calculator");
        Console.WriteLine();
        //Define variables
        string firstNumber ="", secondNumber="", operation = "", myChoice;
        double firstNum;
        bool success = false;
        
        do
        {
        
        //Enter first number
            while (success == false)
            {
                Console.WriteLine("Enter first number: ");
                firstNumber = (Console.ReadLine());
                success = double.TryParse(firstNumber, out firstNum);
            }
            success = false;
        
        //Enter operation
            while (success == false)
            {
                Console.WriteLine("Enter operation: ");
                operation = Console.ReadLine();
                if (operation != "*" && operation != "/" && operation != "+" && operation != "-" && operation != "^" &&
                    operation != "sqrt")
                {
                    success = false;
                }
                else
                {
                success = true;
                }
            }
            success = false;

         //Enter second number
            while (success == false)
            {
                Console.WriteLine("Enter second number: ");
                secondNumber = (Console.ReadLine());
                success = double.TryParse(secondNumber, out firstNum);

            }
            
        //Create instance
        Hello1 calc = new Hello1();

        //Compute
        string one = calc.calculation(firstNumber, operation, secondNumber);

        Console.WriteLine("{0} {1} {2} = {3}", firstNumber, operation, secondNumber, one);

        Console.WriteLine("Press enter to continue or 'q' to quit");
        myChoice = Console.ReadLine();

        } while (myChoice != "q" && myChoice != "Q");

        //Keep console open
        Console.ReadLine();
    }

    string calculation(string firstNumber, string operation, string secondNumber)
    {

            double firstNumb = double.Parse(firstNumber);
            double secondNumb = double.Parse(secondNumber);



            switch (operation)
            {
                case "*":
                    return (firstNumb*secondNumb).ToString();
                    //break;

                case "/":
                    return (firstNumb/secondNumb).ToString();
                    //break;

                case "+":
                    return (firstNumb + secondNumb).ToString();
                    //break;

                case "-":
                    return (firstNumb - secondNumb).ToString();
                    //break;

                case "^":
                    return (Math.Pow(firstNumb, secondNumb)).ToString();

                case "sqrt":
                    return (firstNumb*(Math.Sqrt(secondNumb))).ToString();

                default:
                    return "Invalid Operation!";
            }


        }


    }
