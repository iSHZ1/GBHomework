// Decompiled with JetBrains decompiler
// Type: Alex.Program
// Assembly: GBHWL7, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 75326FDD-2AAD-4D0E-8C7F-C7E899A5A38C
// Assembly location: D:\GBrepo\GBHomework\GBHWL7\bin\Release\net6.0\GBHWL7.dll

using System;
using System.Diagnostics;


#nullable enable
namespace Alex
{
  internal class Program
  {
    private static void Main()
    {
      bool flag = true;
      Process[] processes = Process.GetProcesses();
      Console.WriteLine("Добро пожаловать в приложение TaskManager");
      while (flag)
      {
        Console.WriteLine("Выберите действие");
        Console.WriteLine("1. Вывести все процессы");
        Console.WriteLine("2. Удалить процесс по названию");
        Console.WriteLine("3. Удалить процесс по ID");
        Console.WriteLine("4. Завершить работу программы");
        switch (Convert.ToInt32(Console.ReadLine()))
        {
          case 1:
            Program.printProcess(processes);
            continue;
          case 2:
            Program.KillNameProcess(processes);
            continue;
          case 3:
            Program.KillIDProcess(processes);
            continue;
          case 4:
            flag = false;
            continue;
          default:
            Console.WriteLine("Введите число от 1 до 4");
            continue;
        }
      }
    }

    private static void KillNameProcess(Process[] process)
    {
      Console.Clear();
      Console.WriteLine("Введите айди процесса");
      string str = Console.ReadLine();
      for (int index = 0; index < process.Length; ++index)
      {
        if (process[index].ProcessName == str)
        {
          process[index].Kill();
          break;
        }
      }
    }

    private static void KillIDProcess(Process[] process)
    {
      Console.Clear();
      Console.WriteLine("Введите айди процесса");
      int int32 = Convert.ToInt32(Console.ReadLine());
      for (int index = 0; index < process.Length; ++index)
      {
        if (process[index].Id == int32)
        {
          process[index].Kill();
          break;
        }
      }
    }

    private static void printProcess(Process[] process)
    {
      Console.Clear();
      for (int index = 0; index < process.Length; ++index)
      {
        Process process1 = process[index];
        Console.WriteLine(process1.ProcessName + " " + process1.Id.ToString());
      }
      Console.WriteLine();
    }
  }
}
