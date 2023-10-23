// Принимает на вхд пятизначное число и проверяет,
// является ли оно палиндромом.
Console.Write("Введите любое целое число: ");
string? number = Console.ReadLine();
int length = number.Length;
int count = 0;
while ((count <= (length/2 -1)) && (number[count] == number[length - 1 - count]))
{
    count++;
}
if (count == length/2)
{
    Console.WriteLine("Число является палиндромом");
}
else
{
    Console.WriteLine("Число не является палиндромом");
}