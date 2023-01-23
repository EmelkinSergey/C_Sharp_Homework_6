// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

int[] CreateArray()
{
    Console.WriteLine("Введите количество чисел");
    int size = Convert.ToInt32(Console.ReadLine());
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {   
        Console.WriteLine($"Введите {i+1} элемент массива");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

void ShowArray(int[] array){
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int [] Array = CreateArray();
ShowArray(Array);

int CountPositiveNumbers(int [] array)
{
    int count = 0;
    for(int i=0;i<array.Length; i++)
    {
        if (array[i]>0)
        count = count+1; 
    }
    return count;
}

int count = CountPositiveNumbers(Array);
Console.WriteLine($"Количество положительных чисел = {count}");