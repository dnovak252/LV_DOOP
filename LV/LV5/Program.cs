using System;

namespace LV5
{
    class Program
    {
        static void Main(string[] args)
        {
            //3. zadatak
            //IDataset dataPrint = new Dataset(@"D:/LV_DOOP/LV/LV5/test.csv");
            //DataConsolePrinter.dataPrint(dataPrint);
            //IDataset virtualProxyDataset = new VirtualProxyDataset(@"D:/LV_DOOP/LV/LV5/test.csv");
            //DataConsolePrinter.dataPrint(virtualProxyDataset);
            //User user = User.GenerateUser("User");
            //IDataset protectionProxyData = new ProtectionProxyDataset(user);
            //DataConsolePrinter.dataPrint(protectionProxyData);

            ITheme myCustomTheme = new Task4Theme();
            ReminderNote reminderNote = new ReminderNote("My custom theme", myCustomTheme);
            reminderNote.Show();

        }
    }
}
