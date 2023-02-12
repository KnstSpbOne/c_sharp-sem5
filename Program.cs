int[] MakeArray(int TaskNumber, int ArraySize)
{
    int[] Array=new int[ArraySize];
    Random temp=new Random;
    Random sign=new Random;
    for (int counter=0; counter<ArraySize; counter++)
    {
        switch (TaskNumber)
        {
            case 34:
                Array[counter]=temp.Next(100,1000);
            break;
            case 36:
                if (sign.Next(-1,1)==0)
                    Array[counter]=temp.Next();
                else
                    Array[counter]=(-1)*temp.Next();
            break;
            case 38:
                Array[counter]=temp.Next();
            break;
        }
    }
    return Array[];
}
void Task34()
{
    int[] Array=MakeArray(TaskNumber,ArraySize);
    for (int counter=0, int Result=0; counter<ArraySize-1; counter++)
    {
        if (Array[counter]%2==0)
            Result++;
    }
    Console.WriteLine("Macсив содержит {0} четных чисел", Result);
}
void Task36()
{
    int[] Array=MakeArray(TaskNumber,ArraySize);
    for (int counter=0, int Result=0; counter<ArraySize-1; counter+2)
    {
        Result=Result+MakeArray[counter];
    }
    Console.WriteLine("Сумма элементов на нечетных позициях  {0}", Result);
}
void Task38()
{
    double[] Array=Convert.ToDouble(MakeArray(TaskNumber,ArraySize));

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
    case 34: Task34();
    break;
    case 36: Task36();
    break;
    case 38: Task38();
    break;
    default
        Console.WriteLine("Не хочешь решать - досвидос!");
    break;
}
