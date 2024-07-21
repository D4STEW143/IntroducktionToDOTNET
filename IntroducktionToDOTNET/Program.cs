//#define CONSOLE_PARAMETERS 
//#define INPUT_DATA
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionToDOTNET
{
	internal class Program
	{
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

		}
	}
}
