// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
int n = 3;
string[] words = new string[n];
Console.WriteLine("Введите исходный массив");
for (int i = 0; i<n; i++) {
    words[i] = Console.ReadLine();
}

string[] filteredWords = FilterArray(words);

Console.WriteLine("Отфильтрованный массив:");
for (int i=0;i<filteredWords.Length;i++) {
    Console.WriteLine(filteredWords[i]);
}

string[] FilterArray(string[] array) {
    int n = 0;
    for (int i =0 ;i<array.Length;i++) {
        if (array[i].Length<=3) {
            n++;
        }
    }
    string[] filtered = new string[n];
    int fileteredIndex = 0;
    for (int i=0;i<array.Length;i++) {
        if (array[i].Length<=3) {
            filtered[fileteredIndex] = array[i];
            fileteredIndex++;
        }
    }
    return filtered;
}