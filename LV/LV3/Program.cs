using System;

namespace LV3
{
    class Program
    {
        static void Main(string[] args)
        {
            //test 1.zadatak
            //string filePath = @"D:/LV_DOOP/LV/LV3/test.csv";
            //Dataset ds = new Dataset(filePath);
            //ds.Clone();
            //ds.LoadDataFromCSV(filePath);
            //Console.WriteLine(ds.PrintDataList());

            //test 2.zadatak
            //double[][] matrica = MatrixGenerator.GetInstance().MatrixCreator(5, 2);
            //for (int i = 0; i < 5; i++)
            //{
            //    for (int j = 0; j < 2; j++)
            //    {
            //        Console.Write(matrica[i][j].ToString() + "\t");
            //    }
            //    Console.WriteLine();
            //}

            //test 4.zadatak
            ConsoleNotification consoleNotification = new ConsoleNotification("Miha", "Test", "Ovo je test", DateTime.Now, Category.INFO, ConsoleColor.Red);
            NotificationManager notificationManager = new NotificationManager();
            notificationManager.Display(consoleNotification);

        }
    }
}
