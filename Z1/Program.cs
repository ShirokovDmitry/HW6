// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, 
// сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
 
Console.Write($"Введите количество чисел: ");
int num = Convert.ToInt32(Console.ReadLine());
int[] arrayNum = new int[num];
Random rand = new Random();
InputNumbers(num);
void InputNumbers(int num)
{
    for (int i = 0; i < arrayNum.Length; i++)
    {
        arrayNum[i] = rand.Next(-10, 10);
        Console.Write(" " + arrayNum[i]);
    }
}
 
int CountNum(int[] arrayNum)
{
    int count = 0;
    for (int i = 0; i < arrayNum.Length; i++)
    {
        if(arrayNum[i] > 0 ) count += 1; 
    }
    return count;
}
 
Console.WriteLine();
Console.WriteLine($"Чисел больше 0: {CountNum(arrayNum)} ");
