/*
2. Напишите программу, которая на вход принимает число и выдает его квадрат (число умноженное на само себя).
    4 -> 16 
    -3 -> 9 
    -7 -> 49
*/
/*double a;
a = 10;
double res;
res = a*a;
Console.WriteLine(res);
*/


/*5. Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
    4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4" 
    2 -> " -2, -1, 0, 1, 2"
*/
Console.WriteLine("Введите число: ");

Console.ReadLine();
int num = Convert.ToInt32(Console.ReadLine());
int cur = -num;
while(cur <= num)
{
    Console.Write(cur + " ");
    cur++;
}
Console.WriteLine(cur);

