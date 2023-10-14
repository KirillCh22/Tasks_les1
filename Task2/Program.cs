using System.ComponentModel.DataAnnotations;

Console.Write("Введите 1-ое число - ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2-ое число - ");
int num2 = Convert.ToInt32(Console.ReadLine());

int max_num = 0;
int min_num = 0;

if (num1 > num2)
{
    max_num = num1;
    min_num = num2;
}
else
{
    max_num = num2;
    min_num = num1;
}

Console.WriteLine("Максимальное число - {0}", max_num);
Console.WriteLine("Минимальное число - {0}", min_num);


