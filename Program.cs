
using System;
using System.Collections;

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

    Console.WriteLine(""); //пустая строка для красоты
    Console.WriteLine("Данная программа определяет оптимальный маршрут для торгового менеджера в заданной четверти");
    int randomPoint(int beginning, int end)
    {
        var rand = new Random();
        return rand.Next(beginning, end);
    }

    Console.Write("Введите номер четверти (от 1 до 4) ");

    int quater;

    while (true) // определяется номер четерти
    {
        quater = Convert.ToInt32(Console.ReadLine());
        if (quater > 0 && quater < 5)
        {
            Console.WriteLine($"Выбрана {quater} четверть.");
            break;
        }
        else
        {
            Console.WriteLine("Введена несуществующая четверть");
        }
    }

    int Ax = 0;
    int Ay = 0;
    int Bx, Cx, Dx, By, Cy, Dy;


    if (quater == 1 || quater == 4)  // формирование координат Х
    {
        Bx = randomPoint(0, 100);
        Cx = randomPoint(0, 100);
        Dx = randomPoint(0, 100);
    }
    else
    {
        Bx = randomPoint(-100, 0);
        Cx = randomPoint(-100, 0);
        Dx = randomPoint(-100, 0);
    }

    if (quater == 1 || quater == 2)  // формирование координат y
    {
        By = randomPoint(0, 100);
        Cy = randomPoint(0, 100);
        Dy = randomPoint(0, 100);
    }
    else
    {
        By = randomPoint(-100, 0);
        Cy = randomPoint(-100, 0);
        Dy = randomPoint(-100, 0);
    }

    double spread(int x1, int y1, int x2, int y2)
    {
        double answer = Math.Sqrt((Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2)));
        return answer;
    }

    double AB = spread(Ax, Ay, Bx, By); //определяем расстояния между всеми точками
    double AC = spread(Ax, Ay, Cx, Cy);
    double AD = spread(Ax, Ay, Dx, Dy);
    double BD = spread(Bx, By, Dx, Dy);
    double BC = spread(Bx, By, Cx, Cy);
    double CD = spread(Cx, Cy, Dx, Dy);

    //считаем все возможные варианты:
    double ABCD = Math.Round(AB + BC + CD, 2);
    double ACBD = Math.Round(AC + BC + BD, 2);
    double ABDC = Math.Round(AB + BD + CD, 2);
    double ACDB = Math.Round(AC + CD + BD, 2);
    double ADCB = Math.Round(AD + CD + BC, 2);
    double ADBC = Math.Round(AD + BD + BC, 2);

    //вычисляем минимум

    string minimalName = "ABCD";
    double minimal = ABCD;
    void findMinimal(double candidate, string candidateName)
    {
        if (candidate < minimal)
        {
            minimalName = candidateName;
            minimal = candidate;
        }
    }
    findMinimal(ACBD, nameof(ACBD));
    findMinimal(ABDC, nameof(ABDC));
    findMinimal(ACDB, nameof(ACDB));
    findMinimal(ADCB, nameof(ADCB));
    findMinimal(ADBC, nameof(ADBC));


    //вывод данных и результатов

    Console.WriteLine($"Введены следующие точки: ");
    Console.WriteLine($"Точка B с координатами {Bx} {By}");
    Console.WriteLine($"Точка C с координатами {Cx} {Cy}");
    Console.WriteLine($"Точка D с координатами {Dx} {Dy}");

    Console.WriteLine(""); //пустая строка для красоты
    Console.WriteLine("Варианты маршрутов:");
    Console.WriteLine($"Маршрут ABCD с расстоянием {ABCD}");
    Console.WriteLine($"Маршрут ABDC с расстоянием {ABDC}");
    Console.WriteLine($"Маршрут ACBD с расстоянием {ACBD}");
    Console.WriteLine($"Маршрут ACDB с расстоянием {ACDB}");
    Console.WriteLine($"Маршрут ADCB с расстоянием {ADCB}");
    Console.WriteLine($"Маршрут ADBC с расстоянием {ADBC}");

    Console.WriteLine(""); //пустая строка для красоты

    Console.WriteLine($"Самым кратчайшим путём является {minimalName} с расстоянием {minimal}");

    Console.WriteLine(""); //пустая строка для красоты

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

    Hashtable averageTemperatures = new Hashtable(); //создаём хэш таблицу для высоких и низких температур
    var rand = new Random();
    DateTime dateNow = DateTime.Today;
    Console.WriteLine($"Сегодня: {dateNow:d}"); //определяем текущую дату

    for (int i = 0; i < 120; i++) // Заполнение массива. 120 - колличество месяцев в задании
    {
        double temp = rand.Next(-50, 50);
        averageTemperatures[dateNow.AddMonths(-i)] = temp; //Добавляется температура в заданную дату
    }

    //ввод данных пользователем
    Console.WriteLine($"Имеются данные от {dateNow.AddMonths(-120):d} до {dateNow:d}");


    DateTime insertDate() // функция приёма даты от пользователя
    {
        int Year;
        int Month;
        while (true)
        {
            Console.Write("Введите год периода: ");
            Year = int.Parse(Console.ReadLine());
            Console.Write("Введите месяц периода: ");
            Month = int.Parse(Console.ReadLine());
            if (Month > 0 && Month < 13) // проверка месяца на валидность
            {
                break;
            }
            Console.WriteLine("Вы ввели некорректную дату");
        }
        return new DateTime(Year, Month, dateNow.Day);
    }

    Console.WriteLine("Введите Год и Месяц начала периода:");
    DateTime CheckingDateStart = insertDate();
    Console.WriteLine("Введите Год и Месяц окончания периода:");
    DateTime CheckingDateEnd = insertDate();

    if (CheckingDateStart > CheckingDateEnd) // проверка на то, что начало периода раньше окончания
    {
        Console.WriteLine("Даты поменяны местами, так как окончание не может быть раньше начала.");
        DateTime Temp = CheckingDateStart;
        CheckingDateStart = CheckingDateEnd;
        CheckingDateEnd = Temp;
    }

    Console.WriteLine($"Дата начала проверяемого периода: {CheckingDateStart.Month}.{CheckingDateStart.Year}");
    Console.WriteLine($"Дата окончания проверяемого периода: {CheckingDateEnd.Month}.{CheckingDateEnd.Year}");

    int SummerMax = -51; // цифры введены за границей генерируемых. По ним будем определять отсутствие данных значений в проверяемом периоде
    int AutumnMax = -51;
    int WinterMax = -51;
    int SpringMax = -51;
    int SummerMin = 51;
    int AutumnMin = 51;
    int WinterMin = 51;
    int SpringMin = 51;

    for (DateTime date = CheckingDateStart; date < CheckingDateEnd; date = date.AddMonths(+1))
    {
        int CurrentTemp = Convert.ToInt32(averageTemperatures[date]);
        if (date.Month == 1 || date.Month == 2 || date.Month == 12) // проверяем зиму
        {
            if (CurrentTemp > WinterMax)
            {
                WinterMax = CurrentTemp;
            }
            if (CurrentTemp < WinterMin)
            {
                WinterMin = CurrentTemp;
            }
        }

        if (date.Month == 3 || date.Month == 4 || date.Month == 5) // проверяем весну
        {
            if (CurrentTemp > SpringMax)
            {
                SpringMax = CurrentTemp;
            }
            if (CurrentTemp < SpringMin)
            {
                SpringMin = CurrentTemp;
            }
        }

        if (date.Month == 6 || date.Month == 7 || date.Month == 8) // проверяем лето
        {
            if (CurrentTemp > SummerMax)
            {
                SummerMax = CurrentTemp;
            }
            if (CurrentTemp < SummerMin)
            {
                SummerMin = CurrentTemp;
            }
        }

        if (date.Month == 6 || date.Month == 7 || date.Month == 8) // проверяем осень
        {
            if (CurrentTemp > AutumnMax)
            {
                AutumnMax = CurrentTemp;
            }
            if (CurrentTemp < AutumnMin)
            {
                AutumnMin = CurrentTemp;
            }
        }

    }


    void answer(int wMin, int wMax, string periodYear)   //вывод ответа
    {
        Console.WriteLine(""); // пустая строка для красоты
        Console.WriteLine($"{periodYear}:");
        if (wMax != -51)
        {
            Console.WriteLine($"Набольшая температура: {wMax}");
            Console.WriteLine($"Наименьшая температура: {wMin}");
        }
        else
        {
            Console.WriteLine("Наибольшую и наименьшую температуру невозможно определить.");
        }
    }
    answer(WinterMin, WinterMax, "Зима");
    answer(SpringMin, SpringMax, "Весна");
    answer(SummerMin, SummerMax, "Лето");
    answer(AutumnMin, AutumnMax, "Осень");
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
    var rand = new Random();
    int[] arr = new int[100];
    int[] newArr = new int[100];
    int deletedCounter = 0;
    int j = 0; // счётчик для нового массива
    for (int i = 0; i < 100; i++)
    {
        arr[i] = rand.Next(1, 101);
    }
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < 10) // проверяем числа от 1 до 10;
        {
            if (arr[i] == 3)
            {
                deletedCounter += 1;
            }
            else
            {
                newArr[j] = arr[i];
                j++;
            }
        }
        else // проверяем оставшиеся числа. Отдельного условия для 100 не создаем - он вдаст правельнйы результат и при данном алгоритме.
        {
            if (arr[i] / 30 == 1 || arr[i] % 10 == 3)
            {
                deletedCounter += 1;
            }
            else
            {
                newArr[j] = arr[i];
                j++;
            }
        }
    }
    int[] newCleanArr = new int[j];
    for (int i = 0; i < j; i++)
    {
        newCleanArr[i] = newArr[i];
    }
    Console.WriteLine("");//пустая строка для красоты
    Console.WriteLine("Первоначальный массив: ");
    Console.WriteLine(String.Join(" ", arr));
    Console.WriteLine("");//пустая строка для красоты
    Console.WriteLine($"Удаленых элементов: {deletedCounter}");
    Console.WriteLine("");//пустая строка для красоты
    Console.WriteLine($"Длинна нового массива: {newCleanArr.Length}");//
    Console.WriteLine("");//пустая строка для красоты
    Console.WriteLine("Новый массив: ");
    Console.WriteLine(String.Join(" ", newCleanArr));

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
            changePlayer(); // отмена предыдущей смены игрока
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
TaskHard4();
// TaskHard5();
// TaskHard6();
// TaskHard7();
// TaskHard8();
// TaskHard9();


