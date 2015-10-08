//Problem 1. Fill the matrix

//Write a program that fills and prints a matrix of size (n, n) as shown below:

//Example for n=4:
//         a) 	              b) 	              c) 	              d)*
//  1 	5 	9 	13      1 	8 	9 	16      7 	11 	14 	16      1 	12 	11 	10
//  2 	6 	10 	14      2 	7 	10 	15      4 	8 	12 	15      2 	13 	16 	9
//  3 	7 	11 	15      3 	6 	11 	14      2 	5 	9 	13      3 	14 	15 	8
//  4 	8 	12 	16      4 	5 	12 	13      1 	3 	6 	10      4 	5 	6 	7
		
using System;

class FillTheMatrix
{
    static void Main()
    {
        Console.WriteLine("Please enter the size of matrix.");
        Console.Write("Please enter n: ");
        int n = int.Parse(Console.ReadLine());
        int[,] matrix = new int[n, n];
        int row = 0;
        int col = 0;
        Console.WriteLine("a)");
        //Matrix a)
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                matrix[j, i] = j + 1 + (n * i);
            }
        }
        for (int i = 0; i < Math.Sqrt(matrix.Length); i++)
        {
            Console.WriteLine();
            for (int j = 0; j < Math.Sqrt(matrix.Length); j++)
            {
                Console.Write("{0,3}", matrix[i, j]);

            }
        }
        Console.WriteLine();

        //Matrix b)
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if ((i % 2) == 0)
                {
                    matrix[j, i] = j + 1 + (n * i);
                }
                else
                {
                    matrix[n - j - 1, i] = j + 1 + (n * i);
                }
            }
        }
        for (int i = 0; i < Math.Sqrt(matrix.Length); i++)
        {
            Console.WriteLine();
            for (int j = 0; j < Math.Sqrt(matrix.Length); j++)
            {
                Console.Write("{0,3}", matrix[i, j]);

            }
        }
        Console.WriteLine();

        //Matrix c)
        int rows = n - 1,
         cols = 0,
         data = 0;
        for (int i = 0; i < n; i++)
        {
            do
            {
                data++;
                if (rows < 0) rows = 0;
                matrix[rows, cols] = data;
                rows++;
                cols++;
            } while (rows < n);
            rows -= cols + 1;
            cols = 0;
        }
        rows = 0;
        cols = 1;
        for (int i = 0; i < n - 1; i++)
        {
            do
            {
                data++;
                matrix[rows, cols] = data;
                rows++;
                cols++;
            } while (cols < n);
            cols -= rows - 1;
            rows = 0;
        }
        for (int i = 0; i < Math.Sqrt(matrix.Length); i++)
        {
            Console.WriteLine();
            for (int j = 0; j < Math.Sqrt(matrix.Length); j++)
            {
                Console.Write("{0,3}", matrix[i, j]);

            }
        }
        Console.WriteLine();
    }

        //Matrix d)
        private static void Spiral(int[,] matrix, int row, int col, int n)
        {
        int number = 1;
        if (number >= n * n)
        {
            return;
        }
        else
        {
            // down
            while ((row < n) && (matrix[row, col] == 0))
            {
                matrix[row, col] = number;
                row++;
                number++;
            }
            row--;
            col++;
            // left
            while ((col < n) && (matrix[row, col] == 0))
            {
                matrix[row, col] = number;
                col++;
                number++;
            }
            col--;
            row--;
            // up
            while ((row >= 0) && (matrix[row, col] == 0))
            {
                matrix[row, col] = number;
                row--;
                number++;
            }
            row++;
            col--;
            // left
            while ((col > 0) && (matrix[row, col] == 0))
            {
                matrix[row, col] = number;
                col--;
                number++;
            }
            if (matrix[row, col] != 0)
            {
                row++;
                col++;
                Spiral(matrix, row, col, n);
            }
        }
        for (int i = 0; i < Math.Sqrt(matrix.Length); i++)
        {
            Console.WriteLine();
            for (int j = 0; j < Math.Sqrt(matrix.Length); j++)
            {
                Console.Write("{0,3}", matrix[i, j]);

            }
        }
    }    
}

