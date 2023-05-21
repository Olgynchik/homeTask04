// Задача 29: Напишите программу, которая задаёт массив из 8 элементов
//  и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

class Program
{
    public static void Main(String[] args)
    {
        Console.Write("Введите длину массива: ");
        int size = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите левую границу массива: ");
        int left = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите правая границу массива: ");
        int right = Convert.ToInt32(Console.ReadLine());

        int[] nums = GetRandomArray(size, left, right);

        WriteArray(nums);
        //Console.WriteLine(nums);
    }

    public static int[] GetRandomArray(int size, int left, int right)
    {
        Random rand = new Random();
        int[] nums = new int[size];

        for (int i = 0; i < size; i++)
        {
            nums[i] = rand.Next(left, right);
        }

        return nums;
    }

    public static void WriteArray(int[] input)
    {
        for (int i = 0;i < input.Length;i++)
        {
            Console.Write(input[i] + " ");
        }
        Console.WriteLine();
    }
}