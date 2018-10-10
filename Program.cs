using System;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = 7;
            int[] numbers = new int[length];
            numbers[0] = 10;
            numbers[1] = 23;
            numbers[2] = 173;
            numbers[3] = 100;
            numbers[4] = 202;
            numbers[5] = 30;
            numbers[6] = 12;
            int sum = 0; 
            //Counting up
            for(int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine("At index "+i+ " the value is "+numbers[i]);
                sum += numbers[i];
            }

            Console.WriteLine("The sum of the all the numbers is " + sum);
            //int divisor = 7;
            float average = sum / numbers.Length;
            
            Console.WriteLine("The Average is " + average);
        }
    }
}