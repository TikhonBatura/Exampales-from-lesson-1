// алгоритм методом выбора, методом минимакса 
// или метод максимального, 
// или выбор максимального 
// или выбора минимального и так далее.

// Есть какая-то последовательность чисел. 
// Наша задача — выбрать самый первый элемент и в оставшейся части, 
// с учётом нашей текущей позиции определить минимальный. 
// После того как он найден, нужно поменять выделенный (рабочий элемент), 
// с единицей, являющейся для нас минимальной, в общем, выделенном куске

// Было: 6 8 3 2 1 4 5 7
// Стало: 1 2 3 4 5 6 7 8

int[] arr = {1, 5, 4, 3, 2, 6, 7, 1, 1};

void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i=0; i<count; i++)
    {
        Console.Write($"{array[i]}");
    }
    Console.WriteLine();
}
void selectionSort(int[] array)
{
    for (int i = 0; i < array.Length-1; i++)
    {
        int minPosition = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if(array[j] < array[minPosition]) minPosition = j;
        }
        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }

}

PrintArray(arr);
selectionSort(arr);
PrintArray(arr);
