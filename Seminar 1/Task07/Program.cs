// Команда для изменения кодировки в терминале
Console.OutputEncoding = System.Text.Encoding.UTF8;

Console.Write("Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num >= 100 && num <= 999) Console.WriteLine(num % 10);
else Console.WriteLine("Ошибка ввода!!! Пожалуйста, введите трехзначное число!");