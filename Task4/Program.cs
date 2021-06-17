using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    /*Используя Visual Studio, создайте проект по шаблону Console Application.
   Создайте в программу, в которой создайте статический класс, в теле которого создайте расширяющий метод, который будет сортировать
    элементы целочисленного массива по возрастанию. Также в теле класса создайте метод, который будет создавать массив целочисленных 
    элементов, и заполнять его случайными значениями элементов, длина массива – параметр метода. В методе Main() с помощью метода 
    описанного выше создайте массив целочисленных элементов размерностью 10 элементов, выведите значение всех элементов массива на 
    консоль, далее с помощью расширяющего метода отсортируйте массив, и отсортированный массив снова выведите на консоль.*/

    class Program
    {
        static void Main(string[] args)
        {
            SortArray.CreateRandomArray randomArray = new SortArray.CreateRandomArray();
            int[] randArray = randomArray.createArray(10);
            Console.WriteLine();
            randArray.sortArray();
            
            Console.ReadLine();
        }
    }
    public static class SortArray
    {
        public class CreateRandomArray
        {
            Random random = new Random();
            public int[] createArray(int size)
            {
                int[] newArray = new int[size];
                for (int i = 0; i < newArray.Length; i++)
                {
                    newArray[i] = random.Next(1, 20);
                    Console.Write(newArray[i]+", ");
                }
                return newArray;
            }
        }
        public static void sortArray(this int[]intArray)
        {
            for (int i = 0; i < intArray.Length-1; i++)
            {
                for (int j = 0; j < intArray.Length-1; j++)
                {
                    if (intArray[j] > intArray[j + 1])
                    {
                        int temp = intArray[j];
                        intArray[j] = intArray[j + 1];
                        intArray[j + 1] = temp;
                    }
                }
            }

            foreach (var item in intArray)
            {
                Console.Write(item+", ");
            }
        }
    }
}
