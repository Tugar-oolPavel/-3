/*
int b = 0;
Random R = new Random();
Console.Write("Введите количество попыток ");
int k = int.Parse(Console.ReadLine());
Console.Write("Введите максимальное число ");
int n = int.Parse(Console.ReadLine());
int D = R.Next(1, n + 1);
int[] a = new int[k];
for (int i = 0; i < a.Length; i++)
{
    Console.Write("Введите число ");
    int с = int.Parse(Console.ReadLine());
    if (с == D)
    {
        Console.WriteLine("Поздравляю, вы угадали!");
        break;
    }
    else
    {
        b++;
        Console.WriteLine("Неудача, введите еще раз.");
    }
}
if (b > k) 
    Console.WriteLine("Попытки кончились, повезет в следующий раз!");
else if (b == 0) 
    Console.WriteLine("Поздравляю, вы угадали!");
Console.WriteLine("Число, которое загадал компьютер " + D);
*/

/*
int leap(int a)
{
    if (a % 4 == 0 && a % 100 != 0 || a % 400 == 0)
    {
        return 1;
    }
    else
    {
        return 0;
    }

}
Console.WriteLine("Введите номер дня ");
int d = int.Parse(Console.ReadLine());
Console.WriteLine("Введите номер месяца ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите номер года ");
int y = int.Parse(Console.ReadLine());
int[,] day = new int[2, 12] {{31,28,31,30,31,30,31,31,30,31,30,31 },{31,29,31,30,31,30,31,31,30,31,30,31}};
int gap = 0;
    for (int i = 325; i <= y; i++)
    {
        if ((i % 100 == 0) && (i % 400 != 0))
        {
            gap++;
        }
    }
    d += gap;
    if (d > day[leap(y),m - 1])
    {
        d -= day[leap(y),m - 1] - 1;
        m++;
        if (m > 12)
        {
            m = m % 12;
            y++;
        }
    }
Console.WriteLine("Дата по современному календарю "+d+" "+m+" "+y);
*/

/*
using System.Globalization;
DateTime day;
GregorianCalendar cal = new GregorianCalendar();
int kolDay, today;
Console.Write("Введите день ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите месяц ");
int b = int.Parse(Console.ReadLine());
Console.Write("Введите год ");
int c = int.Parse(Console.ReadLine());
string data = $"{c}, {b}, {a}";
if (DateTime.TryParse(data, out day))
{
    today = cal.GetDayOfYear(day);
    Console.WriteLine($"Номер этого дня с начала года {today}");
    if (cal.IsLeapYear(c))
    {
        kolDay = 366 - today;
    }
    else
    {
        kolDay = 365 - today;
    }
    Console.WriteLine($"Полных дней осталось до конца года {kolDay}");
}
else
{
    Console.WriteLine("Некорректная дата.");
}
*/

/*
Console.WriteLine("Введите год: ");
int x = int.Parse(Console.ReadLine());
for (int i = 1; i <= 12; i++)
{
    DateTime d = new DateTime(x, i, DateTime.DaysInMonth(x, i));
    Console.WriteLine($"Санитарный день {d.Month} месяц: {d.Day - (7 + (int)d.DayOfWeek - 4) % 7} числа");
}
*/

Random R = new Random();
Console.Write("Введите количество элементов массива ");
int N = int.Parse(Console.ReadLine());
int[] A = new int[N];
Console.WriteLine("Начальный массив");
for (int i = 0; i < A.Length; i++)
{
    A[i] = R.Next(-100, 100);
    Console.WriteLine(A[i]);
}
int[] mas = new int[N];
for (int i = 0; i < mas.Length; i++)
{
    int a = R.Next(1, mas.Length + 1);
    if (!mas.Contains(a))
        mas[i] = a;
    else i--;
}
Console.WriteLine("Конечный массив");
for (int i = 0; i < mas.Length; i++)
{
    Console.WriteLine(A[mas[i] - 1]);
}
