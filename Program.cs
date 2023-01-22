// Задача 4: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8
int InputInt(string massage)
{
    Console.WriteLine(massage);
    int x = Convert.ToInt32(Console.ReadLine());
    return x;
}
int n = InputInt("Введите число");
for (int i = 1; i <= n; i++)
{
    if (i % 2==0)
    {
    Console.Write(i);
    }
else {
    Console.Write(" ");
}
}
