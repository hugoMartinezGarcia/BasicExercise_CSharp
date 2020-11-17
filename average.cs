/* Program that calculates the average of a set of marks, until the user types
 * "end".
 * 
 * (C) Hugo Martinez
 */
 
using System;

public class Average
{
    public static void Main()
    {
        double sum = 0, number,  numberCount = 0, average;
        string numberText;
    
        Console.Write("Insert a mark: ");
        numberText = Console.ReadLine(); 
        
        while(numberText != "end")
        { 
            number = Convert.ToDouble(numberText);
            numberCount++;   
            sum += number;
    
            Console.Write("Insert a mark: ");
            numberText = Console.ReadLine();
        }
    
        if(numberCount != 0)
        {
            average = sum / numberCount;
            Console.WriteLine("The average is {0}.", average);
        }
    }
}
