int a = Convert.ToInt32(Console.ReadLine());
int m = Convert.ToInt32(Console.ReadLine()); // Числовой диапазон
int[] arr = new int [a];
 for( int i = 0; i < a; i++)
{
 arr[i] = new Random().Next(1, m);
 Console.Write(arr[i] + " ");
}
Console.WriteLine(" ");

        int[] copy = new int[a];
        arr.CopyTo(copy, 0);
        Console.WriteLine("Вывод скопированного массива: ");
        Console.WriteLine(String.Join(" ", copy));
