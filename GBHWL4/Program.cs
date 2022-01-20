using System;

namespace GBHWL4
{

    class Program
    {
        static void Main()
        {
            //Написать метод GetFullName(string firstName, string lastName, string patronymic), принимающий на вход ФИО в разных аргументах и возвращающий объединённую строку с ФИО.Используя метод, написать программу, выводящую в консоль 3–4 разных ФИО.
            //Task 1
            Console.WriteLine("Task 1");
            string Imya, Familiya, Otchestvo;

            Imya = SetSomeName();
            Familiya = SetSomeName();
            Otchestvo = SetSomeName();
            GetFullName(Imya, Familiya, Otchestvo);
            Console.WriteLine();

            Imya = "Ilya";
            Familiya = "Yashin";
            Otchestvo = "Robertovich";
            GetFullName(Imya, Familiya, Otchestvo);
            Console.WriteLine();

            Imya = "Alex";
            Familiya = "Shtefan";
            Otchestvo = "Sergeevich";
            GetFullName(Imya, Familiya, Otchestvo);
            Console.WriteLine();

            Imya = "Irina";
            Familiya = "Shtefan";
            Otchestvo = "Vladimirovna";
            GetFullName(Imya, Familiya, Otchestvo);
            Console.WriteLine();

            Imya = "Dmitriy";
            Familiya = "Bolshakov";
            Otchestvo = "Alexandrovich";
            GetFullName(Imya, Familiya, Otchestvo);
            Console.WriteLine();

            //Написать программу, принимающую на вход строку — набор чисел, разделенных пробелом, и возвращающую число — сумму всех чисел в строке.Ввести данные с клавиатуры и вывести результат на экран.
            //Task 2
            Console.WriteLine(); Console.WriteLine();
            Console.WriteLine("Task 2");
            string array = "1 2 3 4 5 6 10 100";
            int ansver = Sumel(array);
            Console.WriteLine(ansver);



            //Написать метод по определению времени года. На вход подаётся число – порядковый номер месяца.На выходе — значение из перечисления(enum) — Winter, Spring, Summer, Autumn.Написать метод, принимающий на вход значение из этого перечисления и возвращающий название времени года(зима, весна, лето, осень). Используя эти методы, ввести с клавиатуры номер месяца и вывести название времени года.Если введено некорректное число, вывести в консоль текст «Ошибка: введите число от 1 до 12».
            //Task 3
            Console.WriteLine(); Console.WriteLine();
            Console.WriteLine("Task 3");
            int numberMounth = Convert.ToInt32(Console.ReadLine());
            TimeYear(numberMounth);



            //(*) Написать программу, вычисляющую число Фибоначчи для заданного значения рекурсивным способом. 
            //Task 4
            Console.WriteLine(); Console.WriteLine();
            Console.WriteLine("Task 4");
            int numberFi = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Fib(numberFi));
        }

        static string SetSomeName()
        {
            string some = Console.ReadLine();
            return some;
        }

        static void GetFullName(string firstName, string lastName, string patronymic)
        {
            Console.WriteLine(firstName + " " + lastName + " " + patronymic);
        }

        static int Sumel(string naborChisl)
        {
            naborChisl += " ";
            int sum = 0;
            string a = "";
            for (int i = 0; i < naborChisl.Length; i++)
            {
                if (naborChisl[i] == ' ')
                {
                    sum += Convert.ToInt32(a);
                    a = "";
                }
                else
                {
                    a += naborChisl[i];
                }
            }

            return sum;
        }

        public enum TimeYears
        {
            Winter,
            Spring,
            Summer,
            Autumn
        }

        static int TimeYear(int a)
        {
            TimeYears winter = TimeYears.Winter;
            TimeYears spring = TimeYears.Spring;
            TimeYears summer = TimeYears.Summer;
            TimeYears autumn = TimeYears.Autumn;

            while (a < 0 || a > 12)
            {
                Console.WriteLine("Вы неправильно ввели месяц, введите заново");
                a = Convert.ToInt32(Console.ReadLine());
            }

            switch (a)
            {
                case 1:
                    Console.WriteLine("Зима");
                    break;
                case 2:
                    Console.WriteLine("Зима");
                    break;
                case 3:
                    Console.WriteLine("Весна");
                    break;
                case 4:
                    Console.WriteLine("Весна");
                    break;
                case 5:
                    Console.WriteLine("Весна");
                    break;
                case 6:
                    Console.WriteLine("Лето");
                    break;
                case 7:
                    Console.WriteLine("Лето");
                    break;
                case 8:
                    Console.WriteLine("Лето");
                    break;
                case 9:
                    Console.WriteLine("Осень");
                    break;
                case 10:
                    Console.WriteLine("Осень");
                    break;
                case 11:
                    Console.WriteLine("Осень");
                    break;
                case 12:
                    Console.WriteLine("Зима");
                    break;

            }
            return 0;
        }

        static int Fib(int a)
        {
            if (a == 0) { return 0; }
            if (a == 1) { return 1; }
            return Fib(a - 1) + Fib(a - 2);
        }
    }
}