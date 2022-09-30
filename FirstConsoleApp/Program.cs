// See https://aka.ms/new-console-template for more information
/*Console.WriteLine("Adinizi daxil edin: ");
//var ad = Console.ReadLine();
Console.WriteLine("Salam " + ad);

// DataTypes  : string, bool, int, long, decimal, float, char, byte //
////////////////////////////////////////////////////////////////////
/*console.writeline - вывод результата на консоль
Console.ReadLine - используется для ввода строки символов типа string
Convert.ToInt32 - Статические методы Convert класса в основном используются для поддержки преобразования 
в базовые типы данных в . NET и из них. Поддерживаемые базовые типы: Boolean, , 
ByteSByteInt16Int32Int64UInt16CharUInt64UInt32Singleи .



// string name = "Turan";
// string surname = "Sadiqov";


string name, surname;

name = "Turan";
surname = "Sadiqov";*/
/*Console.WriteLine("Please write your name: ");
var name = Console.ReadLine();
Console.WriteLine("Hi" + name);
Console.WriteLine("please write your surname: ");
var surname = Console.ReadLine();
Console.WriteLine("Hi" + surname);*/
/*Console.WriteLine("enter first number: ");
int num, num1;
num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(" enter second number: ");
num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("The result is: " + (num + num1));*/

/*double num;
Console.WriteLine("How old are you?");
num = Convert.ToDouble(Console.ReadLine());
if (num > 18.5)
   Console.WriteLine("You are older than 18.5");
else 
   Console.WriteLine("Num<=18.5");*/

   /*int a , b , c;
   bool d, e;
   char r = 'H';
   d = true;
   e = false;
   a = Convert.ToInt32 (Console.ReadLine());
   b = Convert.ToInt16 (Console.ReadLine());
   c = a + b;
   Console.WriteLine(c);
   if (c>100)
   Console.WriteLine(d);
   else
   Console.WriteLine(e);
   Console.WriteLine(r);*/

   /*string data;
data = Console.ReadLine();

Console.WriteLine("Hello" + data);*/
using System.Globalization;
string str = "12,5";
NumberFormatInfo num = new NumberFormatInfo()
{
   NumberDecimalSeparator = " , ", 
};
double d = Convert.ToDouble(str);
Console.WriteLine(d);
double a;
Console.WriteLine("Enter a ");
a = Convert.ToDouble(Console.ReadLine());
double res = a + d;
Console.WriteLine("Our result is " + res);






