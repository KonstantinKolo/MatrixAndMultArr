using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01
{
    class Program
    {
        static void Main(string[] args)
        {
            int row = int.Parse(Console.ReadLine());
            int col = int.Parse(Console.ReadLine());
            int[,] arr = new int[row,col];
            for (int s1 = 0; s1 < row; s1++)
            {
                for (int s2 = 0; s2 < col; s2++)
                {
                    arr[s1, s2] = int.Parse(Console.ReadLine());
                }
            }
            for (int s1 = 0; s1 < row; s1++)
            {
                for (int s2 = 0; s2 < col; s2++)
                {
                    Console.Write(arr[s1, s2] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
