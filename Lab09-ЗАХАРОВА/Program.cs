int totalExercises = 8;

for (int number = totalExercises; number >= 1; number--)
{
    Console.WriteLine($"Упражнение {number}");
}

Console.WriteLine("Домашнее задание готово");

//-----

for (int room = 5; room <= 50; room += 5)
{
    Console.WriteLine($"Кабинет {room}");
}

//-----

int totalWeeks = 3;

for (int week = 1; week <= totalWeeks; week++)
{
    for (int day = 1; day <= 5; day++)
    {
        Console.WriteLine($"Неделя {week}, день {day}");
    }

    Console.WriteLine("^_^");
}

//-----

int skippedTickets = 0;

for (int ticket = 1; ticket <= 30; ticket++)
{
    if (ticket == 4 || ticket == 12 || ticket == 19)
    {
        skippedTickets++;
        continue;
    }

    Console.WriteLine($"Первый доступный билет: {ticket}");
    Console.WriteLine($"Пропущено билетов: {skippedTickets}");
    break;
}

//-----

for (;;)
{
    Console.Write("Введите код группы (для выхода — «выход»): ");
    string groupCode = Console.ReadLine();

    if (groupCode == "выход")
    {
        break;
    }

    Console.WriteLine($"Записан код группы: {groupCode}");
}

Console.WriteLine("Работа с журналом завершена");

// TASK A

int oddLimit = 25;

for (int oddNumber = 1; oddNumber <= oddLimit; oddNumber += 2)
{
    Console.WriteLine(oddNumber);
}

// TASK B

for (int countdown = 100; countdown >= 0; countdown -= 10)
{
    Console.WriteLine(countdown);
}

//-----

int countdownStart = 50;
int step = 7;

for (int number = countdownStart; number >= 0; number -= step)
{
    Console.WriteLine(number);
}

//-----

for (int a = 1; a <= 5; a++)
{
    for (int b = 1; b <= 5; b++)
    {
        Console.WriteLine($"{a} + {b} = {a + b}");
    }

    Console.WriteLine();
}