using System;

namespace Степень
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randomNumber = new Random();
            int startRandom = 2;
            int stopRandom = 1000;
            int numberRandom = randomNumber.Next(startRandom,stopRandom);
            int setNumber = 2;

            Console.WriteLine("рандом числ - "+numberRandom);
            
            int degreeNumber = 1;
            int tempNumber = 2;
            
            while (numberRandom > tempNumber)
            {
                degreeNumber++;
                tempNumber *= setNumber;
            } 

            Console.WriteLine("степень = "+ degreeNumber);
            Console.ReadLine();
        }
    }
}
