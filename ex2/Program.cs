// Задача 27: Напишите программу, которая принимает на вход число и
// выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12
int SumOfNumber(int num)
  {
    int res = 0;
    int sum = 0;
    int count = Convert.ToString(num).Length;
    for (int i = 0; i < count; i++)
    {
      res = num - num % 10;
      sum = sum + (num - res);
      num = num / 10;
    }
   return sum;
  }
Console.WriteLine("Введите число:");
int num = Convert.ToInt32(Console.ReadLine());
int sumofnumber = SumOfNumber(num);
Console.WriteLine($"Сумма цифр в числе: {sumofnumber} ");