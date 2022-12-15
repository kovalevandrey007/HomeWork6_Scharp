/*Задача 41: Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3*/


//получение числа с консоли, для того, чтобы задать размерность массива
int GetNumberFromConsole(string message)
{
//проверка на валидацию
bool isCorrect = false;
int result = 0;

while(!isCorrect)
{
Console.WriteLine(message);

if(int.TryParse(Console.ReadLine(), out result))
{
isCorrect = true;
}
else
{
Console.WriteLine("Ввели не число. Введите число");
}
}
return result;
}
//метод, который будет выдавать заполненный массив случайными числами
int[] InitArray(int arr)
{
int[] array = new int[arr];
Random rnd = new Random();

for (int i = 0; i < arr; i++)
{
array[i] = rnd.Next(-10,10);
}
return array;
}

//метод, который будет печатать массив
void PrintArray(int[] array)
{
for (int i = 0; i < array.Length; i++)
{
Console.Write($"{array[i]} ");
}
Console.WriteLine();
}

//метод, который будет находить количество элементов массива, которые больше 0
int GetCountZero(int[] array)
{
int count = 0;
for (int i = 0; i < array.Length; i++)
{
    if(array[i] > 0)
    {
        array[count] = array[i];
        count++;
    }
}
return count;
}

int arr = GetNumberFromConsole("Введите размерность массива");
int[] startArray = InitArray(arr);
PrintArray(startArray);
int count = GetCountZero(startArray);
Console.WriteLine($"Количество чисел M больше 0 = {count}");
