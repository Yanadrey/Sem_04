// Напишите программу, которая принимает на вход число
// и выдаёт сумму цифр в числе.

string? InputNumber(string text)
{
    System.Console.Write(text);
    return Console.ReadLine();
}

int CheckNumber(string number)
{
    if (int.TryParse(number, out int i))
    {
        i = 1;
        return i;
    }
    else
    {
        System.Console.WriteLine("Ошибка! Введено не число!");
        i = 0;
        return i;
    }
}

int Sum(string number)
{
    int result = 0;
    string temp = Convert.ToString(Math.Abs(Convert.ToInt32(number)));
    for (int i = 0; i < temp.Length; i++)
    {
        result = result + int.Parse(temp[i].ToString());
    }
    return result;
}

string InpNumber = InputNumber("Введите число: ");

int i = CheckNumber(InpNumber);

if (i == 1)

    System.Console.WriteLine($"Сумма цифр числа {InpNumber} равна {Sum(InpNumber)}");


