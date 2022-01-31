using System;
using System.Text;
using System.IO;
using Newtonsoft;
using System.Runtime.Serialization.Formatters.Binary;

namespace Alex
{

    class Program
    {
        static void Main()
        {
            //Ввести с клавиатуры произвольный набор данных и сохранить его в текстовый файл.
            //Task1
            Console.WriteLine("Task 1");
            string userText = Console.ReadLine();
            File.WriteAllText("task1.txt", userText);

            //Написать программу, которая при старте дописывает текущее время в файл «startup.txt».
            //Task2
            Console.WriteLine(); Console.WriteLine();
            Console.WriteLine("Task 2");
             File.AppendAllText("startup.txt", Convert.ToString(DateTime.Now));

            //Ввести с клавиатуры произвольный набор чисел(0...255) и записать их в бинарный файл.
            //Task3
            Console.WriteLine(); Console.WriteLine();
            Console.WriteLine("Task 3");
            Console.WriteLine("Введите размер набора чисел");

            int n = Convert.ToInt32(Console.ReadLine());
            byte[] array = new byte[n];
            for (int i = 0; i < n; i++)
                array[i] = Convert.ToByte(Console.ReadLine());
            File.WriteAllBytes("Task3.bin", array);
        }

    }


}