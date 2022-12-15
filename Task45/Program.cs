/*Задача 45: Напишите программу, которая будет 
cоздавать копию заданного массива 
с помощью поэлементного копирования.*/

//получение числа с консоли, для того, чтобы задать размерность массива
int GetNumberFromConsole(string message)
//проверка на валидацию
{
    bool isCorrect = false;
    int result = 0;
    while(!isCorrect)
    {
        Console.WriteLine(message);

    if(int.TryParse(Console.ReadLine(), out result) )
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

//создаем массив
int[] InitArray(int size)
{
    int[] array = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(-20,20);
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

int size = GetNumberFromConsole("Введите размерность массива");
int[] myArray = InitArray(size);
Console.WriteLine("Созданный массив");
PrintArray(myArray);

//копируем массив с помощью Array.Copy
int[] copy = new int[myArray.Length];
Array.Copy(myArray, copy, myArray.Length);
Console.WriteLine("Скопированный массив");
PrintArray(copy);
