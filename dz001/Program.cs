//Напишите программу которая принимает на вход два числа А и Б и возводит А в степень Б

int MyNum(string masage)
    {
        Console.WriteLine(masage);
        return Convert.ToInt32(Console.ReadLine());
    }

int A = MyNum("Enter the number A");
int B = MyNum("Enter the number B");
int result = 1;
for (int i = 1;i <= B; i++)
    {
        result = result * A;
    }
Console.WriteLine(result);

// Программа принимает на ввод число и выдает сумму  всех цифр числа

int SumDigits(int n)
{
    int sum = 0;
    while (n != 0)
    {
        sum += n % 10;
        n /= 10;
    }
    return sum;
}
Console.WriteLine("Enter the number ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(SumDigits(num));

// программа которая задает массив и выводит его на экран

Console.WriteLine("Enter the array lenght: ");
int arrlen = Convert.ToInt32(Console.ReadLine());
int[] Array = new int[arrlen];
for(int i = 0; i < Array.Length; i++)
{
    Console.Write($"Enter array elements for index {i}: ");
    Array[i] = Convert.ToInt32(Console.ReadLine());
}
for(int i = 0; i < Array.Length; i++)
{
    Console.Write(Array[i] + " ");
}