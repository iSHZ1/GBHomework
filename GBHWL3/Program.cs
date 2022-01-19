//Написать программу, выводящую элементы двухмерного массива по диагонали.
// Task 1
Console.WriteLine("Task 1");

int[,] array = { { 1, 2, 3 }, { 4, 5, 6 }, { 6, 7, 8 } };

for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        if (i == j)
        {
            Console.Write( array[i,j] + " ");
        }
    }
}

//Написать программу — телефонный справочник — создать двумерный массив 5*2, хранящий список телефонных контактов: первый элемент хранит имя контакта, второй — номер телефона/e-mail.
// Task 2
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("Task 2");

string[,] phoneBook = { { "Alex", "Xardas111@gmail.com" },
                       { "Vova", "+79991111111" },
                       { "Vlad", "Grayman19@mail.ru" },
                       { "Ira", "+79655698367" },
                       { "Evgeniy", "ProdamGarage@mail.ru" }};
for (int i = 0; i < 5; i++)
{
    Console.WriteLine(phoneBook[i, 0] + " " + phoneBook[i, 1]);
}

//Написать программу, выводящую введенную пользователем строку в обратном порядке (olleH вместо Hello).
// Task 3
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("Task 3");
string uWord = Console.ReadLine();

for (int i = uWord.Length - 1;  i >= 0 ; i--)
{
    Console.Write(Convert.ToChar(uWord[i]));
}

//* «Морской бой» — вывести на экран массив 10х10, состоящий из символов X и O, где Х — элементы кораблей, а О — свободные клетки.
// Task 4
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("Task 4");
Console.WriteLine();

char[,] seaBattle = { { 'X', 'O', 'X', 'O', 'O', 'O', 'O', 'O', 'O', 'X'},
                   { 'O', 'O', 'X', 'O', 'O', 'O', 'O', 'O', 'O', 'O'},
                   { 'O', 'O', 'X', 'O', 'O', 'O', 'X', 'O', 'O', 'O'},
                   { 'X', 'O', 'X', 'O', 'O', 'O', 'X', 'O', 'O', 'O'},
                   { 'X', 'O', 'O', 'O', 'X', 'O', 'X', 'O', 'O', 'O'},
                   { 'O', 'O', 'O', 'O', 'X', 'O', 'O', 'O', 'X', 'O'},
                   { 'O', 'X', 'O', 'O', 'X', 'O', 'O', 'O', 'X', 'O'},
                   { 'O', 'X', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O'},
                   { 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O'},
                   { 'X', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'X'} } ;

for (int i = 0; i < 10; i++)
{
    for (int j = 0; j < 10; j++)
    {
            Console.Write(seaBattle[i, j] + " ");
    }
    Console.WriteLine();
}
