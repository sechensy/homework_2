namespace zadachi3;

class Program
{
    static void Main(string[] args)
    {
        int Input(string text)
        {
            Console.Write(text);
            return Convert.ToInt32(Console.ReadLine());
        }

        //Задача 19 
        //Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
        void Task19(){
            int number = Input("Введите пятизначное число: ");
            int first_part = number/1000;
            int second_part = number%100;
            int invert = (second_part%10)*10 + second_part/10;
            if (first_part==invert) Console.WriteLine($"число {number} палиндром");
            else Console.WriteLine($"число {number} не палиндром");
            
        }
        

        //Задача 21
        //Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
        void Task21(){
            Console.WriteLine("Введите коррдинаты первой точки");
            int x1 = Input("x = ");
            int y1 = Input("y = ");
            int z1 = Input("z = ");
            Console.WriteLine("Введите коррдинаты второй точки");
            int x2 = Input("x = ");
            int y2 = Input("y = ");
            int z2 = Input("z = ");
            double way = Math.Sqrt(Math.Pow(x1-x2,2) + Math.Pow(y1-y2,2) + Math.Pow(z1-z2,2));
            way = Math.Round(way,2);
            Console.WriteLine($"Расстояние между точками равно {way}");

        }

        //Задача 23
        //Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
        
        void Task23(){
            int n = Input("Введите число: ");
            int i = 1;
            while(i <= n){
                Console.WriteLine(Math.Pow(i,3));
                i++;
            }

        }

        int zadacha = Input("Введите номер задачи (19,21,23) или любое другое число для выхода: ");
        switch (zadacha)
        {
            case 19:
                Console.WriteLine("Задача 19: палиндром.");
                Task19();
                break;
            case 21:
                Console.WriteLine("Задача 21: расстояние между точками.");
                Task21();
                break;
            case 23:
                Console.WriteLine("Задача 23: куб.");
                Task23();
                break;
            default: 
                Console.WriteLine("выход");
                break;
        }
    }
}
