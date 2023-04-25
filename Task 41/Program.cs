/*Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3*/

int[] InputArray()
{
    string digits = "-0123456789";
    System.Console.Write("Input a bunch of numbers: ");
    string arrayAsString = System.Console.ReadLine()!;

    List<int> numbers = new List<int>();

    string currentNumber = "";
    int numberAsNumber;
    for (int i = 0; i < arrayAsString.Length; i++)
    {
        int indexOfChar = digits.IndexOf(arrayAsString[i]);
        //System.Console.WriteLine("" + arrayAsString[i] + " - " + indexOfChar);

        if (indexOfChar >= 0)
        {
            currentNumber += arrayAsString[i];
        }
        else
        {
            if (currentNumber.Length > 0)
            {
                bool itIsANumber = int.TryParse(currentNumber, out numberAsNumber);
                numbers.Add(numberAsNumber);
                currentNumber = "";
            }
        }
    }
    if (currentNumber.Length > 0) // pick up the last number
    {
        bool itIsANumber = int.TryParse(currentNumber, out numberAsNumber);
        numbers.Add(numberAsNumber);
    }
    return numbers.ToArray();
}

int[] myArray = InputArray();
int count = 0;
for (int i = 0; i < myArray.Length; i++)
{
    if (myArray[i] > 0) count++;
    System.Console.Write(myArray[i]);
    System.Console.Write((i == myArray.Length - 1) ? "" : ", ");
}

System.Console.Write($" -> {count}");