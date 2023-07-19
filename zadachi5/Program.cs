using MyLib;

namespace zadachi5;

class Program
{
    static void Main(string[] args)
    {
        //Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
        //Напишите программу, которая покажет количество чётных чисел в массиве.
        void Task34()
        {
            int size = MyLibClass.Input("Введите размер массива: "); ;
            int[] numbers = new int[size];
            int start_number = 100;//левая граница в диапазоне случайных чисел
            int finish_number = 1000;//правая граница в диапазоне случайных чисел
            int amount = 0;

            MyLibClass.FillArr(numbers, start_number, finish_number);

            Console.Write("Заполненный массиве: ");
            MyLibClass.PrintAr(numbers);

            Console.Write("Четные числа в массиве: ");
            for (int i = 0; i < size; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    Console.Write($"{numbers[i]} ");
                    amount++;
                }
            }
            Console.WriteLine();
            Console.Write($"Количество четных чисел в массиве равно {amount}");
        }

        //Задача 36: Задайте одномерный массив, заполненный случайными числами. 
        //Найдите сумму элементов с нечётными индексами.
        void Task36()
        {
            int size = MyLibClass.Input("Введите размер массива: ");
            int[] arr = new int[size];
            int sum = 0;
            int start_number = -10;
            int finish_number = 10;

            MyLibClass.FillArr(arr, start_number, finish_number);

            Console.Write("Заполненный массиве: ");
            MyLibClass.PrintAr(arr);

            Console.Write("Элементы с нечётными индексами: ");
            for (int i = 0; i < size; i++)
            {
                if (i % 2 != 0)
                {
                    sum = sum + arr[i];
                    Console.Write($"{arr[i]} ");
                }
            }

            Console.WriteLine();
            Console.WriteLine($"Сумма элементов с нечетными индексами равна {sum}");
        }

        //Задача 38: Задайте массив вещественных чисел. 
        //Найдите разницу между максимальным и минимальным элементами массива.
        void Task38()
        {
            int size = MyLibClass.Input("Введите размер массива: ");
            double[] arr = new double[size];

            Random rnd = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToDouble(rnd.Next(-10000, 10000)/100.0);
            }

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]} ");
            }
            Console.WriteLine();

            double max = arr[0];
            double min = arr[0];
            double razn;

            for (int j = 0; j < arr.Length; j++)
            {
                if (arr[j] > max) max = arr[j];
                if (arr[j] < min) min = arr[j];
            }

            razn = max - min;
            Console.Write($"Разница между максимальным и минимальным элементами массива равна {razn}");

        }

        int zadacha = MyLibClass.Input("Введите номер задачи (34,36,38) или любое другое число для выхода: ");
        switch (zadacha)
        {
            case 34:
                Console.WriteLine("Задача 34. Количество четных чисел в массиве");
                Task34();
                break;
            case 36:
                Console.WriteLine("Задача 36. Сумма элементов с нечетными индексами");
                Task36();
                break;
            case 38:
                Console.WriteLine("Задача 38.Разница между максимальным и минимальым элементами массива");
                Task38();
                break;
            default:
                Console.WriteLine("выход");
                break;
        }
    }
}
