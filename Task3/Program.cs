using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    /*Используя Visual Studio, создайте проект по шаблону Console Application.
   Создайте программу, в которой создайте статический класс StringExtension (длина строки), в теле класса создайте расширяющий метод 
    StrCount который будет осуществлять подсчёт количество элементов в строке.Возвращаемое значение метода должно быть типа int, 
    на вход необходимо принимать два аргумента, 1-й сама строка, 2-й символ начиная с которого будет производится расчет. */

    class Program
    {
        static void Main(string[] args)
        {
            string words = "Here can be your advertisement";
            Console.WriteLine(words.StrCount('c'));
           
            Console.ReadLine();
        }
    }
    public static class StringExtension
    {
        public static int StrCount(this string str,char startCount)
        {
            int counterStart = -1;
            int counter = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == startCount)
                {
                    counterStart = i;
                    break;
                }
            }
            if (counterStart >= 0)
            {
                for (int i = counterStart; i < str.Length; i++)
                {
                    counter++;
                }
                return counter;
            }
            else
            {
                return 0;
            }
        }
    }
}
