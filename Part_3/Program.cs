// Part_3 Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
int dayNumber = ReadInt("Введите число от 1 до 7: ");
Console.WriteLine(WorkHoliday(dayNumber));
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
string WorkHoliday(int a)
{
    if (a > 0 && a < 8)
{
    if (a == 7 || a == 6)
{
    Console.Write("День " + a + " - выходной");
}
    else
{
    Console.Write("День " + a + " - рабочий");
}
}
    else
 {
    Console.Write("Вы ввели число отличное от 1 до 7, поэтому нелья определить какой день");
}
return "";
}