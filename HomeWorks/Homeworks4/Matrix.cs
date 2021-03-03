using System;
using System.Collections.Generic;
using System.Text;

namespace Homeworks4
{
    class Matrix
    {
        public int[] body; // int[] body; int[][]
        public int NumOfRows { get; set; }
        public int NumOfColumns { get; set; }

        public Matrix(int n, int m)
        {
            this.NumOfRows = n;
            this.NumOfColumns = m;
            this.body = new int[n * m];
        }
        public void GenerateRandomMatrix()
        {
            Random rand = new Random();
            for (int i = 0; i < this.NumOfRows * this.NumOfColumns; i++)
            {
                this.body[i] = rand.Next(1, 10);
            }
        }
        public static Matrix Addition(Matrix matrix1, Matrix matrix2)
        {
            if (matrix1.NumOfRows != matrix2.NumOfRows || matrix1.NumOfColumns != matrix2.NumOfColumns)
            {
                return null;
            }
            Matrix sum = new Matrix(matrix1.NumOfRows, matrix1.NumOfColumns);
            for (int i = 0; i < matrix1.NumOfRows * matrix1.NumOfColumns; i++)
            {
                sum.body[i] = matrix1.body[i] + matrix2.body[i];
            }
            return sum;
        }

        public void Addition(Matrix matrix1)
        {
            if (matrix1.NumOfRows != this.NumOfRows || matrix1.NumOfColumns != this.NumOfColumns)
            {
                Console.WriteLine("Can not add given matrices.");
                return;
            }
            for (int i = 0; i < matrix1.NumOfRows * matrix1.NumOfColumns; i++)
            {
                this.body[i] = matrix1.body[i] + this.body[i];
            }
        }

        public Matrix ScalarMult(int scalar)
        {
            Matrix scalarMultMatrix = new Matrix(this.NumOfRows, this.NumOfColumns);
            for (int i = 0; i < this.NumOfRows * this.NumOfColumns; i++)
            {
                scalarMultMatrix.body[i] = this.body[i] * scalar;
            }
            return scalarMultMatrix;
        }
        public static Matrix Mult(Matrix m1, Matrix m2)
        {
            if (m1.NumOfColumns != m2.NumOfRows)
            {
                Console.WriteLine("Cannot multiply given matrices.");
                return null;
            }
            Matrix mult = new Matrix(m1.NumOfRows, m2.NumOfColumns);
            for (int i = 0; i < m1.NumOfRows; i++)
            {
                for (int j = 0; j < m2.NumOfColumns; j++)
                {
                    for (int k = 0; k < m1.NumOfColumns; k++)
                    {
                        mult.body[i*m1.NumOfColumns + j] += m1.body[i*m1.NumOfColumns + k] * m2.body[k*m2.NumOfColumns + j];
                    }
                }
            }
            return mult;
        }

        public void PrintMatrix()
        {
            for (int i = 0; i < this.NumOfRows * this.NumOfColumns; i++)
            {

                Console.Write(this.body[i]);
                Console.Write(" ");
                if ((i + 1) % this.NumOfColumns == 0)
                {
                    Console.WriteLine();
                }

            }
        }
        public Matrix GetTriangularMatrix(bool isUpper)
        {
            if (this.NumOfColumns != this.NumOfRows)
            {
                Console.WriteLine("The given matrix does not have triangular matrix.");
                return null;
            }
            
            Matrix result = new Matrix(this.NumOfRows, this.NumOfColumns);
            for (int k = 0; k < this.NumOfRows * this.NumOfColumns; k++)
            {
                int j, i;
                i = k / NumOfColumns;
                j = k % NumOfColumns;
                if (isUpper)
                {
                    if (j >= i)
                    {
                        result.body[k] = this.body[k];
                    }
                }
                else
                {
                    if (j <= i)
                    {
                        result.body[k] = this.body[k];
                    }
                }

            }
            return result;
        }

        public override string ToString()
        {
            PrintMatrix();
            return null;
        }
    }
}

