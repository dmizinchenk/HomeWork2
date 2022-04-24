using System;

namespace HomeWork2
{
    /*
    //Задание 3
    public struct Coords
    {
        public int x;
        public int y;
    }
    public class Rectangle
    {
        Coords leftBottom;
        Coords rightTop;
        public Coords LeftBottom { get { return leftBottom; } }
        public Coords RightTop { get { return rightTop; } }
        public Rectangle()
        {
            leftBottom = new Coords();
            rightTop = new Coords();
            Console.Write("Введите координату \"x\" левой нижней точки: ");
            leftBottom.x = Int32.Parse(Console.ReadLine());
            Console.Write("Введите координату \"y\" левой нижней точки: ");
            leftBottom.y = Int32.Parse(Console.ReadLine());
            do
            {
                Console.Write("Введите координату \"x\" правой верхней точки: ");
                rightTop.x = Int32.Parse(Console.ReadLine());
                if (rightTop.x <= leftBottom.x)
                {
                    Console.WriteLine("Точка не может располагаться левее левого нижнего угла. Повторите попытку.");
                    continue;
                }
                break;
            } while (true);
            do
            {
                Console.Write("Введите координату \"y\" правой верхней точки: ");
                rightTop.y = Int32.Parse(Console.ReadLine());
                if (rightTop.y <= leftBottom.y)
                {
                    Console.WriteLine("Точка не может располагаться ниже левого нижнего угла. Повторите попытку.");
                    continue;
                }
                break;
            } while (true);
        }
        public Rectangle(Coords lb, Coords rt)
        {
            leftBottom.x = lb.x;
            leftBottom.y = lb.y;
            rightTop.x = rt.x;
            rightTop.y = rt.y;
        }

        public void ShowCoords()
        {
            Console.WriteLine($"Координаты левого нижнего угла: {{{leftBottom.x},{leftBottom.y}}}");
            Console.WriteLine($"Координаты правого верхнего угла: {{{rightTop.x},{rightTop.y}}}");
        }
    }
    internal class Program
    {
        //Задание 1
        static void Swap2<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }

        //Задание 2
        static void Swap3a<T> (ref T a, ref T b, ref T c)
        {
            T temp = b;
            b = c;
            c = a;
            a = temp;
        }
        static void Swap3b<T>(ref T a, ref T b, ref T c)
        {
            T temp = b;
            b = a;
            a = c;
            c = temp;
        }

        //Задание 3
        static Rectangle MinRect(in Rectangle r1, in Rectangle r2)
        {
            Coords lb = new Coords();
            Coords rt = new Coords();
            lb.x = Math.Min(r1.LeftBottom.x, r2.LeftBottom.x);
            lb.y = Math.Min(r1.LeftBottom.y, r2.LeftBottom.y);
            rt.x = Math.Max(r1.RightTop.x, r2.RightTop.x);
            rt.y = Math.Max(r1.RightTop.y, r2.RightTop.y);

            return new Rectangle(lb, rt);
        }
        static void Main(string[] args)
        {
            Rectangle rect1 = new Rectangle();
            Rectangle rect2 = new Rectangle();
            Rectangle includer = MinRect(in rect1, in rect2);
            includer.ShowCoords();
        }
    }
    */


    public class Program
    {
        static void Main(string[] args)
        {
            //Задание 4
            /*
            bool a, b;
            for (byte i = 0; i < 2; i++)
            {
                if (i == 0)
                    a = false;
                else
                    a = true;
                for (byte j = 0; j < 2; j++)
                {
                    if(j == 0)
                        b = false;
                    else
                        b = true;

                    Console.WriteLine($"При a={a}, b={b} выражение \"не (А и В)\"={!(a & b)}");
                    Console.WriteLine($"При a={a}, b={b} выражение \"не А или В\"={!a | b}");
                    Console.WriteLine($"При a={a}, b={b} выражение \"А или не В\"={a | !b}");
                }
            }
            */

            //Задания 5, 6
            Console.Write("Введите первое число: ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите второе число: ");
            double y = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите номер операции:\n1-Сложение\n2-Вычитание\n3-Умножение\n4-Деление\n");
            byte op = byte.Parse(Console.ReadLine());
            Console.WriteLine("");
            switch (op)
            {
                case 1: Console.WriteLine($"Производиться операция сложения: {x}+{y}={x + y}"); break;
                case 2: Console.WriteLine($"Производиться операция вычитания: {x}-{y}={x - y}"); break;
                case 3: Console.WriteLine($"Производиться операция умножения: {x}\x00b7{y}={x * y}"); break;
                case 4: Console.WriteLine($"Производиться операция деления: {x}:{y}={x / y}"); break;
                default: Console.WriteLine("Неизвестная операция"); break;
            }
        }
    }
}
