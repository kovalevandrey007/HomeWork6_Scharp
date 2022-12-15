/*Задача 43: Напишите программу, 
которая найдёт точку пересечения 
двух прямых, заданных уравнениями 
y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 
задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)*/

//получение числа с консоли, для того, чтобы задать размерность массива
double GetNumberFromConsole(string message)
//проверка на число на валидацию
{
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
double b1 = GetNumberFromConsole("введите значение b1:");
double k1 = GetNumberFromConsole("введите значение k1: ");
double b2 = GetNumberFromConsole("введите значение b2:");
double k2 = GetNumberFromConsole("введите значение k2:");

double x = (b2-b1)/(k1-k2);
double y = k1*x+b2;

Console.WriteLine($"Tочка пересечения двух прямых = ({x}; {y})");
