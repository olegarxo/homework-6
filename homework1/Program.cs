void enterMassiveNumber(int[] sumMassive)
{
    int index = 0;
    int length = sumMassive.Length;
    while(index < length)
    {
        Console.Write($"Введите {index + 1} число ");
        sumMassive[index] = int.Parse(Console.ReadLine());
        index++;
    }
}
void outNumber(int[] sumMassive)
{
    int index = 0;
    int length = sumMassive.Length;
    int count = 0;
    Console.WriteLine("Вы ввели: ");
    while(index < length)
    {   
        Console.Write($"{sumMassive[index]}    ");
        index++;
    }
}
int countPositive(int[] sumMassive)
{
    int index = 0;
    int length = sumMassive.Length;
    int count = 0;
    while(index < length)
    {   
        if(sumMassive[index] > 0)
        {
            count++;
        }
        index++;
    }
    return count;
}
int amount = 0;
int count = 0;
Console.WriteLine("Сколько чисел вы хотитк ввести? Напишите число");
Console.Write("Число: ");
amount = Convert.ToInt32(Console.ReadLine());
int[] number = new int[amount];
enterMassiveNumber(number);
outNumber(number);
count = countPositive(number);
Console.Write($" Количество положительных чисел-> {count}");



// void printNumber(List<int> sumList)
// {
//     int index = 0;
//     int length = sumList.Count;
//     while(index < length)
//     {
//         Console.WriteLine(sumList[index]);
//         index++;
//     }
// }
// void enterNumber(List<int> sumList)
// {
//     string enterWord = string.Empty;
//     List<int>numbers = new List<int>(4);
//     int index = 0;
//     Console.WriteLine("Вы хотите ввести число(да или нет)");
//     enterWord = Console.ReadLine();
//     string lowWord = enterWord.ToLower();
//     Console.WriteLine(lowWord);
//     while(lowWord == "да")
//     {
//         if(lowWord == "да")
//         {
//             Console.Write("Вводите: ");
//             numbers[index]=Convert.ToInt32(Console.ReadLine());
//             index++;
//         }
//         else if(lowWord == "нет")
//         {
//             Console.WriteLine("Хорошо, вот ваши цифры: ");
            
//         }
//         else
//         {
//             Console.WriteLine("Вы ввели некоректное слово, попробуйте еще раз ");
//             break;
            
//         }
//     }
//     printNumber(numbers);
// }
// List<int> newList = new List<int>();
// Console.WriteLine("Введите числа ");
// enterNumber(newList);

