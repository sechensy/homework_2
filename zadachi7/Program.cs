using MyLib;
namespace zadachi7;

class Program
{
    static void Main(string[] args)
    {
        //Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами, 
        //округлёнными до одного знака.
        void Task47()
        {
            int m = MyLibClass.Input("Количество строк в матрице: "); ;
            int n = MyLibClass.Input("Количество столбцоы в матрице: "); ;
            double[,] matrix = new double[m, n];
            MyLibClass.FillArray(matrix, -20, 20);
            MyLibClass.PrintArray(matrix);
        }
        //Задача 50. Напишите программу, которая на вход принимает индексы элемента в двумерном массиве, 
        //и возвращает значение этого элемента или же указание, что такого элемента нет.
        void Task50()
        {
            int rows = MyLibClass.Input("Количество строк в матрице: ");
            int cols = MyLibClass.Input("Количество столбцоы в матрице: ");
            int first = MyLibClass.Input("Первый индекс: ");
            int second = MyLibClass.Input("Второй индекс: ");

            int[,] matrix = new int[rows, cols];
            MyLibClass.FillArray(matrix);
            MyLibClass.PrintArray(matrix);
            if (first < rows && second < cols)
            {
                Console.WriteLine($"элемент с индексами {first} и {second} равен {matrix[first, second]}");
            }
            else Console.WriteLine("Элемента с такими индексами нет");

        }

        //Задача 52. Задайте двумерный массив из целых чисел. 
        //Найдите среднее арифметическое элементов в каждом столбце.
        void Task52()
        {
            int rows = MyLibClass.Input("Количество строк в матрице: ");
            int cols = MyLibClass.Input("Количество столбцоы в матрице: ");
            double sum = 0;

            int[,] matrix = new int[rows, cols];
            MyLibClass.FillArray(matrix);
            MyLibClass.PrintArray(matrix);

            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    sum = sum + matrix[i, j];
                }
                sum = Math.Round(sum / rows, 2);
                Console.WriteLine($"Среднее арифметическое в {j} столбце равно {sum}");
                sum = 0;
            }

        }

        int zadacha = MyLibClass.Input("Введите номер задачи (47,50,52) или любое другое число для выхода: ");
        switch (zadacha)
        {
            case 47:
                Console.WriteLine("Задача 47. двумерный массив размером, заполненный случайными вещественными числами");
                Task47();
                break;
            case 50:
                Console.WriteLine("Задача 50. ");
                Task50();
                break;
            case 52:
                Console.WriteLine("Задача 52. среднее арифметическое элементов в каждом столбце");
                Task52();
                break;
            default:
                Console.WriteLine("выход");
                break;
        }
    }
}
