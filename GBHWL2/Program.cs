// Task 1
Console.WriteLine("Task 1");
Console.Write("Введите минимальную температуру за месяц: ");
string temp1 = Console.ReadLine();

Console.Write("Введите максимальную температуру за месяц: ");
string temp2 = Console.ReadLine();

Console.WriteLine("Средняя температура за месяц = " + ((Convert.ToDouble(temp2) + Convert.ToDouble(temp1)) / 2));  // Не нашел Convert.ToFloat или что-то того

// Task 2
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("Task 2");
Console.WriteLine("Введите порядковый номер месяца: ");
string Mnumber = Console.ReadLine();

switch (Convert.ToInt32(Mnumber))
{
    case 1:
        Console.WriteLine("Январь");
        break;
    case 2:
        Console.WriteLine("Февраль");
        break;
    case 3:
        Console.WriteLine("Март");
        break;
    case 4:
        Console.WriteLine("Апрель");
        break;
    case 5:
        Console.WriteLine("Май");
        break;
    case 6:
        Console.WriteLine("Июнь");
        break;
    case 7:
        Console.WriteLine("Июль");
        break;
    case 8:
        Console.WriteLine("Август");
        break;
    case 9:
        Console.WriteLine("Сентябрь");
        break;
    case 10:
        Console.WriteLine("Октябрь");
        break;
    case 11:
        Console.WriteLine("Ноябрь");
        break;
    case 12:
        Console.WriteLine("Декабрь");
        break;
}

if ((Convert.ToInt32(Mnumber) == 1 || Convert.ToInt32(Mnumber) == 2 || Convert.ToInt32(Mnumber) == 12) && ((Convert.ToDouble(temp2) + Convert.ToDouble(temp1)) / 2) > 0)  
{
    Console.WriteLine("Дождливая зима");
}
// Task 3
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("Task 3");
Console.WriteLine("Введите число: ");
string Pnumber = Console.ReadLine();

if (Convert.ToInt32(Pnumber) % 2 == 0)
{
    Console.WriteLine("Четное");
}
else
{
    Console.WriteLine("Нечетное");
}

// Task 4
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("Task 4");

int numberorder = 548;
string date = "19.01.2022";
string webpage = "http://www.ozon.ru/";
string company = "Интернет Решения, ООО";
double iNNNumber = 7704217370;
string sNO = "ОСН";
int sumPosition = 1;
int summa = 1060;
int total = sumPosition * summa;


Console.WriteLine($"           Кассовый чек №{numberorder}        ");
Console.WriteLine($"                      {date}        ");
Console.WriteLine($"                      {webpage}        ");
Console.WriteLine($"                      {company}        ");
Console.WriteLine($"                 ИНН{iNNNumber}        ");
Console.WriteLine($"                      {date}        ");
Console.WriteLine($"            Вид налогообложения:{sNO}        ");
Console.WriteLine($"                      Приход        ");
Console.WriteLine($"---------------------------------------------");
Console.WriteLine($"1. Получение аванса");
Console.WriteLine($"   {sumPosition} х {summa}                          ={total}");
Console.WriteLine();
Console.WriteLine();