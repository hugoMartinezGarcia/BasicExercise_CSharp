/* Program that calculates how many numbers of 1, 2, 3 or more digits are 
 * entered by the user until he/she types "end".
 * 
 * (c) Hugo Martinez
 */

using System;

class Digits
{
    static void Main()
    {
        int a = 0, b = 0, c = 0, d = 0;

        Console.Write("Insert a number: ");
        string e = Console.ReadLine();

        while(e!="end")
        {
            int input = Convert.ToInt32(e);
       
            if(input != 0)
            {
                if(input/10 == 0)
                    a ++;
                else if (input/100 == 0)
                    b ++;
                else if (input/1000 == 0)
                    c ++;  // the number has 3 digits
                else
                    d++;  // the number has more than 3 digits
            }
            e = Console.ReadLine();
        }
        Console.WriteLine("one: {0} two: {1} three: {2} more: {3}", a, b, c, d); 
    }
}
