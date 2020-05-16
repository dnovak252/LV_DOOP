using System;

namespace LV5
{
    class Program
    {
        static void Main(string[] args)
        {
            IDataset dataPrint = new Dataset(@"D:/LV_DOOP/LV/LV5/test.csv");
            DataConsolePrinter.dataPrint(dataPrint);
            IDataset virtualProxyDataset = new VirtualProxyDataset(@"D:/LV_DOOP/LV/LV5/test.csv");
            DataConsolePrinter.dataPrint(virtualProxyDataset);
            User user = User.GenerateUser("User");
            IDataset protectionProxyData = new ProtectionProxyDataset(user);
            DataConsolePrinter.dataPrint(protectionProxyData);

        }
    }
}
