using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV4
{
    class Program
    {
        static void Main(string[] args)
        {
            //2.zadatak
            //Dataset dataset = new Dataset();
            //dataset.LoadDataFromCSV(@"D:/LV_DOOP/LV/LV4/test.csv");
            //Analyzer3rdParty analyzer = new Analyzer3rdParty();
            //Adapter adapter = new Adapter(analyzer);
            //double[] row = new double[4];
            //double[] column = new double[4];
            //row = adapter.CalculateAveragePerRow(dataset);
            //column = adapter.CalculateAveragePerColumn(dataset);
            //for (int i = 0; i < row.Length; i++)
            //{
            //    Console.WriteLine(row[i] + "  ");
            //}
            //Console.WriteLine("\n");
            //for (int i = 0; i < column.Length; i++)
            //{
            //    Console.WriteLine(column[i] + "  ");
            //}

            //3. zadatak
            //List<IRentable> rentableList = new List<IRentable>();
            //Book book1 = new Book("Don Quijote");
            //Video video1 = new Video("Dirty Grandpa");
            //rentableList.Add(book1);
            //rentableList.Add(video1);
            //RentingConsolePrinter printer = new RentingConsolePrinter();
            //printer.DisplayItems(rentableList);
            //printer.PrintTotalPrice(rentableList);

            //4. zadatak
            //List<IRentable> rentableList = new List<IRentable>();
            //Book book1 = new Book("Fifty Shades Of Grey");
            //Video video1 = new Video("Day After Tomorrow");
            //HotItem hotItem = new HotItem(book1);
            //HotItem hotItem2 = new HotItem(video1);
            //rentableList.Add(hotItem);
            //rentableList.Add(hotItem2);
            //RentingConsolePrinter printer = new RentingConsolePrinter();
            //printer.DisplayItems(rentableList);
            //printer.PrintTotalPrice(rentableList);

            //Razlika je u tome što vidimo povećanje cijene te vidimo drugačiji način ispisa

            //5. zadatak
            //List<IRentable> sale = new List<IRentable>();
            //Book book1 = new Book("Fifty Shades Of Grey");
            //DiscountedItem item = new DiscountedItem(book1);
            //sale.Add(item);
            //RentingConsolePrinter printer = new RentingConsolePrinter();
            //printer.PrintTotalPrice(sale);
            //printer.DisplayItems(sale);

            //6. zadatak
            //string emailTest = "test.email@gmail.com";
            //string emailTest2 = "test.emailgmail.com";
            //EmailValidator emailValidator = new EmailValidator();
            //emailValidator.IsValidAddress(emailTest);
            //emailValidator.IsValidAddress(emailTest2);
            //Console.WriteLine("Mail is correct: " + emailValidator.IsValidAddress(emailTest));
            //Console.WriteLine("Mail is correct: " + emailValidator.IsValidAddress(emailTest2));

            //7. zadatak
            RegistrationValidator registrationValidator = new RegistrationValidator();
            while (true)
            {
                while (true)
                {
                    if (registrationValidator.IsUserEntryValid(UserEntry.ReadUserFromConsole()))
                    {
                        Console.WriteLine("Your registration is completed succesfully.");
                    }
                    else
                    {
                        Console.WriteLine("You entered e-mail or password wrong! Try again.");
                    }
                }

            }
        }
    }
}
