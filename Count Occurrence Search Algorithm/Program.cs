using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count_Occurrence_Search_Algorithm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string repeat_answer = "";
            bool repeat = true;
            while (repeat == true)
            {
                int answer = 0;
                int[] arr = new int[100];
                int count = 0;
                bool handling = true;
                Random r = new Random();
                for (int i = 0; i < 100; i++)
                {
                    arr[i] = r.Next(1, 10);
                }
                Console.WriteLine("Enter a number to count");
                while (handling == true)
                {
                    try
                    {
                        answer = int.Parse(Console.ReadLine());
                        handling = false;
                    }
                    catch
                    {
                        Console.WriteLine("Enter a NUMBER");
                    }
                }
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] == answer)
                    {
                        count++;
                    }
                }
                Console.WriteLine("Your number appeared {0} times", count);
                Console.WriteLine("Would you like to start again with a different set of numbers? (Y/N)");
                repeat_answer = Console.ReadLine();
                repeat_answer = repeat_answer.ToLower();
                if (repeat_answer.Contains("y"))
                {
                    Array.Clear(arr, 0, arr.Length);
                }
                else
                {
                    repeat = false;
                }
            }
            
        }
    }
}
