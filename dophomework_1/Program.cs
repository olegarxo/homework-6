
void enterRandomNumber(int[] sumMassive)
{
    Random random = new Random();
    int index = 0;
    int length = sumMassive.Length;
    while(index < length)
    {
        sumMassive[index] = random.Next(1,10); 
        index++;
    }
}
void printNumber(int[] sumMassive)
{
    int index = 0;
    int length = sumMassive.Length;
    while(index < length)
    {   if(index < length -2)Console.Write($"{sumMassive[index]},");
        else if (index == length-1)Console.Write($"{sumMassive[index]}.");
        index++;  
    }
}
int[] convertInt(string number)
{
    int index = 0;
    int length = number.Length;
    int[] numbers = new int[length];
    while(index < length)
    {
        numbers[index] = number[index];
        index++;
    }
    return numbers;
}
string findNumber(int[] sumMassive, string findSequence)
{
    int index = 0;
    string ansver = string.Empty;
    int j =1;
    int length = sumMassive.Length;
    int lengthOne = findSequence.Length;
    int[] Sequence = new int[length];
    Sequence = convertInt(findSequence);
        for(int i = 0; i < length; i++)
        {
            if(sumMassive[i] == Sequence[0])
            {
                while(j < lengthOne && i+lengthOne <= length )
                {
                    if(sumMassive[i+j] == Sequence[0+j])
                    {
                        ansver = $"Начиная с {i} элемента массивы совпадают";
                    }
                    else
                    {
                        ansver = $"Совпадений нет";  
                        break;
                    }
                    j++;
          
                }
            }
            i++;

        }
    return ansver;    
}
Random random = new Random();
int[] numbers = new int[15];
enterRandomNumber(numbers);
printNumber(numbers);
Console.WriteLine("Введите последовательность");
Console.Write("Последовательность: ");
string ansver = Console.ReadLine();
string end = findNumber(numbers,ansver);
Console.WriteLine(end);
        

        
