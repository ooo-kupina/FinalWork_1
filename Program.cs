Console.WriteLine($"\nДанная программа из имеющегося массива строк формирует массив из строк,");
Console.WriteLine("длина которых меньше либо равна 3 символа.");
Console.WriteLine($"\nПервоначальный массив задаёт пользователь\n");


string[] array = InputArray();
string[] result = FindArray(array, 3);
Console.WriteLine();
Console.WriteLine($"[{string.Join(", ", array)}] -> [{string.Join(", ", result)}]");
Console.WriteLine();

string[] FindArray(string[] input, int n)
{
    string[] output = new string[Counting(input, n)];

    for(int i = 0, j = 0; i < input.Length; i++)
    {
        if(input[i].Length <= n)
        {
            output[j] = input[i];
            j++;
        }
    }

    return output;
}

int Counting(string[] input, int n)
{
    int count = 0;

    for(int i = 0; i < input.Length; i++)
    {
        if(input[i].Length <= n)
        {
            count++;
        }
    }

    return count;
}

string[] InputArray()
{
    Console.Write("Введите значения через пробел: ");
    return Console.ReadLine().Split(" ");
}

