// Программа, которая на вход принимаеи число (N), 
// а на выходе показывает все четные числа от 1 до N

Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
 for (int count = 1; count <= N; count++)
 {
    if (count % 2 == 0)
    {
        Console.WriteLine($"Четное число - {count}");
    }
 }

