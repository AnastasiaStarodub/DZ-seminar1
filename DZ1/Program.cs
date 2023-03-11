//Программа, которая на вход принимает два числа и выдает,
//какое число большее, а какое меньшее

Console.Write("Введите число1: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число2: ");
int number2 = Convert.ToInt32(Console.ReadLine());

int max = number1;
int min = number1;

if (number1 > number2)
{
     Console.WriteLine($"Максимальное число - {max = number1}");
     Console.WriteLine($"Минимальное число - {min = number2}");
}
else
{
     Console.WriteLine($"Максимальное число - {max = number2}");
     Console.WriteLine($"Минимальное число - {min = number1}");
}



