namespace Lab3CSharp
{
    internal class Program
    {
        static void Task1()
        {
            try
            {
                Rectangle rect = new Rectangle(5, 5, 10);
                Console.WriteLine("Rectangle sides:");
                rect.PrintSides();
                Console.WriteLine("Perimeter: " + rect.CalculatePerimetr());
                Console.WriteLine("Area: " + rect.CalculateArea());
                Console.WriteLine("Is square? " + rect.IsSquare());
                Console.WriteLine("Color: " + rect.Color);
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }

        static void Task2()
        {
            // Створюємо масив базового класу
            Country[] countries = new Country[3];

            // Заповнюємо масив різними об'єктами
            countries[0] = new Republic
            {
                Name = "Ukraine",
                Population = 41000000,
                Area = 603500,
                President = "Volodymyr Zelenskyi"
            };

            countries[1] = new Monarchy
            {
                Name = "United Kingdom",
                Population = 66400000,
                Area = 242500,
                Monarch = "Queen Elizabeth II"
            };

            countries[2] = new Kingdom
            {
                Name = "Spain",
                Population = 47300000,
                Area = 505990,
                Monarch = "King Felipe VI",
                NobilityCount = 10000
            };

            // Виводимо дані про об'єкти
            foreach (var country in countries)
            {
                country.Show();
                Console.WriteLine();
            }
        }
        static void ShowMenu()
        {
            string[] menuStrings =
            {
                "1. Task 1!",
                "2. Task 2!"
            };
            int currentOprtion = 0;
            ConsoleKeyInfo keyInfo;
            int choice = 0;
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Lab 3 CSharp!");
                PrintMenu(menuStrings, currentOprtion);


                keyInfo = Console.ReadKey();
                if (keyInfo.Key == ConsoleKey.S || keyInfo.Key == ConsoleKey.DownArrow)
                {
                    currentOprtion = currentOprtion + 1 <= menuStrings.Length - 1 ? currentOprtion + 1 : 0;
                }
                else if (keyInfo.Key == ConsoleKey.W || keyInfo.Key == ConsoleKey.UpArrow)
                {
                    currentOprtion = currentOprtion - 1 >= 0 ? currentOprtion - 1 : menuStrings.Length - 1;
                }
                else if (keyInfo.Key == ConsoleKey.Enter)
                {
                    choice = currentOprtion;
                    break;
                }
            }
            switch (choice)
            {
                case 0:
                    Console.WriteLine("Task1!");
                    Task1();
                    break;
                case 1:
                    Console.WriteLine("Task2!");
                    Task2();
                    break;
                default:
                    break;
            }
        }
        static void PrintMenu(string[] menuString, int choosenString)
        {
            for (int i = 0; i < menuString.Length; i++)
            {
                if (i == choosenString)
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.Gray;
                }
                Console.WriteLine(menuString[i]);
                if (i == choosenString)
                {
                    Console.ResetColor();
                }
            }
        }
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                ShowMenu();
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            }
        }
    }
}
