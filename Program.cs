using System.Text;

Console.OutputEncoding = Encoding.UTF8;

Console.Write("Введіть число: ");
string input = Console.ReadLine();

try
{
    int number = int.Parse(input);
    Console.WriteLine($"Ви ввели число: {number}");
}
catch (FormatException)
{
    Console.WriteLine("Помилка: введене значення не є числом.");
}
catch (Exception ex)
{
    Console.WriteLine($"Сталася помилка: {ex.Message}");
}