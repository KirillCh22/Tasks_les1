Console.Write("Введите число - ");
int num = Convert.ToInt32(Console.ReadLine());

for (int N = 1; N <= num; N++)
{
    int num_new = N % 2;
    if (num_new == 0) Console.Write(N + " ");
}
