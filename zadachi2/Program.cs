namespace zadachi2;

class Program
{
    static void Main(string[] args)
    {
        int Input(string text)
        {
            Console.Write(text);
            return Convert.ToInt32(Console.ReadLine());
        }

        void Task10()
        {
            int number = Input("Введите трехзначное число:");
            int second = (number / 10) % 10;
            Console.WriteLine($"Вторая цифра числа: {second}");
        }

        void Task13()
        {
            int number = Input("Введите число:");
            if (number > 99) 
            {
                while (number > 999) number = number / 10;
                number = number % 10;
                Console.WriteLine($"Третья цифра: {number}");
            }
            else Console.WriteLine("Третьей цифры нет");
        }

        void Task15()
        {
            int day_of_week = Input("Введите цифру, обозначающую день недели: ");
            if (day_of_week == 6 || day_of_week == 7) Console.WriteLine("Выходной");
            else if (day_of_week > 0 && day_of_week < 6) Console.WriteLine("Не выходной");
            else Console.WriteLine("Нет такого дня недели");
        }
        
        int zadacha = Input("Введите номер задачи (10,13,15) или любое другое число для выхода: ");
        switch (zadacha)
        {
            case 10:
                Console.WriteLine("Задача 10: вывод второй цифры трехзначного числа.");
                Task10();
                break;
            case 13:
                Console.WriteLine("Задача 13: вывод третьей цифры любого числа.");
                Task13();
                break;
            case 15:
                Console.WriteLine("Задача 15: проверка на выходной.");
                Task15();
                break;
            default: 
                Console.WriteLine("выход");
                break;
        }

    }
}
