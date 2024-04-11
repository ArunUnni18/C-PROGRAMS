using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleApp1
{
    public class Matrix
    {
        public static void MatrixAddition()
        {
            Console.WriteLine("enter the number of rows");
            string inputrow = Console.ReadLine();
            Console.WriteLine("enter the number of columns");
            string inputcol = Console.ReadLine();


            if (!int.TryParse(inputrow, out int intValue) || !int.TryParse(inputcol, out int intValue1))
            {
                Console.WriteLine("Please enter a valid number: " );
                MatrixAddition();
            }
           
                int row = Convert.ToInt32(inputrow);

                //Console.WriteLine("enter the number of column");
                int col = Convert.ToInt32(inputcol);
                int[,] matrixA = new int[row, col];
                //int[,] matrixC = new int[0, 0];



                for (int i = 0; i < row; i++)
                {
                    for (int j = 0; j < col; j++)
                    {
                        Console.WriteLine("enter the values");
                        matrixA[i, j] = Convert.ToInt32(Console.ReadLine());

                    }
                }

                Console.WriteLine(Convert.ToString(matrixA));


                int[,] matrixB = new int[row, col];

                for (int i = 0; i < row; i++)
                {
                    for (int j = 0; j < col; j++)
                    {
                        Console.WriteLine("enter the values of second matrix");
                        matrixB[i, j] = Convert.ToInt32(Console.ReadLine());

                    }
                }

                Console.WriteLine(Convert.ToString(matrixB));


                int[,] matrixC = new int[row, col];
                for (int i = 0; i < row; i++)
                {
                    for (int j = 0; j < col; j++)
                    {
                        matrixC[i, j] = matrixA[i, j] + matrixB[i, j];
                    }
                }


                foreach (var item in matrixC)
                {
                    Console.WriteLine(item);
                }
            }
        }
        
        

    }
    

