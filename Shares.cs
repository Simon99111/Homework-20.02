public class Shares
{
    public static void Power()
    {
        Console.Write("A = ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.Write("B = ");
        int b = Convert.ToInt32(Console.ReadLine());
        int c = 1;
        for (int i = 0; i < b; i++)
        {
            c = c * a;
        }
        Console.WriteLine(c);
    }


    public static void Summ()
    {
        Console.WriteLine("Введите число");
        int number = Convert.ToInt32(Console.ReadLine());
        int sum = 0;

        while (number > 0)
        {
            sum = sum + number % 10;
            number = number / 10;
        }
        Console.WriteLine(sum);
    }


    public static int MSG(string msg)
    {
        Console.WriteLine(msg);
        int result = Convert.ToInt32(Console.ReadLine());
        return result;
    }


    public static int[] Array(int size, int min, int max)
    {
        int[] arr = new int[size];
        for (int i = 0; i < size; i++)
        {
            arr[i] = new Random().Next(min, max);
        }
        return arr;
    }



    public static void Print(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i] + " ");
        }

    }
}