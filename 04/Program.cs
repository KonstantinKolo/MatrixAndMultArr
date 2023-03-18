using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] commands = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] helpArr = new int[commands[1]];
            int[,] codeArr = new int[commands[0], commands[1]];
            int mainDiag = 0;
            int secDiag = 0;
            int helpDiag = commands[0] - 1;
            int helpUpp = 1;
            int sumUpp = 0;
            int sumDown = 0;
            int checker = 0;
            double money = 0;
            for (int s1 = 0; s1 < commands[0]; s1++)
            {
                helpArr = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int s2 = 0; s2 < commands[1]; s2++)
                {
                    codeArr[s1, s2] = helpArr[s2];
                } 
            }
            //Check the diagonals and get their sum
            for (int s1 = 0; s1 < commands[1]; s1++)
            {
                mainDiag += codeArr[s1, s1];
                if (codeArr[s1, s1] % 2 == 0)
                {
                    money += codeArr[s1, s1];
                }
            }
            for (int s1 = commands[1] - 1; s1 >= 0; s1--)
            {
                secDiag += codeArr[helpDiag, s1];
                helpDiag--;
            }
            if (mainDiag == secDiag)
            {
                checker++;
            }
            //Check if the sum of nums above mainDiag % 2 == 0
            for (int s1 = 0; s1 < commands[0] - 1; s1++)
            {
                for (int s2 = helpUpp; s2 < commands[1]; s2++)
                {
                    sumUpp += codeArr[s1, s2];                   
                }
                helpUpp++;
                if (helpUpp == commands[1])
                {
                    break;
                }
            }
            if (sumUpp % 2 == 0)
            {
                checker++;
            }
            //Checks if the nums under mainDiag % 2 != 0
            helpUpp = 1;
            for (int s1 = 1; s1 < commands[0]; s1++)
            {
                for (int s2 = 0; s2 < helpUpp; s2++)
                {
                    sumDown += codeArr[s1, s2];
                }
                helpUpp++;
                if (helpUpp == commands[1])
                {
                    break;
                }
            }
            if (sumDown % 2 != 0)
            {
                checker++;
            }
            //All the conditions have been met
            if (checker == 3)
            {
                Console.WriteLine("YES");
                money += sumDown;
                for (int s1 = 0; s1 < commands[1]; s1++)
                {
                    if (codeArr[0, s1] % 2 == 0)
                    {
                        money += codeArr[0, s1];
                    }
                    if (codeArr[commands[0] - 1, s1] % 2 == 0) 
                    {
                        money += codeArr[commands[0] - 1, s1];
                    }
                }
                for (int s1 = 0; s1 < commands[0]; s1++)
                {
                    if (codeArr[s1, 0] % 2 != 0)
                    {
                        money += codeArr[s1, 0];
                    }
                    if (codeArr[s1, commands[1] - 1] % 2 != 0) 
                    {
                        money += codeArr[s1, commands[1] - 1];
                    }
                }
                money = money / 4;
                Console.WriteLine($"The amount of money won is: {money:F2}");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
