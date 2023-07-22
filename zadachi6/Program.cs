using MyLib;

namespace zadachi6;

class Program
{
    static void Main(string[] args)
    {
        // Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
        void Task41()
        {
            int size = MyLibClass.Input("Сколько чисел будет введено: ");
            int[] array = new int[size];
            Console.WriteLine("Ввкдите числа через enter: ");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0) count++;
            }
            Console.WriteLine("Количество чисел больше нуля равно " + count);
        }


        //Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
        //заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
        void Task43()
        {
            double k1 = MyLibClass.Input("Введите k1: ");
            double b1 = MyLibClass.Input("Введите b1: ");
            double k2 = MyLibClass.Input("Введите k2: ");
            double b2 = MyLibClass.Input("Введите b2: ");

            double x = (b2 - b1) / (k1 - k2);
            double y1 = k1 * x + b1;
            double y2 = k2 * x + b2;
            // Console.WriteLine(y1);
            // Console.WriteLine(y2);

            if (Math.Round(y1,2) == Math.Round(y2,2)) 
            {
                Console.WriteLine($"Точка пересечения прямой y={k1}x+{b1} и y={k2}x+{b2} равна {(Math.Round(y1,2),Math.Round(x,2))}");
            }

            else Console.WriteLine($"Прямые y={k1}x+{b1} и y={k2}x+{b2} не пересекаются");
        }
        

        int zadacha = MyLibClass.Input("Введите номер задачи (41,43) или любое другое число для выхода: ");
        switch (zadacha)
        {
            case 41:
                Console.WriteLine("Задача 41. Положительные числа");
                Task41();
                break;
            case 43:
                Console.WriteLine("Задача 43. Точка переечения");
                Task43();
                break;
            default:
                Console.WriteLine("выход");
                break;
        }
    }
}
