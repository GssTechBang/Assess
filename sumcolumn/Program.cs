﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace sumColumn
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a row");
            int row = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter a column");
            int col = Convert.ToInt32(Console.ReadLine());
            int[,] array = new int[row, col];
       
                {
                    array[i,j] = Convert.ToInt32(inpu[j]);
                }
            }
          



            Console.WriteLine("the values are");
            

            Console.WriteLine("the sum of columns");
            for (int j = 0; j < col; j++)
            {
                int total = 0;
                for (int i = 0; i < row; i++)
                {
                    total += array[i,j];
                }
                Console.WriteLine($"col {j}: {total}");
            }
        }

    }
}
