// Задача 29: Напишите программу, которая задаёт массив из 8 элементов 
//и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]
void PrintArray(int[] coll)
{
  int count = coll.Length;
  int index = 0;
  Console.Write("[");
  while(index < count)
  {
    Console.Write(coll[index]);
    index++;
    if (index < count)
    {
      Console.Write(", ");
    }
  }
  Console.Write("]");
} 

int[] ArrayOfNumbers(string line)
{ 
  int[] arrayOfNumbers = new int[1];    

  int j =0;

  for (int i = 0; i < line.Length; i++)
  {
    string line1 = "";

    while (line[i] != ',' && i < line.Length)
    {
       line1 += line[i];
       i++;
    }
    arrayOfNumbers[j] = Convert.ToInt32(line1);   
    if (i < line.Length-1)
    {
      arrayOfNumbers = arrayOfNumbers.Concat(new int[] {0}).ToArray(); 
    }
    j++;
  }
  return arrayOfNumbers;
}
Console.Write("Введите числа, разделяя их запятой : ");
string? seriesOfNumbers = Console.ReadLine()+ ",";
int[] arrayOfNumbers =  ArrayOfNumbers(seriesOfNumbers);
PrintArray(arrayOfNumbers);