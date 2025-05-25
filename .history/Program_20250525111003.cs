using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // DECLARING AND INITIALIZING AN ARRAY
            // int [] numbers = new int[5];
            int[] numbers = { 4, 1, 5, 2, 3 };

            string[] names = { "John", "Jane", "Doe", "Smith", "Alice" };

            // numbers[0] = 1;
            // numbers[1] = 2;
            // numbers[2] = 3;
            // numbers[3] = 4;
            // numbers[4] = 5;

            System.Console.WriteLine(numbers[4]);
            System.Console.WriteLine();

            // Accessing & Looping Through Arrays
            for (int i = 0; i < numbers.Length; i++)
            {
                System.Console.WriteLine(numbers[i]);
            }
            System.Console.WriteLine();

            foreach (int num in numbers)
            {
                System.Console.WriteLine(num);
            }
            
            // updating an element in an array
            // int[] numbers = { 4, 1, 5, 2, 3 };
            numbers[1] = 25; // changes 1 to 25


            
            
            






            //RESIZING AN A FIXED ARRAY


            // int [] numbers = {1, 2, 3};

            // System.Console.WriteLine("Original array: " + numbers);

            // foreach ( int num in numbers)
            // {
            //     System.Console.WriteLine(num);
            // }
            // System.Console.WriteLine();

            // Array.Resize(ref numbers, 5);

            // foreach ( int num in numbers)
            // {
            //     System.Console.WriteLine(num);
            // }



            //DECLARING ARRAYS USING FIXED METHOD

            // int [] numbers = new int[5];

            // numbers[0] = 1;
            // numbers[1] = 2;

            //System.Console.WriteLine(numbers.Length);

            //CHECKING THE NO O DIMENSIONS ON AN ARRAY

            // int[,] doubleNumbers  = new int [2, 5];
            // System.Console.WriteLine(doubleNumbers.Rank);

        }
    }
}