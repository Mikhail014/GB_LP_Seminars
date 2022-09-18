// Команда для изменения кодировки в терминале
Console.OutputEncoding = System.Text.Encoding.UTF8;

Console.Write("Введите целое число: ");
int num = Convert.ToInt32(Console.ReadLine());

int i = 2;

while (i <= num){
    if (i == num || i == num - 1) Console.Write($"{i}");
    else Console.Write($"{i}, ");
    i += 2;
}