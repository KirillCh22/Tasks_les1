Console.Write("Введите число - ");
int num = Convert.ToInt32(Console.ReadLine());

int even_num = num % 2;

if (even_num == 0) Console.WriteLine("Вы ввели четное число");
else  Console.WriteLine("Вы ввели нечетное число");

