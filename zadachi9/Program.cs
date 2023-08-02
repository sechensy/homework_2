namespace zadachi9;

class Program
{
    static void Main(string[] args)
    {
        int Input(string text)
        {
            Console.Write(text);
            return Convert.ToInt32(Console.ReadLine());
        }

        //Задача 64: Задайте значения M и N. Напишите рекурсивный метод, 
        //который выведет все натуральные числа кратные 3-ём в промежутке от M до N.
        void Task64()
        {
            void Recursion(int M, int N)
            {
                if (M > N) return;
                if (M % 3 == 0) Console.WriteLine($"{M} ");
                Recursion(M + 1, N);
            }
            int M = Input("Введите первое число: ");
            int N = Input("Введите второе число: ");
            Console.WriteLine($"натуральные числа кратные 3-ём в промежутке от {M} до {N}: ");
            Recursion(M, N);
        }


        //Задача 66: Задайте значения M и N. Напишите рекурсивный метод, 
        //который найдёт сумму натуральных элементов в промежутке от M до N.
        void Task66()
        {
            int Recursion(int M, int N, int sum = 0)
            {
                if (M > N)
                {
                    return sum;
                }
                sum += M;
                return Recursion(M + 1, N, sum);
            }
            int M = Input("Введите первое число: ");
            int N = Input("Введите второе число: ");
            int sum = Recursion(M, N);
            Console.WriteLine($"Сумма натуральных элементов в промежутке от {M} до {N} равна {sum}");
        }


        //Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
        //Даны два неотрицательных числа m и n. 
        void Task68()
        {
            int Recursion(int m, int n)
            {
                if (m == 0) return n + 1;
                if (n == 0) return Recursion(m - 1, 1);
                else return Recursion(m - 1, Recursion(m, n - 1));
            }
            int m = Input("Введите первое число: ");
            int n = Input("Введите второе число: ");
            int result = Recursion(3, 2);
            Console.WriteLine($"Функции Аккермана от {m} и {n} равна {result}");
        }

        int zadacha = Input("Введите номер задачи (64,66,68): ");
        switch (zadacha)
        {
            case 64:
                Console.WriteLine("Задача 64");
                Task64();
                break;
            case 66:
                Console.WriteLine("Задача 66");
                Task66();
                break;
            case 68:
                Console.WriteLine("Задача 68");
                Task68();
                break;
        }

    }
}
