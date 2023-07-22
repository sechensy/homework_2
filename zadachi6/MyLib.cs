namespace MyLib;

public static class MyLibClass
{
    public static int Input(string text)
    {
        Console.Write(text);
        return Convert.ToInt32(Console.ReadLine());
    }

    public static void PrintAr(int[] numbers)
    {
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write($"{numbers[i]} ");
        }
        Console.WriteLine();
    }


}
