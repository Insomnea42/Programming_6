// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.WriteLine("Введите длину массива M: ");
int m = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[m];
int chislo = 0;
Console.WriteLine("Введите элементы массива: ");
for (int i = 0; i < m; i++)
{
    arr[i] = Convert.ToInt32(Console.ReadLine());
    if (arr[i] > 0) chislo++;
}
Console.WriteLine("Количество элементов больше нуля: " + chislo);
