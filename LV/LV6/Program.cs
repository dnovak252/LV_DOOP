using System;

namespace LV6
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. zadatak
            //Note note1 = new Note("First Note.", "I am note number one.");
            //Note note2 = new Note("Second Note", "I am note number two.");
            //Note note3 = new Note("Third Note", "I am note number three.");
            //Notebook notebook = new Notebook();
            //notebook.AddNote(note1);
            //notebook.AddNote(note2);
            //notebook.AddNote(note3);
            //IAbstractIterator iterator = notebook.GetIterator();
            //for (int i = 0; i < notebook.Count; i++)
            //{
            //    iterator.Current.Show();  
            //    iterator.Next();
            //}

            //2. zadatak
            //Product product1 = new Product("Milk", 1.8);
            //Product product2 = new Product("Bread", 1);
            //Product product3 = new Product("Eggs", 2.2);
            //Box box = new Box();
            //box.AddProduct(product1);
            //box.AddProduct(product2);
            //box.AddProduct(product3);
            //IAbstractIteratorTask2 iteratorTask2 = box.GetIterator();
            //for (int i = 0; i <box.Count; i++)
            //{
            //    Console.WriteLine(iteratorTask2.Current.ToString());
            //    iteratorTask2.Next();
            //}

            //3.zadatak
            //var dateTime = new DateTime(2020, 12, 21, 16, 0, 0);
            //var dateTime2 = new DateTime(2020, 12, 21, 12, 0, 0);
            //ToDoItem item1 = new ToDoItem("Item no.1", "Clean room", dateTime);
            //Console.WriteLine(item1.ToString());
            //CareTaker careTaker = new CareTaker();
            //careTaker.StackPush(item1.StoreState());
            //item1.Rename("Item no.1 - Update");
            //item1.ChangeTask("Wash the dishes");
            //item1.ChangeTimeDue(dateTime2);
            //Console.WriteLine(item1.ToString());
            //item1.RestoreState(careTaker.StackPop());
            //Console.WriteLine(item1.ToString());

            //4.zadatak
            //BankAccount bankAccount1 = new BankAccount("Marko Maric", "Matije Gupca 51", 5000);
            //Console.WriteLine(bankAccount1.OwnerName + ", " + bankAccount1.OwnerAddress + ", " + bankAccount1.Balance+"\n");
            //MementoBankAccount memento = bankAccount1.StoreState();
            //bankAccount1.ChangeOwnerAddress("J.J. Strossmayera 22");
            //Console.WriteLine("Update!");
            //Console.WriteLine(bankAccount1.OwnerName + ", " + bankAccount1.OwnerAddress + ", " + bankAccount1.Balance+"\n");
            //bankAccount1.RestoreState(memento);
            //Console.WriteLine("Previous data restored!");
            //Console.WriteLine(bankAccount1.OwnerName + ", " + bankAccount1.OwnerAddress + ", " + bankAccount1.Balance);

            //5. zadatak
            //AbstractLogger logger = new ConsoleLogger(MessageType.ALL);
            //FileLogger fileLogger = new FileLogger(MessageType.ERROR | MessageType.WARNING, @"D:\LV_DOOP\LV\LV6\logFile.txt");
            //logger.SetNextLogger(fileLogger);
            //logger.Log("This is error and warning alert. ", MessageType.ERROR | MessageType.WARNING);
            //fileLogger.Log("This is information alert.", MessageType.INFO);

            //6. zadatak
            //string stringToCheck= "This is 1. string check.";
            //string stringToCheck2 = "This string has no digits.";
            //StringChecker stringDigitChecker = new StringDigitChecker();
            //StringChecker stringLengthChecker = new StringLengthChecker();
            //StringChecker stringLowerCaseChecker = new StringLowerCaseChecker();
            //StringChecker stringUpperCaseChecker = new StringUpperCaseChecker();
            //stringDigitChecker.SetNext(new StringLengthChecker());
            //stringLengthChecker.SetNext(new StringLowerCaseChecker());
            //stringLowerCaseChecker.SetNext(new StringUpperCaseChecker());
            //Console.WriteLine(stringDigitChecker.Check(stringToCheck));
            //Console.WriteLine(stringDigitChecker.Check(stringToCheck2));

            //7. zadatak
            //StringChecker stringDigitChecker = new StringDigitChecker();
            //StringChecker stringLengthChecker = new StringLengthChecker();
            //StringChecker stringLowerCaseChecker = new StringLowerCaseChecker();
            //StringChecker stringUpperCaseChecker = new StringUpperCaseChecker();
            //string passwordCheck = "123Password321";
            //PasswordValidator validator = new PasswordValidator(stringDigitChecker);
            //validator.AddLink(stringLengthChecker);
            //validator.AddLink(stringLowerCaseChecker);
            //validator.AddLink(stringUpperCaseChecker);
            //Console.WriteLine(validator.CheckPassword(passwordCheck));
            //string passwordCheck2 = "falsepassword";
            //validator.AddLink(stringLengthChecker);
            //validator.AddLink(stringLowerCaseChecker);
            //validator.AddLink(stringUpperCaseChecker);
            //Console.WriteLine(validator.CheckPassword(passwordCheck2));

            //8. zadatak
            //WeatherStation weatherStation = new WeatherStation(20);
            //HomeThermostat homeThermostat = new HomeThermostat();
            //HomeThermostat workplaceThermostat = new HomeThermostat();
            //homeThermostat.Update(20);
            //weatherStation.AddObserver(homeThermostat);
            //weatherStation.AddObserver(workplaceThermostat);
            //workplaceThermostat.Update(14);
            //weatherStation.SetTemperature(27);
            //weatherStation.RemoveObserver(homeThermostat);
            //workplaceThermostat.Update(14);
            //workplaceThermostat.Update(32);

            //9. zadatak
            WeatherObserver car = new CarDetails(140, 50, "summer");
            WeatherStation weatherStation = new WeatherStation(20);
            weatherStation.SetTemperature(21);
            weatherStation.AddObserver(car);
            Console.WriteLine(car.ToString());
            weatherStation.SetTemperature(2);
            Console.WriteLine(car.ToString());
            weatherStation.SetTemperature(30);
            Console.WriteLine(car.ToString());


        }
    }
}
