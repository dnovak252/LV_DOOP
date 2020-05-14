using System;


namespace LV4
{
    class Program
    {
        static void Main(string[] args)
        {
            //2.zadatak
            Dataset dataset = new Dataset();
            dataset.LoadDataFromCSV(@"D:/LV_DOOP/LV/LV4/test.csv");
            Analyzer3rdParty analyzer = new Analyzer3rdParty();
            Adapter adapter = new Adapter(analyzer);
            double[] row = new double[4];
            double[] column = new double[4];
            row = adapter.CalculateAveragePerRow(dataset);
            column = adapter.CalculateAveragePerColumn(dataset);
            for (int i = 0; i < row.Length; i++)
            {
                Console.WriteLine(row[i] + "  ");
            }
            Console.WriteLine("\n");
            for (int i = 0; i < column.Length; i++)
            {
                Console.WriteLine(column[i] + "  ");
            }

        }
    }
}
