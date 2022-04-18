int[,] CreateTriangle(int size)
{
    int[,] triangle = new int[size, size];
    for (int i = 0; i < size; i++)
    {
        triangle[i, 0] = 1;
        triangle[i, i] = 1;
    }
    for (int i = 2; i < size; i++)
    {
        for (int j = 1; j < size; j++)
        {
            triangle[i, j] = triangle[i - 1, j - 1] + triangle[i - 1, j];
        }
    }
    return triangle;
}

void PrintTriangle(int[,] array)
{   
    for (int i = 0; i < array.GetLength(0); i++)
    {
        string text = "     ";
        for (int j = 0; j < i + 1; j++)
        {
            text = text + Convert.ToString(array[i, j]) + "     ";
        }
        int startPrintPosition = (Console.WindowWidth - text.Length) / 2;
        Console.SetCursorPosition(startPrintPosition, i + 5);
        Console.WriteLine(text);   
        Console.WriteLine();     
    }
    Console.WriteLine();     
}

Console.WriteLine("Введите требуемое количество строк треугольника Паскаля:");
int height = Convert.ToInt32(Console.ReadLine());
int[,] array = CreateTriangle(height);
Console.Clear();
PrintTriangle(array);