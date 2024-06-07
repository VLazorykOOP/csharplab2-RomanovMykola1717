using System;

class Program
{
    static void Main()
    {
        // Генеруємо випадковий масив
        Random rand = new Random();
        int arraySize = 20; // Розмір масиву
        int[] array = new int[arraySize];
        for (int i = 0; i < arraySize; i++)
        {
            array[i] = rand.Next(1, 101); // Випадкові числа від 1 до 100
        }

        // Виводимо масив
        Console.WriteLine("Згенерований масив:");
        foreach (int num in array)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();

        // Знаходимо мінімальний елемент
        int minElement = array[0];
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] < minElement)
            {
                minElement = array[i];
            }
        }

        // Знаходимо номер останнього мінімального елемента
        int lastIndex = -1;
        for (int i = array.Length - 1; i >= 0; i--)
        {
            if (array[i] == minElement)
            {
                lastIndex = i;
                break;
            }
        }

        // Вивід результату
        Console.WriteLine($"Мінімальний елемент: {minElement}");
        Console.WriteLine($"Номер останнього мінімального елемента: {lastIndex}");
    }
}
