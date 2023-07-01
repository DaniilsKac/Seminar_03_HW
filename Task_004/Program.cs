// Дана строка, найти в ней количество заглавных и строчных букв. Для нахождения количеств написать два собственных метод

Console.WriteLine("Введите строку: ");
int Uppercase = 0;
int Lowercase = 0;
int Digit = 0;
int Others = 0;
string? line = Console.ReadLine();
foreach (var symbol in line)
{
    if (char.IsUpper(symbol)) Uppercase++;
    else if (char.IsLower(symbol)) Lowercase++;
    else if (char.IsDigit(symbol)) Digit++;
    else if (char.IsSymbol(symbol)) Others++;
}
Console.WriteLine($"В указанной строке:\nЗаглавных - {Uppercase}\nСтрочных - {Lowercase}\nЦифр - {Digit}\nСимволов - {Others}");