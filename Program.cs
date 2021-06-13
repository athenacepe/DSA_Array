using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_Array1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Store the contents of the file into a string array "lines"
                string[] lines = System.IO.File.ReadAllLines(@"D:\assignment 1\file6.txt");
                //If the length of the file is not empty continue
                if (lines.Length > 0)
                {
                    //If the length of the file is not 20 throw an error that the file doesn't contain 20 numbers
                    if (lines.Length != 20)
                    {
                        Console.WriteLine("Error! File does not contain 20 numbers.");
                        Console.ReadKey();
                        return;
                    }
                    try
                    {
                        //Convert the string array that contains the contents of the file into an int array
                        int[] ints = Array.ConvertAll(lines, int.Parse);
                        //Output the contents of the file
                        Console.Write("Contents of file: ");
                        for (int i = 0; i < ints.Length; i++)
                        {
                            Console.Write(ints[i] + " ");
                        }
                        //Output all the prime numbers
                        Console.Write("\nPrime Numbers: "); CountPrime(ints);
                        Console.ReadKey();
                    }
                    catch (Exception)
                    //throw an error that the contents of the file cannot be converted into an int array
                    {
                        Console.WriteLine("Error! Conversion fail!");
                        Console.ReadLine();
                    }
                }
                else {
                    //Else statement of the if (lines.Length > 0), if the file is empty display "File is empty!!!!!"
                    Console.WriteLine("Error! File is empty!");
                    Console.ReadLine();
                }
            }
            //Throw an error if the file is not found
            catch (FileNotFoundException)
            {
                Console.WriteLine("Error! File not found!");
                Console.ReadLine();
            }
        }

        //static method to check whether the number is prime
        static Boolean CheckPrime(int num)
        {
            Boolean prime = true;
            if (!(num <= 1))
            {
                for (int i = 2; i <= Math.Sqrt(num); i++)
                {
                    if ((num % i) == 0)
                    {
                        prime = false;
                        break;
                    }
                }
                return prime;
            }
            return false;
        }
        
        //static method that will check how many numbers are prime
        static void CountPrime(int[] ints)
        {
            int count = 0;
            for (int i = 0; i < ints.Length; i++)
            {
                if (CheckPrime(ints[i]))
                {
                    Console.Write(ints[i] + " ");
                    count += 1;
                }
            }
            Console.WriteLine("\nNumber of Prime Numbers displayed: {0}", count.ToString());
        }
    }
}