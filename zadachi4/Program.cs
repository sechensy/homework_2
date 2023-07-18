namespace zadachi4;

class Program
{
    static void Main(string[] args)
    {
        int Input(string text)
        {
            Console.Write(text);
            return Convert.ToInt32(Console.ReadLine());
        }
        //Задача 25: Используя определение степени числа, напишите цикл, 
        //который принимает на вход два натуральных числа (A и B) и возводит число A в степень B.
        void Task25()
        {
            int a = Input("Введите число: ");
            int b = Input("Введите второе число:");
            int stepen = a;
            for (int i = 2; i <= b; i++)
            {
                a = a * stepen;
            }
            Console.WriteLine(a);

        }
        //Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
        void Task27()
        {
            int number = Input("Введите число: ");
            int sum = 0;
            while (number > 0)
            {
                sum = sum + number % 10;
                number = number / 10;
            }
            Console.WriteLine($"сумма цифр равна {sum}");
        }
        // Задача 29: Напишите программу, которая задаёт массив из 8 случайных целых чисел и выводит отсортированный по модулю массив.
        void Task29()
        {
            Random rnd = new Random();
            int size = 8;
            int[] numbers = new int[size];
            // заполнение массива
            for (int i = 0; i < size; i++)
            {
                numbers[i] = rnd.Next(-10, 11);
            }
            // вывод массива
            // for (int i = 0; i < size; i++)
            // {
            //     Console.Write($"{numbers[i]} ");
            // }
            // Console.WriteLine();
            void PrintArray(int[] array)
            {
                int count = array.Length;
                for (int i = 0; i < count; i++)
                {
                    Console.Write($"{array[i]} ");
                }
                Console.WriteLine();
            }

            void selectionSort(int[] array)
            {
                for (int i = 0; i < array.Length - 1; i++)
                {
                    int minPosition = i;
                    for (int j = i + 1; j < array.Length; j++)
                    {
                        if (Math.Abs(array[j]) < Math.Abs(array[minPosition])) 
                        {
                            minPosition = j;
                        }
                    }
                    int temporary = array[i];
                    array[i] = array[minPosition]; 
                    array[minPosition] = temporary;
                }
            
            }
            PrintArray(numbers);
            selectionSort(numbers); 
            PrintArray(numbers);
        }
        int zadacha = Input("Введите номер задачи (25,27,29) или любое другое число для выхода: ");
        switch (zadacha)
        {
            case 25:
                Console.WriteLine("Задача 25. степень");
                Task25();
                break;
            case 27:
                Console.WriteLine("Задача 27. сумма цифр в числе");
                Task27();
                break;
            case 29:
                Console.WriteLine("Задача 29. сортировка");
                Task29();
                break;
            default:
                Console.WriteLine("выход");
                break;
        }
    }
}
