// Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.

int InputNumbers(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int GetDegree(int number, int degree)
{
    int result = 1;
    for (int i = 1; i <= Math.Abs(degree); i++)
    {
        result = result * number;
    }
    return result;
}

int A = InputNumbers("Введите основание степени: ");
int B = InputNumbers("Введите показатель степени: ");

System.Console.WriteLine($"Число {A} в степени {B} равно {GetDegree(A, B)}");
