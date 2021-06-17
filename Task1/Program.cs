using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkLesson10
{
    /*Используя Visual Studio, создайте проект по шаблону Console Application.Создайте программу, в которой создайте статический класс
    Calculator (калькулятор).  В классе создайте методы для выполнения основных арифметических операций.Реализуйте возможность работы 
    пользователя, через ввод данных с помощью клавиатуры и отображение результат на экран.*/
    class Program
    {
        static void Main(string[] args)
        {
            string exitContinue = "";
            while (!exitContinue.Equals("no"))
                {
                   double first = double.Parse(Console.ReadLine());
                   string sign = Console.ReadLine();
                   double second = double.Parse(Console.ReadLine());

                  switch (sign)
                  {
                     case "+":
                        first.Addition(second);
                        break;
                     case "-":
                        first.Subtraction(second);
                        break;
                     case "*":
                        Calculator.Multiplication(first, second);
                        break;
                     case "/":
                        Calculator.Division(first, second);
                        break;
                  }

                  Console.WriteLine("Continue? (enter yes or no)");
                  exitContinue = Console.ReadLine();
                  Console.WriteLine();
                }
        }
    }
    public static class Calculator
    {
        public static void Addition(this double firstNumber, double secondNumber) { Console.WriteLine(" = {0}",Math.Round((firstNumber + secondNumber),2)); }
        public static void Subtraction(this double firstNumber, double secondNumber) { Console.WriteLine(" = {0}",Math.Round((firstNumber - secondNumber),2)); }
        public static void Multiplication(double firstNumber, double secondNumber) { Console.WriteLine(" = {0}",Math.Round((firstNumber * secondNumber),2)); }
        public static void Division(double firstNumber,double secondNumber)
        {
            while (secondNumber == 0)
            {
                Console.WriteLine("Cannot divide by zero, enter different value");
                secondNumber = double.Parse(Console.ReadLine());
            }
            Console.WriteLine(" = {0}",Math.Round((firstNumber / secondNumber),2));
        }
    }
}
