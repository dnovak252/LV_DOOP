using System;
using System.Collections.Generic;
using System.Text;

namespace LV3
{
    class MatrixGenerator
    {
        private static MatrixGenerator instance;
        private Random matrixGenerator;
        
        private MatrixGenerator()
        {
            this.matrixGenerator = new Random();
        }
        public static MatrixGenerator GetInstance()
        {
            if (instance == null)
            {
                instance = new MatrixGenerator();
            }
            return instance;
        }

        public double[][] MatrixCreator(int x, int y)
        {
            double[][] matrix = new double[x][];
            for (int i = 0; i < x; i++)
            {
                matrix[i] = new double[y];
            }

            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    matrix[i][j] = this.matrixGenerator.NextDouble();
                }
            }
            return matrix;
        }
    }
}
