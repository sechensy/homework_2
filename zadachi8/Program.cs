using MyLib;
namespace zadachi8;

class Program
{
    static void Main(string[] args)
    {
        //Задача 54: Задайте двумерный массив. 
        //Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
        void Task54()
        {
            int rows = 4;
            int cols = 5;
            int[,] matrix = new int[rows, cols];

            MyLibClass.FillArray(matrix);
            MyLibClass.PrintArray(matrix);
            Console.WriteLine();


            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1) - 1; j++)
                {
                    int maxPosition = j;

                    for (int k = j + 1; k < cols; k++)
                    {
                        if (matrix[i, k] > matrix[i, maxPosition]) maxPosition = k;
                    }

                    int temporary = matrix[i, j];
                    matrix[i, j] = matrix[i, maxPosition];
                    matrix[i, maxPosition] = temporary;
                }
            }
            MyLibClass.PrintArray(matrix);

        }
        //Задача 56: Задайте прямоугольный двумерный массив. 
        //Напишите программу, которая будет находить строку с наименьшей суммой элементов.
        void Task56()
        {
            int rows = 4;
            int cols = 5;
            int[,] matrix = new int[rows, cols];
            MyLibClass.FillArray(matrix);
            MyLibClass.PrintArray(matrix);
            Console.WriteLine();

            int min = 0;
            int sum = 0;
            int index = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    sum += matrix[i, j];
                }
                if (sum < min)
                {
                    min = sum;
                    index = i;
                }
                sum = 0;
            }
            Console.WriteLine($"строка {index} имеет наименьшую сумму эдементов равную {min}");
        }

        //Задача 58: Задайте две матрицы. 
        //Напишите программу, которая будет находить произведение двух матриц.
        void Task58()
        {
            int first_rows = 2;
            int first_cols = 3;
            int second_rows = 3;
            int second_cols = 3;

            int result_rows = first_rows;
            int result_cols = second_cols;
            int sum = 0;
            int index = 0;

            if (first_cols != second_rows)
                Console.WriteLine("количество столбцов первой матрицы должно быть равно равно количеству строк второй матрицы");

            int[,] first_matrix = new int[first_rows, first_cols];
            int[,] second_matrix = new int[second_rows, second_cols];
            int[,] result_matrix = new int[result_rows, result_cols];

            MyLibClass.FillArray(first_matrix);
            MyLibClass.FillArray(second_matrix);
            Console.WriteLine("Первая матрица: ");
            MyLibClass.PrintArray(first_matrix);
            Console.WriteLine("Вторая матрица: ");
            MyLibClass.PrintArray(second_matrix);
            
            for (int i = 0; i < result_rows; i++)
            {
                while(index < result_cols)
                {
                  for (int j = 0; j < result_cols; j++)
                {
                    sum += first_matrix[i, j] * second_matrix[j, index];
                }
                result_matrix[i, index] = sum;
                sum = 0;  
                index++;
                }
                index = 0;
            }
            Console.WriteLine("Результат умножения первой матрицы на вторую: ");
            MyLibClass.PrintArray(result_matrix);
        }

        //Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
        //Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
        void Task60()
        {
            int rows = 2;
            int cols = 2;
            int width = 2;

            int[,,] array = new int[rows, cols, width];

            MyLibClass.FillArray(array, 10, 99);
            MyLibClass.PrintArray(array);

        }

        //Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4. 
        void Task62()
        {
            int rows = 4;
            int cols = 4;
            int number = 1;
            int[,] array = new int[rows, cols];

            int StartIndex_rows = 0;
            int FinishIndex_rows = rows-1;
            int StartIndex_cols = 0;
            int FinishIndex_cols = cols-1;

            while(StartIndex_rows <= FinishIndex_rows && StartIndex_cols <= FinishIndex_cols)
            {
                for (int j = StartIndex_cols; j <= FinishIndex_cols; j++)
                {
                    array[StartIndex_rows, j] = number;
                    number++;
                }
                StartIndex_rows++;
                for (int i = StartIndex_rows; i <= FinishIndex_rows; i++)
                {
                    array[i, FinishIndex_cols] = number;
                    number++;
                }
                FinishIndex_cols--;
                for (int j = FinishIndex_cols; j >= StartIndex_cols; j--)
                {
                    array[FinishIndex_rows, j] = number;
                    number++;
                }
                FinishIndex_rows--;
                for (int i = FinishIndex_rows; i >= StartIndex_rows; i--)
                {
                    array[i,StartIndex_cols] = number;
                    number++;
                }
                StartIndex_cols++;
            }
            MyLibClass.PrintArray(array);
        }

        int zadacha = MyLibClass.Input("Введите номер задачи (54,56,58,60,62): ");
        switch (zadacha)
        {
            case 54:
                Console.WriteLine("Задача 54");
                Task54();
                break;
            case 56:
                Console.WriteLine("Задача 56");
                Task56();
                break;
            case 58:
                Console.WriteLine("Задача 58");
                Task58();
                break;
            case 60:
                Console.WriteLine("Задача 60");
                Task60();
                break;
            case 62:
                Console.WriteLine("Задача 62");
                Task62();
                break;
            default:
                Console.WriteLine("выход");
                break;
        }

    }


}

