using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBHW8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Properties.Settings.Default.Hello);
            Console.WriteLine("Версия приложения: " + Properties.Settings.Default.Version + ".0");

            if (string.IsNullOrEmpty(Properties.Settings.Default.UserName))
            {
                Console.WriteLine("Введите ваши первые данные данные:");
                GetData();

            }
            else
            {
                Console.WriteLine("Ваши старые данные:");
                ShowData();

                Console.WriteLine("Хотите изменить данные? y/n");
                string UserInput = Console.ReadLine();

                if (UserInput == "y")
                {
                    Console.WriteLine("Введите новые данные старые данные:");
                    GetData();
                    Properties.Settings.Default.Version++;

                }
                else
                {
                    Console.WriteLine("Всего доброго!");

                }
            }

            Properties.Settings.Default.Save();

            Console.WriteLine("Нажмите любую клавишу, чтобы завершить");
            Console.ReadKey();
        }

        static void ShowData()
        {
            Console.WriteLine(Properties.Settings.Default.UserName);

            Console.WriteLine(Properties.Settings.Default.Age);

            Console.WriteLine(Properties.Settings.Default.Work);
        }
        
        static void GetData()
        {
            Console.WriteLine("Введите Ваше имя");
            Properties.Settings.Default.UserName = Console.ReadLine();
            Console.WriteLine("Введите Ваш возраст");
            Properties.Settings.Default.Age = Console.ReadLine();
            Console.WriteLine("Введите Ваш род деятельности");
            Properties.Settings.Default.Work = Console.ReadLine();
        }
    }
}
