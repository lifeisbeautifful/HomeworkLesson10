using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
   /* Используя Visual Studio, создайте проект по шаблону Console Application.
   Создайте класс, который будет описывать точку в трехмерной системе координат (X, Y, Z).  В теле класса переопределите операторы 
   сложения (+), вычитания(-), умножения(*), деления(/), декремента(++), инкремента(--), также переопределите метод ToString(), таким 
   образом, чтоб он отображал полную информацию о точке(ее координаты), метод Equals  для сравнения 2-х точек, а также метод  GetHashCode.
   В методе Main() создайте 2 экземпляря класса точка, выполните для 2-х точек все переопределенные методы, результат выполнения операция 
   вывидите на консоль.*/

    class Program
    {
        static void Main(string[] args)
        {
            Point point1 = new Point(1, 2, 1);
            Point point2 = new Point(2, 1, 1);

            Point addedPoints = point1 + point2;
            Point substarction = point1 - point2;
            Point multiplication = point1 * point2;
            Point division = point1 / point2;
            
            Console.WriteLine("Addition result: {0}",addedPoints);
            Console.WriteLine("Substraction result: {0}",substarction);
            Console.WriteLine("Multiplication result: {0}",multiplication);
            Console.WriteLine("Division result: {0}",division);

            Console.WriteLine("Incremented: {0}",++point1);
            Console.WriteLine("Decremented: {0}",--point1);

            Console.WriteLine(point1.Equals(point2));
            Console.WriteLine(point1.GetHashCode());
            Console.ReadLine();
        }
    }
    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }
        public Point(int first, int second, int third)
        {
            X = first;
            Y = second;
            Z = third;
        }
        public static Point operator +(Point p1, Point p2)
        {
            return new Point(p1.X + p2.X, p1.Y + p2.Y, p1.Z + p2.Z);
        }
        public static Point operator -(Point p1, Point p2)
        {
            return new Point(p1.X - p2.X, p1.Y - p2.Y, p1.Z - p2.Z);
        }
        public static Point operator * (Point p1,Point p2)
        {
            return new Point(p1.X*p2.X,p1.Y*p2.Y,p1.Z*p2.Z);
        }
        public static Point operator / (Point p1,Point p2)
        {
            if (p2.X != 0 && p2.Y != 0 && p2.Z != 0)
            {
                return new Point(p1.X / p2.X, p1.Y / p2.Y, p1.Z / p2.Z);
            }
            return p1;
        }
        public static Point operator ++(Point p1)
        {
            return new Point(p1.X + 1, p1.Y + 1, p1.Z + 1);
        }
        public static Point operator --(Point p1)
        {
            return new Point(p1.X - 1, p1.Y - 1, p1.Z - 1);
        }
        public override string ToString()
        {
            return string.Format("X = {0}, Y = {1}, Z = {2}", this.X, this.Y, this.Z);
        }
        public override bool Equals(Object p1)
        {
            if(p1 is Point)
            {
                if(((Point)p1).X == this.X && ((Point)p1).Y == this.Y && ((Point)p1).Z == this.Z)
                {
                    return true;
                }
            }
            return false;
        }
        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }
    }
}
