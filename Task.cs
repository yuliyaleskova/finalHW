// Test task. Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше или равна 3 символам. 
//Первоначальный массив ввести с клавиатуры или задать на старте.   
Console.WriteLine("This program create new string array where lenght of all string <= 3.");
Console.WriteLine();
int lenghtArray = EnterUserData("Enter lenght of your array: ");
Console.WriteLine();
Console.WriteLine("Enter your string array below.");
Console.WriteLine();
string[] inputArray = new string[lenghtArray];
FillArray(inputArray);
Console.WriteLine("Yours input array is:");
PrintArray(inputArray);
int resultArrayLenght = FilterArray(inputArray);
string[] resultArray = new string[resultArrayLenght];
int counter = 0;
for (int i = 0; i < inputArray.Length; i++)
{
    if (inputArray[i] != string.Empty)
    {
        resultArray[counter] = inputArray[i];
        counter++;
    }
}
Console.WriteLine();
Console.WriteLine("Yours array after filtration with basis = 3:");
PrintArray(resultArray);

int FilterArray(string[] array)
{
    int basis = 3;
    int counter = array.Length;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length > basis)
        {
            array[i] = string.Empty;
            counter--;
        }
    }
    return counter; //lenght of the result array
}

void FillArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Enter array element # {i + 1}: ");
        array[i] = Console.ReadLine();
        Console.WriteLine();
    }
}

int EnterUserData(string nameUserData)
{
    Console.Write($"{nameUserData}");
    return Convert.ToInt32(Console.ReadLine());
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}