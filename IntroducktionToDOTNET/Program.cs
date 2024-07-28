//#define CONSOLE_PARAMETERS 
//#define INPUT_DATA
//#define DATA_TYPES
//#define LITERALS

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionToDOTNET
{
	internal class Program
	{
		static readonly string delimeter = "\n-----------------------------------------\n";
		static void Main(string[] args)
		{
			Console.Title = "Introduction to .NET";
#if CONSOLE_PARAMETERS
			Console.Beep(137, 1000);
			Console.BackgroundColor = ConsoleColor.DarkBlue;
			//Console.CursorLeft = 22;
			//Console.CursorTop = 11;
			Console.SetCursorPosition(22, 7);
			Console.Write("Hello .NET\n");      //Поддержка escape последовательностей
			Console.WriteLine("Introduction");  //Перевод курсора в начало следующей строки
			Console.BackgroundColor = ConsoleColor.Green;
			Console.ResetColor(); 
#endif
#if INPUT_DATA
			Console.Write("Введите ваше имя: ");
			string first_name = Console.ReadLine();
			Console.Write("Введите вашу фамилию: ");
			string last_name = Console.ReadLine();
			Console.Write("Введите ваш возраст: ");
			int age = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Ваше имя: " + first_name + ", " + "Ваша фамилия: " + last_name + ", " + "Ваш возраст: " + age); //конкатенация строк
			Console.WriteLine(String.Format("Ваше имя: {0}, Ваша фамилия: {1}, Ваш возраст: {2}", first_name, last_name, age)); //форматирование строк
			Console.WriteLine($"Ваше имя: {first_name}, Ваша фамилия: {last_name}, Ваш возраст: {age}"); //интерполяция строк  
#endif

#if DATA_TYPES
            //Console.WriteLine("---Bool---");
            //Console.WriteLine(bool.FalseString);
            //Console.WriteLine(bool.TrueString);
            //Console.WriteLine("---Char---");
            //Console.WriteLine(sizeof(char));
            //Console.WriteLine((int)char.MinValue);
            //Console.WriteLine((int)char.MaxValue);
            //Console.WriteLine("---Short---");
            //Console.WriteLine(sizeof(short));
            //Console.WriteLine($"{short.MinValue} to {short.MaxValue}");
            //Console.WriteLine("--uShort---");
            //Console.WriteLine(sizeof(ushort));
            //Console.WriteLine($"{ushort.MinValue} to {ushort.MaxValue}");
			Console.WriteLine(delimeter);
            Console.WriteLine($"Переменная типа 'short' занимает {sizeof(short)} байт памяти, и принимает значения в диапазоне ");
            Console.WriteLine($"ushort: {ushort.MinValue} ... {ushort.MaxValue}");
            Console.WriteLine($"short: {short.MinValue} ... {short.MaxValue}");
			Console.WriteLine($"Класс-обвертка: Int16");
			Console.WriteLine(delimeter);
			Console.WriteLine($"Переменная типа 'int' занимает {sizeof(int)} байт памяти, и принимает значения в диапазоне ");
			Console.WriteLine($"uint: {uint.MinValue} ... {uint.MaxValue}");
			Console.WriteLine($"int: {int.MinValue} ... {int.MaxValue}");
			Console.WriteLine($"Класс-обвертка: Int32");
			Console.WriteLine(delimeter);
			Console.WriteLine($"Переменная типа 'long' занимает {sizeof(long)} байт памяти, и принимает значения в диапазоне ");
			Console.WriteLine($"ulong: {ulong.MinValue} ... {ulong.MaxValue}");
			Console.WriteLine($"long: {long.MinValue} ... {long.MaxValue}");
			Console.WriteLine($"Класс-обвертка: Int64");
			Console.WriteLine(delimeter);
			Console.WriteLine($"Переменная типа 'float' занимает {sizeof(float)} байт памяти, и принимает значения в диапазоне ");
			Console.WriteLine($"float: {float.MinValue} ... {float.MaxValue}");
			Console.WriteLine($"Класс-обвертка: Single");
			Console.WriteLine(delimeter);
			Console.WriteLine($"Переменная типа 'double' занимает {sizeof(double)} байт памяти, и принимает значения в диапазоне ");
			Console.WriteLine($"double: {double.MinValue} ... {double.MaxValue}");
			Console.WriteLine($"Класс-обвертка: Double");
			Console.WriteLine(double.Epsilon);
			//IEEE-754
			Console.WriteLine(delimeter);
			Console.WriteLine($"Переменная типа 'decimal' занимает {sizeof(decimal)} байт памяти, и принимает значения в диапазоне ");
			Console.WriteLine($"decimal: {decimal.MinValue} ... {decimal.MaxValue}");
			Console.WriteLine($"Класс-обвертка: Decimal");
			Console.WriteLine(delimeter);

#endif
#if LITERALS
            Console.WriteLine(((object)5.0m).GetType());
            //Console.WriteLine(Int16.MaxValue);
            Console.WriteLine("+".GetType());
#endif
			int a = 2000000000;
			int b = 5;
            ////a = b; // CS0266
            //a = (short)b; 
            //b = a;

            ////uint c = b; //CS0266
            //uint c = (uint)b; //CS0266
            //Console.WriteLine(c);

            Console.WriteLine((a*b).GetType());

        }
	}
}
