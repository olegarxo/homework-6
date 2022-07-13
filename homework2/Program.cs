void intersectionPoint(double[] sumMassive,double b1,double b2,double k1,double k2)
{
    //y = k1 * x + b1
    //y = k2 * x + b2
    //((k1 - k2)*x) == -(b1 - b2);
    int length = sumMassive.Length;
    double x=(b2-b1)/(k1-k2);
    double y = (k2*x)+b2;
    sumMassive[0] = x;
    sumMassive[1] = y;
}
void printMassive(double[] sumMassive)
{
    int index = 0;
    int length = sumMassive.Length;
    Console.Write("Координаты точки пересечения: ");
    while(index<length)
    {
        if(index == 0)
        {
            Console.Write($"({Math.Round(sumMassive[index],2)};");
        }
        else if (index ==1)
        {
             Console.Write($"{Math.Round(sumMassive[index],2)})");
        }
        index++;
    }
}
double b1 = 0;
double b2 = 0;
double k1 = 0;
double k2 = 0;
double[] sumMassive = new double[2];
Console.WriteLine("Даны отрезки y = k1 * x + b1, y = k2 * x + b2");
Console.WriteLine("Введите b1");
b1= int.Parse(Console.ReadLine());
Console.WriteLine("Введите b2");
b2= int.Parse(Console.ReadLine());
Console.WriteLine("Введите k1");
k1= int.Parse(Console.ReadLine());
Console.WriteLine("Введите k2");
k2= int.Parse(Console.ReadLine());
intersectionPoint(sumMassive,b1,b2,k1,k2);
printMassive(sumMassive);

