using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiDimArrayDemo
{
    class Program
    {
        public void Run()
        {
            const int rows = 4;
            const int cols = 3;

            //declare 4*3 integer array

            int[,] rectangularArray = new int[rows, cols];

            //populate the array
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    rectangularArray[i, j] = i + j;
                }
            }

            //display the populated array
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.WriteLine("rectangularArray[{0},{1}]={2}", i, j, rectangularArray[i, j]);
                }
            }

        }
        [STAThread]
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Run();
            Console.ReadLine();
        }
    }
}
