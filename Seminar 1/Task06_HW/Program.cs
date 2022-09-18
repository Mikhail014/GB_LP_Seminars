// Команда для изменения кодировки в терминале
Console.OutputEncoding = System.Text.Encoding.UTF8;

Console.Write("Введите целое число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num % 2 == 0) Console.WriteLine("Данное число является четным");
else Console.WriteLine("Данное число не является четным");