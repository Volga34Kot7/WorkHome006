// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Write("Введите желаемое количество цифр: ");
int m = Convert.ToInt32(Console.ReadLine());
int[] countNumbers = new int[m];

void PrintArray(int m)
{
    for (int i = 0; i < m; i++)
    {
        Console.Write($"Введите {i+1} число; ");
        countNumbers[i] = Convert.ToInt32(Console.ReadLine());  
    }
}
int SearchDigit(int[] countNumbers)
{
    int count = 0;
    for (int i = 0; i < countNumbers.Length; i++)
    {
        if(countNumbers[i] > 0) count += 1;
    }
    return count;
}
PrintArray(m);
void ArrayPrint (int[] countNumbers)
{
    for (int j = 0; j < countNumbers.Length; j++)
    {
        Console.Write($"{countNumbers[j]},");
    }
}
Console.Clear();
ArrayPrint(countNumbers);
Console.WriteLine($"-> {SearchDigit(countNumbers)} ");

