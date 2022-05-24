// Напишите цикл, который принимает на вход два числа (A и B) 
//и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

int main(int numA,int numB) 
{
    int power = 1;
    for (int i = 0; i < numB; i++)
    {
        power *= numA;
    }
    Console.WriteLine($"Ваше число {numA} в степени {numB} равно {power}");
    return power;
}
Console.WriteLine("Введите число");
int numA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите степень числа");
int numB = Convert.ToInt32(Console.ReadLine());
main(numA,numB);