// Написать программу, которая из имеющегося массива строк сформирует массив из строк,
// длина которых меньше или равна 3 символа

void ThreeSymbol(string[] arr1, string[] arr2)
{
    int count = 0;
    for (int i = 0; i < arr1.Length; i++)
    {
        if (arr1[i].Length <= 3)
        {
            arr2[count] = arr1[i];
            count++;
        }
    }
}
void PrintArray(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

string[] arr1;
Console.WriteLine("Введите массив строк через пробел:");
string stroka = Console.ReadLine();
arr1 = stroka.Split(' ');
string[] arr2 = new string[arr1.Length];
ThreeSymbol(arr1, arr2);
PrintArray(arr2);
