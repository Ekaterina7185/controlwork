Console.Clear();
Console.Write("Введите элементы массива через пробел: ");
string array = Console.ReadLine()!;
string[] n_array = array.Split(' ');
string[] new_array = new string[array.Length];

void SecondArray(string[] n_array, string[] new_array)
{
    int count = 0;
    for (int i = 0; i < n_array.Length; i++)
    {
    if(n_array[i].Length <= 3)
        {
            count++;
        }
    }
}
void PrintArray(string[] new_array)
{
    int index = 0;
        for (int i = 0; i < n_array.Length; i++)
        {
            if (n_array[i].Length <= 3)
            {
                new_array[index] = n_array[i];
                index++;
            }
        }

        return;
    }

SecondArray(n_array, new_array);
PrintArray(new_array);
Console.WriteLine(string.Join(" ",new_array));