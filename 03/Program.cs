using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03
{
    class Program
    {
        static void Main(string[] args)
        {
            int row = int.Parse(Console.ReadLine());
            int col = int.Parse(Console.ReadLine());
            int min = int.MaxValue;
            int[] helpArr = new int[col];
            int[,] arr = new int[row, col];
            for (int s1 = 0; s1 < row; s1++)
            {
                helpArr = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int s2 = 0; s2 < col; s2++)
                {
                    arr[s1, s2] = helpArr[s2];
                }
            }                      
            Console.WriteLine("Array is :");
            for (int s1 = 0; s1 < row ; s1++) 
            {
                for (int s2 = 0; s2 < col; s2++)
                {
                    Console.Write(arr[s1, s2] + " ");
                }
                Console.WriteLine();
            }
            for (int s3 = 0; s3 < col; s3++)
            {
                for (int s4 = 0; s4 < row; s4++)
                {
                    if (arr[s4, s3] < min)
                    {
                        min = arr[s4, s3];
                    }
                }
                Console.Write(min + " ");
                min = int.MaxValue;
            }
        }
    }
}
