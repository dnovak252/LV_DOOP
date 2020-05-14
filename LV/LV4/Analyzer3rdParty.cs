using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace LV4
{
    class Analyzer3rdParty
    {
        public double[] PerRowAverage(double[][] data)
        {
            int rowCount = data.Length;
            double[] results = new double[rowCount];
            for (int i = 0; i < rowCount; i++)
            {
                results[i] = data[i].Average();
            }
            return results;
        }
        public double[] PerColumnAverage(double[][] data)
        {
            int row = data.Length;
            int column = data[0].Length;
            double[] resultsAvg = new double[column];
            for (int i = 0; i < column; i++)
            {
                double sum = 0;
                for (int j = 0; j < row; j++)
                {
                    sum += data[i][j];
                }
                resultsAvg[i] = sum / row;
                sum = 0;
            }
            return resultsAvg;
        }
    }
}
