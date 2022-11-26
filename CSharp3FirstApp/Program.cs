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
    int b1 = 600;
    byte c1 = checked((byte)(a1 + b1));
    Console.WriteLine(c1);
}
#endregion





