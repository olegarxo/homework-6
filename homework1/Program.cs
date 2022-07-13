void printNumber(List<int> sumList)
{
    int index = 0;
    int length = sumList.Count;
    while(index < length)
    {
        Console.WriteLine(sumList[index]);
        index++;
    }
}
void enterNumber(List<int> sumList)
{
    string enterWord = string.Empty;
    List<int>numbers = new List<int>();
    int index = 0;
    Console.WriteLine("Вы хотите ввести число(да или нет)");
    enterWord = Console.ReadLine();
    string lowWord = enterWord.ToLower();
    Console.WriteLine(lowWord);
    while(true)
    {
        if(lowWord == "да")
        {
            Console.Write("Вводите: ");
            numbers[index]=Convert.ToInt32(Console.ReadLine());
            index++;
        }
        else if(lowWord == "нет")
        {
            Console.WriteLine("Хорошо, вот ваши цифры: ");
        }
        else
        {
            Console.WriteLine("Вы ввели некоректное слово, попробуйте еще раз ");
            break;
            
        }
    }
}
List<int> newList = new List<int>();
Console.WriteLine("Введите числа ");
enterNumber(newList);
printNumber(newList);
