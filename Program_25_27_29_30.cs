/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16

Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12

Задача 29: Напишите программу, которая задаёт массив из N элементов, заполненных случайнми числами из [a, b) и выводит их на экран.

5, 0, 20 -> [1, 2, 5, 7, 19]
3, 1, 35 -> [6, 1, 33]

Задача “со звездочкой”: Напишите функцию, которая принимает одно число - высоту елочки и рисует ее в консоли звездочками.
*/


Console.WriteLine("Введите номер задачи: 25,27,29 или 30 (задача со звездочкой):");
int num = Convert.ToInt32(Console.ReadLine());

switch (num)
{

case 25: 
    {
        Console.WriteLine("Введите число a:");
        Console.Write("a= "); int a = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("Введите число b:");
        Console.Write("b= "); int b = Convert.ToInt32(Console.ReadLine());

        int c=1;
        int ch=1;
        do  
        {
            c=c*a;
            c++;
        } while (ch <= b);
        Console.Write($"a в степени b = {c}");

        break;    
    } //Zadacha 25

case 27:
    {
        Console.WriteLine("Введите натуральное число a:");
        Console.Write("a= "); int a = Convert.ToInt32(Console.ReadLine());

        int sum = 0;
        int i=10;
        int ch=1;

        do
        {
          sum = sum + (a % i)/(i/10);
          i=i*10;
          ch++;
        } while (ch <= a.ToString().Length);

        Console.Write($"сумма цифр числа а = {sum}");

        break;
    } //Zadacha 27
  
case 29:
    {
        Console.WriteLine("Введите натуральное число a:");
        Console.Write("a= "); int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите натуральное число b:");
        Console.Write("b= "); int b = Convert.ToInt32(Console.ReadLine());        
        Console.WriteLine("Введите целое число N:"); int N = Convert.ToInt32(Console.ReadLine());

        int[] nums = new int[N];
        if (a > b) {int old = a; a=b; b=a;}
        int ch=1; 
        int rnd;

        do
        {
          Random rand = new Random();
          rnd = rand.Next (a, b);
          Console.Write($"rnd_{ch} = "); Console.Write($"{rnd}; ");   
        ch++;
        } while (ch <= N);
        
        break;    
    } //Zadacha 29

case 30:
    {
        Console.Clear();
        Console.WriteLine("Введите высоту елки в имволах:"); int N = Convert.ToInt32(Console.ReadLine());
        if (N >= Console.WindowHeight) {N = Console.WindowHeight-1;}
        int ww = Console.WindowWidth;
        
        int ch=0;
        int ch1=0;
        do
        {
            Console.SetCursorPosition (ww/2-ch, ch);
            ch1=0;
            do 
            {
                Console.Write("*"); 
                ch1++;   
            } while (ch1<=ch*2+1);


            ch++;    
        } while (ch <= N);

        
        



        break;    
    } //Zadacha 30


}