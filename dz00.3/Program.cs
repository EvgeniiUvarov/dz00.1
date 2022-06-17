//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет

using System;
using static System.Console;
Clear();

int deynumber = Convert.ToInt32(ReadLine());

if (Math.Abs(deynumber) < 0 || (Math.Abs(deynumber) > 7))
{
    WriteLine("Это не день недели ");
    return;
}

if ((deynumber == 6) || (deynumber == 7))
{
    WriteLine("Это выходной ");
}
else WriteLine("Это рабочий день ");
