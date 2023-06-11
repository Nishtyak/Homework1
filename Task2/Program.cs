// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

int count = 3;
string arrs;
int[] numbers = new int[count];
Console.Write("Введите цифры через пробел: ");
arrs = Console.ReadLine();
var massiv = arrs.Split(' ');
for(int i = 0; i < massiv.Length; i++)
{
    numbers[i] = int.Parse(massiv[i]);
}

int max = numbers[0];

for(int i = 1; i < numbers.Length; i++)
{
    if(max < numbers[i])
    {
        max = numbers[i];
    }
}

Console.Write("максимальное число: " + max);

