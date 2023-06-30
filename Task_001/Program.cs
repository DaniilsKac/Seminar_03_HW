// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
string Index = Convert.ToString(number);
if (Index.Length == 5)
{
    if (Index[0] == Index[4] || Index[1] == Index[3])
    {
        Console.WriteLine($"Your number {number} is palindrome!");
    }
    else Console.WriteLine($"Your number {number} is not palindrome!");
}
else Console.WriteLine("Enter a five-digit number!");