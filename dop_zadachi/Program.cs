int Input(string text)
        {
            Console.Write(text);
            return Convert.ToInt32(Console.ReadLine());
        }

// 1. написать программу, которая определяет, является ли треугольник со сторонами a,b,c равнобедренным
void Task1()
{
    int a = Input("введите значение стороны a: ");
    int b = Input("введите значение стороны b: ");
    int c = Input("введите значение стороны c: ");

    if (a + b <= c || b + c <= a || a + c <= b) Console.WriteLine("такого треугольника не существует");
    else if (a == b || b == c || c == a) Console.WriteLine("Треугольник равнобедренный");
    else Console.WriteLine("Треугольник не равнобедренный");

}

// 2. На вход подаются год, номер месяца и день рождения человека, Определить возраст человека на момент 1 июля 2022 года.

void Task2()
{
    int day = Input("Введите день рождения ");
    int month = Input("Введите номер месяца рождения ");
    int year = Input("Введите год рождения ");
    int years_old;

    if (month < 6 || (month == 6 && day == 1)) years_old = 2022 - year;
    else years_old = 2022 - year - 1;
    Console.WriteLine($"Возраст человека равен {years_old}");
}


// 3.Иван в начале года открыл счет в банке, вложив 1000 руб. Через каждый месяц размер вклада увеличивается на 1.5% от имеющейся суммы.
// Определить размер депозита через n месяцев.

void Task3()
{
    int n = Input("Введите количество месяцев ");
    double depozit = 1000;
    int i = 1;
    while (i <= n){
        depozit = depozit + 0.015 * depozit;
        i = i + 1;
    }
    Console.WriteLine($"Размер депозита через {n} месяцев равен {depozit}");
    
}

// 4. Дано натуральное число, в котором все цифры различны. Определить, какая цифра расположена в нем левее: максимальная или минимальная.
// 3247953, минимаьная цифра левее
// 567231, максимальная цифра левее
void Task4()
{
    int number = Input("введите число: ");
    int last_element;
    int i = 1; // общий счетчик
    int max = number % 10;
    int k = 1; // счетчик для максимума
    int min = number % 10;
    int h = 1; // счетчик для минимума
    while (number > 0)
    {
        last_element = number % 10;
        if (last_element >= max) {
            max = last_element;
            k = i;
        }
        if (last_element <= min) {
            min = last_element;
            h = i;
        }
        i = i+1;
        number = number / 10;
    }
    if (k > h) Console.Write("Левее расположена максимальная цифра");
    else Console.Write("Левее расположена минимальная цифра");
}

int zadacha = Input("Введите номер задачи (1,2,3,4) или любое другое число для выхода: ");
        switch (zadacha)
        {
            case 1:
                Console.WriteLine("Задача 1: равнобедренный треугольник.");
                Task1();
                break;
            case 2:
                Console.WriteLine("Задача 2: возраст.");
                Task2();
                break;
            case 3:
                Console.WriteLine("Задача 3: депозит.");
                Task3();
                break;
            case 4:
                Console.WriteLine("Задача 4: какая цифра левее.");
                Task4();
                break;
            default: 
                Console.WriteLine("выход");
                break;
        }