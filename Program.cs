namespace Methods

/* 
 Author: Nicholas Makarov
 Date: 2/16/2023
 Comments: This program uses the 2 methods described in the Deliverable 5 assignment
*/

{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter an integer number between 5 and 15: ");

            try
            {
                int length = int.Parse(Console.ReadLine());

                if (length < 5 || length > 15)
                {
                    Console.WriteLine("The number entered is outside of the allowed range.");
                }
                else
                {
                    int[] array = PopulateArray(length);
                    Console.WriteLine("The elements of the array are: " + string.Join(" ", array));
                    Console.WriteLine("The sum is: " + SumArray(array));
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("The input entered is not a valid integer.");
            }

            Console.ReadLine();
        }

        static int[] PopulateArray(int length)
        {
            int[] array = new int[length];
            Random random = new Random();

            for (int i = 0; i < length; i++)
            {
                array[i] = random.Next(10, 51);
            }

            return array;
        }

        static int SumArray(int[] array)
        {
            int sum = 0;

            foreach (int number in array)
            {
                sum += number;
            }

            return sum;
        }
    }

}

