void Task34(int TaskNumber,int ArraySize)
{
    int Result=0;
    int[] myArray=MakeArray(TaskNumber,ArraySize);
    for (int counter=0; counter<ArraySize; counter++)
    {
        if (myArray[counter]%2==0)
           Result++;
    }
    Console.WriteLine();
    Console.WriteLine("Macсив содержит {0} четных чисел", Result);
}
void Task36(int TaskNumber,int ArraySize)
{
    int Result=0;
    int[] myArray=MakeArray(TaskNumber,ArraySize);
    for (int counter=0; counter<ArraySize; counter=counter+2)
    {
        Result=Result+myArray[counter];
    }
    Console.WriteLine();
    Console.WriteLine("Сумма элементов на нечетных позициях  {0}", Result);
}
void Task38(int TaskNumber,int ArraySize)
{
    int[] Arr=MakeArray(TaskNumber,ArraySize);
    double[] myArray= Array.ConvertAll(Arr, x=>(double)x);
    double min=myArray[0];
    double max=myArray[0];
    for (int counter=0; counter<(ArraySize-1); counter++)
    {
        double tmp=myArray[counter];
        if (min>tmp)
            min=tmp;
        if (max<tmp)
            max=tmp;        
    }
    Console.WriteLine();
    Console.WriteLine("Разница между максимальным и минимальным размером массива:  {0}", (max-min));
}
int[] MakeArray(int TaskNumber, int ArraySize)
{
    int[] myArray=new int[ArraySize];
    Random temp=new Random();
    Random sign=new Random();
    for (int counter=0; counter<
    ArraySize; counter++)
    {
        switch (TaskNumber)
        {
            case 34:
                myArray[counter]=temp.Next(100,1000);
            break;
            case 36:
                if (sign.Next(-1,1)==0)
                    myArray[counter]=temp.Next(); // здесь ставил тестовый диапазон поменьше
                else
                    myArray[counter]=(-1)*temp.Next(); // здесь ставил тестовый диапазон поменьше
            break;
            case 38:
                myArray[counter]=temp.Next(); //здесь логичней сразу делать temp.NextDouble и сразу посчитать в методе, а наружу передать мусор, но придется вывод в MakeArray городить, не стал так делать
            break;
        }
    Console.Write("  {0}  ",myArray[counter] );
    }
    return myArray;
}
// ======================ДЗ Семинар 5 Задачи 34 , 36 , 38===========================
// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
//            Напишите программу, которая покажет количество чётных чисел в массиве.
//            Пример [345, 897, 568, 234] -> 2
// Задача 36: Задайте одномерный массив, заполненный случайными числами.
//            Найдите сумму элементов, стоящих на нечётных позициях.
//            Пример [3, 7, 23, 12] -> 19 ; [-4, -6, 89, 6] -> 0
// Задача 38: Задайте массив вещественных чисел.
//            Найдите разницу между максимальным и минимальным элементов массива.
//            Пример [3 7 22 2 78] -> 76
Console.WriteLine("Семинар 5 ДЗ: Задачи 34 , 36 , 38");
Console.Write("Какую задачу будем решать? Введите номер:  ");
int TaskNumber =Convert.ToInt32(Console.ReadLine());
Console.Write("Введите размер массива:  ");
int ArraySize =Convert.ToInt32(Console.ReadLine());
switch (TaskNumber)
{
    case 34:
        Console.WriteLine(" Задача 34: массив заполнен случайными положительными трёхзначными числами.Покажем количество чётных чисел в массиве.");
        Task34(TaskNumber, ArraySize);
    break;
    case 36:
        Console.WriteLine("Задача 36:массив заполнен случайными числами.Найдем сумму элементов, стоящих на нечётных позициях.");
        Task36(TaskNumber, ArraySize);
    break;
    case 38:
        Console.WriteLine("Задача 38:массив вещественных чисел.Найдем разницу между максимальным и минимальным элементами массива.");
        Task38(TaskNumber, ArraySize);
    break;
    default:
        Console.WriteLine("Не хочешь решать - досвидос!");
    break;
}
