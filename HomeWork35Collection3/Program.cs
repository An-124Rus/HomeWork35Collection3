using System.Threading;

internal class Program
{
    private static void Main(string[] args)
    {
        bool isWorking = true;
        string userInput;
        string sumComand = "sum";
        string exitComand = "esc";

        List<int> numberRow = new List<int>();

        while (isWorking)
        {
            Console.WriteLine($"Для сложения чисел введите {sumComand}");
            Console.WriteLine($"Для выхода введите {exitComand}\n");
            Console.Write("Введите число или команду: ");

            userInput = Console.ReadLine();

            if (userInput == sumComand)
                Sum(numberRow);
            else if (userInput == exitComand)
                isWorking = false;
            else
                InsertNumber(numberRow, userInput);
        }
    }

    static void InsertNumber(List<int> numberRow, string userInput)
    {
        int number = CheckInput(userInput);

        numberRow.Add(number);

        Console.WriteLine($"Число {number} внесено.\n");
    }

    static void Sum(List<int> numberRow)
    {
        int sum = numberRow.Sum();

        Console.WriteLine($"Сумма всех чисел равна {sum}\n");
    }

    static int CheckInput(string userInput)
    {
        int number;

        while (int.TryParse(userInput, out number) == false)
        {
            Console.Write("Введено не чиcло и не команда. Введите число: ");
            userInput = Console.ReadLine();
        }

        return number;
    }
}