/*
 * FILE NAME: arithmeticProgram.cs
 * PROJECT NAME: Arithmetic Program
 * DATE INITIATLIZED: 09 August 2018
 * DESCRIPTION: A C# program designed to calculate an arithmetic equation of three variables based on the user's input
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class arithmeticProgram
{
    public static void Main()
    {

        int opType;
        double num1, num2, num3, result;

        Console.Write("What type of arithmetic operation would you like to execute?");
        Console.Write("\n1. Addition \n2. Subtraction \n3. Multiplication  \n4. Division\n");
        opType = Convert.ToInt32(Console.ReadLine());

        Console.Write("Input the first number: ");
        num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Input the second number: ");
        num2 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Input the third number: ");
        num3 = Convert.ToInt32(Console.ReadLine());

        if(opType == 1)
        {
             result = num1 + num2 + num3;
            Console.WriteLine("Output: " + result);
            Console.ReadKey();
        }

        else if (opType == 2)
        {
             result = num1 - num2 - num3;
            Console.WriteLine("Output: " + result);
            Console.ReadKey();
        }

        else if (opType == 3)
        {
             result = num1 * num2 * num3;
            Console.WriteLine("Output: " + result);
            Console.ReadKey();
        }

        else if (opType == 4)
        {
             result = num1 / num2 / num3;
            Console.WriteLine("Output: " + result);
            Console.ReadKey();
        }
        
        else 
        {
          Console.WriteLine("Incorrect option inputted;
        }
       
    }
}
