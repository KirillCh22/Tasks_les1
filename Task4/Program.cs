Console.Write("Введите 1-ое число - ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2-ое число - ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 3-ье число - ");
int num3 = Convert.ToInt32(Console.ReadLine());

int max_num = num1;

if (num2 > max_num) max_num = num2;
if (num3 > max_num) max_num = num3;

Console.WriteLine();
Console.WriteLine("Максимальное число - " + max_num);
