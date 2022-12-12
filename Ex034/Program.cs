internal class Program
{
private static void Main(string[] args)
{
Console.WriteLine("Программа для поиска количесвта четных чисел в массиве");
Console.Write("Введите размер массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int result = 0;
int [] arr = new int [n];
Random rnd = new Random();
Console.Write("Массив: ");
for (int i = 0; i < arr.Length; i++)
{
arr[i] = rnd.Next(100,999);
Console.Write("{0} ",arr[i]);
}

for (int i = 0; i < arr.Length; i++)
{
if (arr[i]%2==0)
{
result +=1;
}
}
Console.WriteLine("\nКоличество чётных чисел в массиве -> {0}",result);
}
}