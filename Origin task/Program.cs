Console.Clear();

void ArrayOutput(string[] array)   // Вывод массива
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
        if (i == (array.Length - 1))
            Console.Write($"\"{array[i]}\"");
        else
            Console.Write($"\"{array[i]}\", ");
    Console.WriteLine("]");
}

void GenerateArrayFromKeyboard(string[] array) // Ввод массива с клавиатуры
{    
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Input {i + 1} element of array : ");
        string temp = new string(Console.ReadLine());
        if (String.IsNullOrWhiteSpace(temp))
        {
            Console.WriteLine("Empty value or null does not fit, re-enter");
            i -= 1;
        }
        else
            array[i] = temp;
    }
}

string[] CreateNewArrayWithLess3Chars(string[] array)  // Основной метод решения задачи
{
    int howManyCounter = 0;
    string[] newArray = new string[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        char[] splitToChars = array[i].ToCharArray();
        if(splitToChars.Length <= 3)
        {
            newArray[howManyCounter]= array[i];
            howManyCounter++;
        }
    }
    if(array.Length != howManyCounter)    
        Array.Resize(ref newArray, howManyCounter);
    return newArray;
}

Console.WriteLine("Hello Inspector! This program generates a new array of strings whose length is less than or equal to 3");
Console.Write("Input how many elements of strings being in array: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
if(n<0)
    n*=(-1);
string[] myArray = new string[n];
GenerateArrayFromKeyboard(myArray);
Console.Write("\nYour input array: ");
ArrayOutput(myArray);
Console.Write("Array, after program runing: ");
ArrayOutput(CreateNewArrayWithLess3Chars(myArray));
