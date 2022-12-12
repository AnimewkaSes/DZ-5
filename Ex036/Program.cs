internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Введите количество генерируемых чисел: ");
        int n = Convert.ToInt32(Console.ReadLine());
        int[] arr = new int[n];
        int result = 0;
        Random rnd = new Random();
        Console.Write("Сгенерируемый массив: ");
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = rnd.Next(-20, 20);
        }

        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write("{0}, ", arr[i]);
        }

        for (int i = 0; i < arr.Length; i++)
        {
            if(i%2!=0)
            {
                result +=arr[i]; 
            }

        }
        Console.WriteLine("\nСумма элементов с нечётными индексами {0}",result);

    }
}