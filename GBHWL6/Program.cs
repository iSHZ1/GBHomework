using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Alex
{
    class Program
    {
        static void Main()
        {
            bool workProgram = true;
            Process[] process = Process.GetProcesses();
            int userInput;

            Console.WriteLine("Добро пожаловать в приложение TaskManager");
            while (workProgram)
            {
                Console.WriteLine("Выберите действие");
                Console.WriteLine("1. Вывести все процессы");
                Console.WriteLine("2. Удалить процесс по названию");
                Console.WriteLine("3. Удалить процесс по ID");
                Console.WriteLine("4. Завершить работу программы");

                userInput = Convert.ToInt32(Console.ReadLine());

                switch (userInput)
                {
                    case 1:
                        printProcess(process);
                        break;
                    case 2:
                        KillNameProcess(process);
                        break;
                    case 3:
                        KillIDProcess(process);
                        break;
                    case 4:
                        workProgram = false;
                        break;
                    default:
                        Console.WriteLine("Введите число от 1 до 4");
                        break;
                }
            } 
        }

        static void KillNameProcess(Process[] process)
        {
            Console.Clear();
            Console.WriteLine("Введите айди процесса");
            string killName = Console.ReadLine();

            for (int i = 0; i < process.Length; i++)
            {

                if (process[i].ProcessName == killName)
                {
                    Process a = process[i];
                    a.Kill();
                    return;
                }
            }
        }

        static void KillIDProcess(Process[] process)
        {
            Console.Clear();
            Console.WriteLine("Введите айди процесса");
            int killID = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < process.Length; i++)
            {

                if (process[i].Id == killID)
                {
                    Process a = process[i];
                    a.Kill();
                    return;
                }
            }
        }

        static void printProcess(Process[] process)
        {
            Console.Clear();
            for (int i = 0; i < process.Length; i++)
            {
                Process a = process[i];
                Console.WriteLine(a.ProcessName + " " + a.Id);
            }
            Console.WriteLine();
        }


}
}