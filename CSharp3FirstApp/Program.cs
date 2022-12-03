#region описание типов

{
    // однострочный коментарий
    // dsfdsfndsjk
    // dsfds
    Console.WriteLine("Привет");

    /* 
      Многосточный комментарий
     daskmdaskl
    dsaklndklasndas
    jnkjsadnkjsa
    jnaskjdnsakj
    jkdnaskjndaskjdnask
     */

    {

    }

    // тип_переменной название_переменной;
    // объявление переменной
    int a; // переменная типа цплочисленная (integer) с названием а
    a = 34; // присваивание

    int b = 34; // объяеление + присваивание

    const int one = 1; // константа
    /// константу менять нельзя: one = 2;
    // константам присваивают значения в момент создания, нельзя: const int two;

    // литералы:
    string str = "Привет";
    // string str2 = 12; В строку нельзя присвоить число
    char a1 = 'a';


    // типы данных
    // целочисленные
    byte b1; // целое число от 0 до 255 (1 байт)
    sbyte a2; // целое число от -128 до 127 (1 байт)
    short a3; // цлое число -32768 до 32767 (2 байта)
    ushort b2; // целое число 0 до 65535 (2 байта)
    int a4; // целов число -2147483648 до 2147483647 (4 байта)
    uint a5; // 0 до 4294967295 и занимает 4 байта
    long a6; // –9 223 372 036 854 775 808 до 9 223 372 036 854 775 807 и занимает 8 байт
    ulong a7; // от 0 до 18 446 744 073 709 551 615 и занимает 8 байт

    int a12 = 10;
    byte b12 = 10;
    ulong a14 = 1234;
    a14 = 123ul;

    int x = 0b1100101; // двоичный литерал
    int y = 0xff55ee; // шестнадчатиричный литерал

    bool z = false;
    bool z1 = true;

    float f; // число с плавающей точкой -3.4*10^38 до 3.4*10^38 и занимает 4 байта
    double d; // хранит число с плавающей точкой от ±5.0*10^-324 до ±1.7*10^308 и
              // занимает 8 байта
    decimal dd; // хранит десятичное дробное число. Если употребляется
                // без десятичной запятой, имеет значение от ±1.0*10-28 до
                // ±7.9228*10^28, может хранить 28 знаков после запятой и
                // занимает 16 байт.

    float xx = 2.43f; // постфикс f, чтобы привреатить литерал double -> float
    double dd2 = 2.43;
    decimal dd3 = 2.43m; // постфикс m, чтобы привреатить литерал double -> decimal

    char symb = 'd'; // символ

    string str3 = "dsahsadhjdas sadnjasknd sdnfaskjdnsa\x5A\t\r\n\\";
    string str4 = "Привет, как дела?\r\nПока";
    Console.WriteLine(str4);

    string str5 = "Наша страна называется \"Россия\"";
    Console.WriteLine(str5);

    string path = "C:\\Users\\stud_cdpo\\Desktop\\MySchool\\MySchool\\Data";
    string path2 = @"C:\Users\stud_cdpo\Desktop\MySchool\MySchool\Data";

    string name = "Вася";
    string message = "Привет " + name;
    Console.WriteLine(message);

    string message2 = $"Привет, {name}";
    Console.WriteLine(message2);

    int age = 43;
    string desc = "любит футбол";

    string message3 = "Привет, " + name + ", ему " + age + " года и он " + desc;
    string message4 = $"Привет, {name}, ему {age + 1} года и {desc}";

    object obj = null; // null - пустая ссылка 
    obj = 123;
    obj = "12223";

    // атоматически определаяемы тип данных в момент присваивания
    var abc = "asdsadas sadsadas";
    var ee3 = 12;
    var dd45 = 12.34f;

    var s = "qwerty";

    int? myVar = null; // Nullable переменные
    string? vv = null;
}
#endregion

#region первая программа
//{
//    // все переменные, определнные в {} видны только внутри {}

//    Console.WriteLine("=======================================");
//    Console.WriteLine("Как ваше имя?");
//    var name = Console.ReadLine();
//    Console.WriteLine($"Привет, {name}");
//}
#endregion

#region Арифметические и порзрадные операции
{
    // + - * / ++ -- += %
    float a = 10, b = 18;
    var c = a + b; // 22
    var d = (a + b) * a; // != a + b * a
    float e = b / a;
    Console.WriteLine(e);

    a = a + b;
    a += b; // a += b -> a = a + b
    a++; // a = a + 1
    a--; // a = a - 1;
    var ee = ++a; // a = a + 1; ee = a
    var ee2 = a++;// ee2 = a; a = a + 1;

    var tt = a % 2; // остаток от деления

    int a1 = 7;
    int a2 = 5;
    /*
        0 - 0000
        1 - 0001
        2 - 0010
        3 - 0011
        4 - 0100
        5 - 0101
        6 - 0110
        7 - 0111
        8 - 1000
        9 - 1001
        10 - 1010
        11 - 1011
        12 - 1100
        13 - 1101
        14 - 1110
        15 - 1111
        16 - 10000
     */

    var a3 = a1 & a2; // 0111 & 0101 = 0101 = 5 (порязрядное и)
    Console.WriteLine(a3);

    var a4 = a1 | a2; // 0111 | 0101 = 0111 = 7 (поразрядное или)
    Console.WriteLine(a4);

    var a5 =~a1; // ~0111 = 1000 = -8 (поразрядное отрицание)
    Console.WriteLine(a5);

    var a6 = a1 >> 1; // сдвиг вправо 00000111 >> 1 = 00000011 = 3
    Console.WriteLine(a6);

    var a7 = a1 << 1; // сдвиг влево 00000111 << 1  = 00001110 = 14
    Console.WriteLine(a7);

    var read = 1; // 0001
    var write = 2; // 0010
    var execute = 4; // 0100

    var readAndWrite = read | write; // 0001 | 0010 = 0011 = 3
    var res = readAndWrite & read; // 0011 & 0001 = 0001 = read
    var res2 = readAndWrite & write; // 0011 & 0010 = 0010 = write
    var res3 = readAndWrite & execute; // 0011 & 0100 = 0000

}
#endregion

#region опреации присваивания
{
    var a = 12;
    int b, c, d;
    b = c = d = 10;

    // A x= B <=> A = A x B
}
#endregion

#region преобразование типов
{
    int a = 12123;
    long b = a; // неявное преобразование (расширяющее)

    long c = 1321312;
    int d = (int) c; //неявное преобразование для сужающего не работает
                     // явное проебразование типов

    double f = 123.45;
    float f2 = (float) f;

    int g = -122;
    uint g2 = (uint) g;

    int a1 = 33;
    int b1 = 100;
    byte c1 = checked((byte)(a1 + b1));
    Console.WriteLine(c1);
}
#endregion

#region условные операторы if
{
    if(true/*условие*/)
    {
        // что делать, емли условие выполнено
    }

    if (true/*условие*/)
    {
        // что делать, емли условие выполнено
    }
    else // необязательная часть
    {
        // что делать, если условие не выволнено
    }

    if(true/*условие*/)
    {
        // что делать, емли условие выполнено
    }
    else if(true/*условие2*/) // необязательная часть
    {
        // что делать, если условие 1 не выполнено, а условие 2 выполнено
    }
    else // необязательная часть
    {
        // что делать, если условие не выволнено
    }

    // пример
    var a = 10;
    if(a > 8)
    {
        Console.WriteLine("Число а меньше 8");
    }

    // Альттернативно, толкьо в случае одного выражения внутри блока
    var b = 10;
    if (b < 8)
        Console.WriteLine("Число b меньше 8");

    var c = 10;
    if (c < 8)
    {
        Console.WriteLine("Число c меньше 8");
        Console.WriteLine("dsadasdas");
    }

    if(c > 2 && c < 4) // && = и
    {

    }

    if(a < 2 || a > 5) // || = или
    {

    }

    string d = null;
    if(d != null && d.Length > 10) // == проверка на равно 
        // != не равно
    {

    }


    if ((a < 2 || a > 10) && a > 0)
    {

    }

    bool res = (a < 2 || a > 10) && a > 0;
    if(res)
    {

    }
}
#endregion

#region условные операторы: if пример
//{
//    Console.WriteLine("Как выше имя?");
//    var name = Console.ReadLine();

//    Console.WriteLine("Укажите пол (м/ж)");
//    var gender = Console.ReadLine();

//    Console.WriteLine("Сколько вам лет?");
//    var strAge = Console.ReadLine();
//    var age = Convert.ToInt32(strAge);

//    var maxAge = 10;

//    //string prefix = "Уважаемое";
//    //if (age > maxAge && gender == "м")
//    //    prefix = "Уважаемый";
//    //else if (age > maxAge && gender == "ж")
//    //    prefix = "Уважаемая";
//    //else if (age <= maxAge)
//    //    prefix = "Привет";

//    string prefix = "Уважаемое";
//    if (age > maxAge)
//    {
//        if (gender == "м")
//            prefix = "Уважаемый";
//        else if (gender == "ж")
//            prefix = "Уважаемая";
//    }
//    else
//        prefix = "Привет";

//    Console.WriteLine($"{prefix}, {name}, добро пожаловать");
//}
#endregion

#region условные опреаторы - тернарный
{
    // условие ? что делать, есkи правда : что делать, если ложь;
    var a = 10;
    var numberDescr = a % 2 == 0 ? "четное" : "нечетное";
    Console.WriteLine(numberDescr);

    var numberDescr2 = "";
    if (a % 2 == 0)
        numberDescr2 = "четное";
    else
        numberDescr2 = "нечетное";
}
#endregion

#region условные операторы - тернарный: пример
if(false)
{
    Console.WriteLine("Введите любое неотрицательное целое число");
    var strNumber1 = Console.ReadLine();
    var number1 = Convert.ToInt32(strNumber1);

    Console.WriteLine("Введите еще одно любое неотрицательное " +
        $"целое число большее {number1}");
    var strNumber2 = Console.ReadLine();
    var number2 = Convert.ToInt32(strNumber2);

    var isDividing = ( number2 % number1 == 0 ? "делится" : "не делится" );
    Console.WriteLine($"Число {number2} {isDividing} {number1}");
}
#endregion  

#region Условие switch
{
    //switch(переменная)
    //{
    //    case Значение1:
    //        // что делать в случае, если переменная == Значение1
    //        break;
    //    case Значение2:
    //        // что делать в случае, если переменная == Значение2
    //        break;
    //    case Значение3:
    //        // что делать в случае, если переменная == Значение3
    //        break;
    //    default:
    //        // что делать в случае, если не выволнен ни один их кейсов
    //}
}
#endregion

#region Условие switch: пример
if(false)
{
    Console.WriteLine("Какой сегодня день недели?");
    var day = Console.ReadLine();

    string msg = "";
    //switch (day)
    //{
    //    case "Понедельник":
    //        msg = "До выходных осталось 5 дней =(";
    //        break;
    //    case "Вторник":
    //        msg = "До выходных осталось 4 дня =(";
    //        break;
    //    case "Среда":
    //        msg = "До выходных осталось 3 дня =/";
    //        break;
    //    case "Четверг":
    //        msg = "До выходных осталось 2 дней =|";
    //        break;
    //    case "Пятница":
    //        msg = "До выходных осталось 1 день =)";
    //        break;
    //    case "Суббота":
    //        msg = "Ура! Первый выходной";
    //        break;
    //    case "Воскресенье":
    //        msg = "Ура! Второй выходной";
    //        break;
    //    default:
    //        msg = "Непонятно, что за день";
    //        break;
    //}
    switch (day)
    {
        case "Понедельник":
        case "Вторник":
        case "Среда":
        case "Четверг":
        case "Пятница":
            msg = "Рабочий день";
            break;
        case "Суббота":
        case "Воскресенье":
            msg = "Выходной";
            break;
        default:
            msg = "Непонятно, что за день";
            break;
    }
    Console.WriteLine(msg);
}
#endregion

#region switch: новый синтаксис
if(false)
{
    Console.WriteLine("Какой сегодня день недели?");
    var day = Console.ReadLine();
    day = day.ToLower();

    var msg = day switch
    {
        // значение => что возвращаеть в случае совпдаения
        "понедельник" => "До выходных осталось 5 дней =(",
        "вторник" => "До выходных осталось 4 дня =(",
        "среда" => "До выходных осталось 3 дня =/",
        "четверг" => "До выходных осталось 2 дней =|",
        "пятница" => "До выходных осталось 1 день =)",
        "суббота" => "Ура! Первый выходной",
        "воскресенье" => "Ура! Второй выходной",
        _ => "Непонятно, что за день", // _ = default (ни одно из значений не подошло)
    };

    //var workDayMsg = "Рабочий день";
    //var freeDayMsg = "Выходной день";

    //var msg = day switch
    //{
    //    "Понедельник" => workDayMsg,
    //    "Вторник" => workDayMsg,
    //    "Среда" => workDayMsg,
    //    "Четверг" => workDayMsg,
    //    "Пятница" => workDayMsg,
    //    "Суббота" => freeDayMsg,
    //    "Воскресенье" => freeDayMsg,
    //    _ => "Непонятно, что за день",
    //};

    Console.WriteLine(msg);
}
#endregion

#region Циклы: while
{
    // сначала проверяется условие
    // если правда, потом выполняется тело
    // опять проверяется условие
    // если правда, потом выполняется тело
    // ...
    while (false/*Условие*/)
    {
        // тело цикла
    } 
    
    // выход из цикла:
    // 1) условие стало ложью
    // 2) в теле цикла команда break
    // 3) в теле цикла команда return
    while(true) // бесконечный цикл
    {
        break;
    }
}
#endregion

#region while: пример
{
    var maxValue = 2000;
    var value = 0;
    var number = 0;
    while(value < maxValue)
    {
        value += number;
        number++;
    }
    Console.WriteLine($"Сумма первых {number} чисел = {value}");
}
#endregion

if (false)
{
    #region Циклы: do while
    {
        // сначала делаем
        // потом проверяем
        //do
        //{

        //}
        //while (условие);

        //do
        //{
        //    Console.WriteLine("Как ваше имя?");
        //    var name = Console.ReadLine();

        //    if (String.IsNullOrEmpty(name))
        //    {
        //        Console.WriteLine("Неправильный ввод");
        //        continue; // завершает итерацию и переходит к условию
        //    }

        //    Console.WriteLine($"Привет, {name}");
        //    break;
        //}
        //while (true);

        string? name = null;
        do
        {
            Console.WriteLine("Как ваше имя?");
            name = Console.ReadLine();
        }
        while (String.IsNullOrEmpty(name));

        string? gender = null;
        do
        {
            Console.WriteLine("Ваш пол (м / ж)?");
            gender = Console.ReadLine();
        }
        while (gender == null || (gender != "м" && gender != "ж"));

        var prefix = gender == "м" ? "Уважаемый" : "Уважаемая";
        Console.WriteLine($"{prefix}, {name}");
        Console.WriteLine("Finish");
    }
    #endregion
}

#region for
{
    //for(/*выражение при старте*/; 
    //    /*Варжение, которое проверяется на каждой итерации*/; 
    //    /*действие на каждой итерации*/)
    //{

    //}

    int i = 0;
    for(i = 0; i < 10; i++)
    {

    }

    for (int j = 0; j < 10; j++)
    {

    }

    for (var j = 0; j < 10; j++)
    {

    }

    var sum = 0;
    var maxNumber = 50;
    for (var k = 0; k < maxNumber; k++)
        sum += k;
    Console.WriteLine($"0 + ... + {maxNumber - 1} = {sum}");

    int counter = 0;
    for (Console.WriteLine("Start loop"); true; Console.WriteLine($"Вполшняется итерация {counter}"))
    {
        counter++;
        if (counter > 10)
            break;
    }

    for (var s = 0; s < 20; s += 2)
        Console.WriteLine(s);
}
#endregion

#region Цикл foreach
{
    // перебирает элементы коллеции
    //foreach(тип_переменной имя_переменной in коллекция)
    //{

    //}

    var str = "Жил-был у бабушки серенький козлик";

    Console.WriteLine("");
    Console.WriteLine("=========== foreach ======================");
    foreach (var s in str)
        Console.Write($"символ {s}\t");

    Console.WriteLine("");
    Console.WriteLine("=========== for ======================");
    for (var i = 0; i < str.Length; i++)
    {
        Console.Write($"символ {str[i]}\t");
    }

    Console.WriteLine("");
    Console.WriteLine("=========== while ======================");
    var j = 0;
    while (j < str.Length)
    {
        Console.Write($"символ {str[j]}\t");
        j++;
    }
}
#endregion

#region Массивы
{
    int[] numbers; // объявление массива
    numbers = new int[5]; // numbers - массив их пяти чисел типа int

    int[] numbers2 = new int[5]; // объявление с выделением памяти
    numbers[0] = 23; // задаем элемент массива с индексом 0
    numbers[1] = 12; // задаем элемент массива с индексом 1
    // numbers[5] = 12; // элемента с индексом 5 не существует
    var number3 = numbers[3]; // получение значения элемента массива с индексом 3

    var numbers3 = new int[10]; // создание массива с 10 элементами int
    numbers3[0] = 1;
    numbers3[1] = 4;
    numbers3[2] = 9;
    numbers3[3] = 12;

    int[] numbers4 = new int[5] { 2, 5, 6, 7, 8 }; // создание с инифицализацией элементов
    int[] numbers5 = { 2, 5, 6, 7, 8 }; // создание с инифицализацией элементов
    object[] numbers6 = { 2, 5, 6, 7, 8 };
    // var numbers = { 1, 2, 4 };// нет работает
    var numbers7 = new int[] { 1, 2, 4, 23, 45 };

    int[] countNumbers = { 23, 45, 11, 56, 22, 56, 87, 3, 34, 67 };
    int max = Int32.MinValue;
    int min = Int32.MaxValue;
    int sum = 0;
    foreach (var number in countNumbers)
    {
        if (number > max)
            max = number;
        if (number < min)
            min = number;
        sum += number;
    }
    Console.Write("\r\n");
    Console.WriteLine($"Max number in array {max}");
    Console.WriteLine($"Min number in array {min}");
    var avg = (float) sum / countNumbers.Length;
    Console.WriteLine($"Avg value in array {avg}");

    Console.WriteLine("Loop array using for");
    max = Int32.MinValue;
    int maxIndex = -1;
    min = Int32.MaxValue;
    int minIndex = -1;
    sum = 0;
    for(var i = 0; i < countNumbers.Length; i++)
    {
        var number = countNumbers[i];
        if (number > max)
        {
            max = number;
            maxIndex = i;
        }
        if (number < min)
        {
            min = number;
            minIndex = i;
        }
        sum += number;
    }
    Console.WriteLine($"Max number in array {max} at position {maxIndex}");
    Console.WriteLine($"Min number in array {min} at position {minIndex}");
    avg = (float)sum / countNumbers.Length;
    Console.WriteLine($"Avg value in array {avg}");

    var dsum = 0f;
    foreach(var number in countNumbers)
    {
        var val = number - avg;
        dsum += val * val;
    }
    var d = dsum / countNumbers.Length;

    dsum = 0f;
    for(int i = 0; i < countNumbers.Length; i++)
    {
        var val = countNumbers[i] - avg;
        dsum += val * val;
    }
}

{
    string[] names = { "Валерия", "Александра", "Юлия", "Людмила", "Клавдия", "Валентина", "Вера" };
    foreach(var name in names)
    {
        if (name.StartsWith("В"))
            Console.WriteLine(name);
    }

    var lastName = names[names.Length - 1];
    Console.WriteLine($"Последний элемент: {lastName}");

    var lastName2 = names[^1]; // -1 первый элемент
    var prevLastName = names[^2];
    Console.WriteLine($"Предпоследний элемент: {prevLastName}");

    Console.WriteLine("Элементы 2, 3, 4");
    var names25 = names[2..5];
    foreach (var name in names25)
        Console.WriteLine(name);

    var res = names[2..^2]; // со второго по предпоследний
}
#endregion

#region Многомерные массивы
{
    int[,] matrix = new int[3, 5];
    matrix[0, 0] = 10;
    matrix[1, 2] = 23;

    int[,] matrix2;

    int[,] a = { { 2, 5, 7, 8 }, { 34, 23, 12, 2 }, { 1, 1, 2, 5} }; // array 3x4
    /* 
        2   5   7   8
        34  23  12  2
        1   1   2   5
     */

    var dim1 = a.GetLength(0);
    var dim2 = a.GetLength(1);
    Console.WriteLine($"{dim1}x{dim2}");

    var dim11 = a.GetUpperBound(0);

    var sum = 0;
    for (int i = 0; i < a.GetLength(0); i++)
        for (int j = 0; j < a.GetLength(1); j++)
            sum += a[1, j];
    Console.WriteLine($"The sum of elements in array is {sum}");

    int[,,,] b = {
        { 
            { { 1, 2, 3}, { 4, 4, 6}, { 2, 2, 5 } }, 
            { { 8, 1, 0 }, { 1, 1, 1}, { 4, 5, 4} } 
        },
        { 
            { { 2, 3, 1}, { 1, 1, 1}, { 4, 5, 6 } }, 
            { { 1, 0, 5}, { 8, 1, 11}, { 1, 2, 3} } 
        },
        { 
            { { 1, 2, 4}, { 2, 4, 5}, { 6, 2, 1 } }, 
            { { 2, 2, 2}, { 1, 1, 1}, { 0, 0, 0 } } 
        }
    }; // 3x2x3x3
    var b1221 = b[1, 1, 2, 1];
}
#endregion

#region массивы массивов (jagged array)
{
    int[][] jagged = new int[4][];
    jagged[0] = new int[]{ 1, 2, 4 };
    jagged[1] = new int[] { 3, 5, 2, 10, 12 };
    jagged[2] = new int[] { 1, 1 };
    jagged[3] = new int[] { 2, 3, 4, 5, 6, 7, 8 };

    /*
        1   2   3
        3   5   2   10  12
        1   1
        2   3   4   5   6   7   8
     */

    var sum = 0;
    for(int i = 0; i < jagged.Length; i++)
    {
        var arr = jagged[i];
        for (var j = 0; j < arr.Length; j++)
            sum += arr[j];
    }
    Console.WriteLine($"Сумма всех элементов равна {sum}");

    var ss = jagged[3][1..4];
    foreach (var n in ss)
        Console.WriteLine(n);
}
#endregion

#region functions
//тип_возвращаемого_значения название_фцнкции(параметры функции)
//{
//    тело функции
//}
//тип_возвращаемого_значения название_фцнкции(тип_параметра1 название_параметра1, 
//    тип_парметра2 название_парметра2)
//{

//}

// вызов функции
PrintHello();
PrintHello();
PrintHello();

PrintHello2("Vasya");
PrintHello2("Petya");
PrintHello2("Olga");

// определили функцию с названием PrintHello, которая не принимает параметров и ничего не возвращает
void PrintHello()
{
    Console.WriteLine("Hello");
}

void PrintHello2(string name)
{
    Console.WriteLine($"Hello, {name}");
}


#endregion





