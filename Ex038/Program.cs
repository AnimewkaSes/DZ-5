internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Размер массива вещественных чисел");
        Console.Write("Введите размер массива: ");
        int n = Convert.ToInt32(Console.ReadLine());
        double [] arr = new double[n];
        double result;
        Random rnd = new Random();
        

        for (int i = 0; i < arr.Length; i++)
        {
            arr[i]=Math.Round(rnd.NextDouble()*100,2);
            Console.Write("{0} ",arr[i]);
        }

        double minValue = arr.Min();
        double maxValue = arr.Max();
        
        Console.WriteLine("\nСумма максимального и минимального элемента массива = {0}",result = minValue+maxValue);
        



    }
}