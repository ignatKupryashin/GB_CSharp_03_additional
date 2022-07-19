//Задача 1. Рассчитать значение y при заданном x по формуле

void Task1()
{
    Console.WriteLine(""); //пустая строка для красоты
    Console.WriteLine("Данная программа высчитывает y по условию");
    Console.Write("Введите x: ");
    int x = Convert.ToInt32(Console.ReadLine());
    double y;
    if (x > 0)
    {
        y = Math.Pow(Math.Sin(x), 2);

    }
    else
    {
        y = 1 - 2 * (Math.Sin(Math.Pow(x, 2)));
    }
    y = Math.Round(y, 5);
    Console.WriteLine($"Значение y = {y}");
    Console.WriteLine(""); //пустая строка для красоты
}

//Задача 2. Дано трёхзначное число N. Определить кратна ли трём сумма всех его цифр.
void Task2()
{
    Console.WriteLine(""); //пустая строка для красоты
    Console.WriteLine("Данная программа проверяет, кратна ли трём сумма цифр введённого числа.");
    Console.Write("Введите трёхзначное число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    if (number < 100 || number > 999)
    {
        Console.WriteLine("Вы ввели не трёхзначное число");
    }
    else
    {
        int answer = 0;
        while (number > 0)
        {
            answer += number % 10;
            number /= 10;
        }
        if (answer % 3 == 0)
        {
            Console.WriteLine("Сумма цифр введённого числа кратна трём");
        }
        else
        {
            Console.WriteLine("Сумма цифр введённого числа не кратна трём");
        }
    }
    Console.WriteLine(""); //пустая строка для красоты
}

//Задача 3. Дано трёхзначное число N. Определить, есть ли среди его цифр 4 или 7.
void Task3()
{
    Console.WriteLine(""); //пустая строка для красоты
    Console.WriteLine("Данная программа проверяет, есть ли среди введённого трёхзначного числа цифры 4 или 7.");
    Console.WriteLine(""); //пустая строка для красоты
    Console.Write("Введите трёхзначное число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    if (number < 100 || number > 999)
    {
        Console.WriteLine("Вы ввели не трёхзначное число");
    }
    else
    {
        while (number > 0)
        {
            if (number % 10 == 4 || number % 10 == 7)
            {
                Console.WriteLine("Введёное число содержит цифры 4 или 7");
                break;
            }
            number /= 10;
            if (number == 0)
            {
                Console.WriteLine("Введёное число не содержит цифры 4 или 7");
            }
        }

    }
    Console.WriteLine(""); //пустая строка для красоты
}

//Задача 4. Дан массив длиной 10 элементов. Заполнить его последовательно числами от 1 до 10.
void Task4()
{

    Console.WriteLine(""); //пустая строка для красоты
    Console.WriteLine("Данная программа проверяет заполняет массив последовательно числами от 1 до 10");
    Console.WriteLine(""); //пустая строка для красоты
    int[] array = new int[10];
    for (int i = 0; i < 10; i++)
    {
        array[i] = i + 1;
    }
    Console.WriteLine("Массив array содержит цифры: " + String.Join(" ", array));
    Console.WriteLine(""); //пустая строка для красоты
}


//Задачи повышенной сложности:
//Задача 1. На ввод подаётся номер четверти. Создаются 3 случайные точки в этой четверти. Определите самый оптимальный маршрут для торгового менеджера, который выезжает из центра координат.

void TaskHard1()
{

}

//Задача 2. Даны 4 точки a, b, c, d. Пересекаются ли вектора AB и CD?
void TaskHard2()
{

}
//Задача 3. Найти в какой четверти лежит точка пересечения из задачи 2 (если вектора пересекаются).
void TaskHard3()
{

}
//Задача 4. Дан массив средних температур (массив заполняется случайно) за последние 10 лет. На ввод подают номер месяца и год начала и конца.
//Определить самые высокие и низкие температуры для лета, осени, зимы и весны в заданном промежутке. Если таких температур нет, сообщить, что определить не удалось.
void TaskHard4()
{

}
//Задача 5. На вход подаётся число n > 4, указывающее длину пароля. Создайте метод, генерирующий пароль заданной длины. В пароле обязательно использовать цифру, букву и специальный знак.
void TaskHard5()
{

}
// Задача 6.Из центра координат к точке А(x, y) проведён отрезок АО. Напишите программу, определяющую наименьший угол наклона отрезка AO к оси X.
void TaskHard6()
{

}
// Задача 7. Массив из ста элементов заполняется случайными числами от 1 до 100. Удалить из массива все элементы, содержащие цифру 3. Вывести в консоль новый массив и количество удалённых элементов.
void TaskHard7()
{

}
// Задача 8. Напишите программу, который выводит на консоль таблицу умножения от 1 до n, где n задаётся случайно от 2 до 100.
void TaskHard8()
{
    Console.WriteLine("");
    Console.WriteLine("Данная программа выводит таблицу умножения от 1 до случайного числа");
    Console.WriteLine("");
    Random rand = new Random();
    int number = rand.Next(2, 100);
    Console.WriteLine($"Выпало число {number}");

    void multiply(int n)
    {
        Console.WriteLine("");
        for (int i = 1; i <= 9; i++)
        {
            Console.WriteLine($"{n} * {i} = {n * i}");
        }

    }
    for (int start = 1; start <= number; start++)
    {
        multiply(start);
    }

}
// Задача 9. Дана игра со следующими правилами. Первый игрок называет любое натуральное число от 2 до 9, второй умножает его на любое натуральное число от 2 до 9, первый умножает результат на любое натуральное число от 2 до 9 и т. д. Выигрывает тот, у кого впервые получится число больше 1000. Запрограммировать консольный вариант игры.

void TaskHard9()
{
    Console.WriteLine("");
    Console.WriteLine("Добро пожаловать в игру 'Умножай и влавствуй'");
    Console.WriteLine("");
    int number = 1;
    int player = 1;
    int answer;
    void changePlayer() // метод смены игрока
    {
        if (player == 1)
        {
            player = 2;
        }
        else
        {
            player = 1;
        };
    }
    void turn() // метод хода
    {
        Console.WriteLine($"Текущий счёт: {number}");
        Console.Write($"Игрок {player}, введите число от 2 до 9: ");
        answer = Convert.ToInt32(Console.ReadLine());
        if (answer < 2 || answer > 9)
        {
            Console.WriteLine("Вы ввели неверное число.");
        }
        else
        {
            number *= answer;
            changePlayer();
        };
    }

    while (true) // бесконечный цикл на игру
    {
        if (number <= 1000) // продолжение игры
        {
            turn();
        }
        else // конец игры
        {
            changePlayer();
            Console.WriteLine($"Победил игрок {player} со счётом {number}"); // вывод победителя
            break;
        }
    }

}

// Вызов каждой задачи. При желании любую можно закомментировать
// Task1();
// Task2();
// Task3();
// Task4();
// TaskHard1();
// TaskHard2();
// TaskHard3();
// TaskHard4();
// TaskHard5();
// TaskHard6();
// TaskHard7();
TaskHard8();
// TaskHard9();