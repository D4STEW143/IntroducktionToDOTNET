﻿//#define TASK_1
//#define TASK_2
//#define TASK_3
#define TASK_4
//#define TASK_5
//#define TASK_6
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork1
{
	internal class Program
	{
		static void Main(string[] args)
		{

#if TASK_1
            Console.WriteLine("Фигуры.");
            Console.WriteLine();
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++) 
                { Console.Write("*"); }
                Console.WriteLine();
            }
            //------------------------------------------------------
            Console.WriteLine();
            int s = 1;
            do
            {
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < s; j++)
                    { Console.Write("*"); }
                    Console.WriteLine();
                    s++;
                }
            } while (s != 6);
            //------------------------------------------------------
            Console.WriteLine();
            for (int i = 0;i < 5; i++)
            {
                for (int j = 5; j > i; j--)
                { Console.Write("*"); }
                Console.WriteLine();
            }
            //------------------------------------------------------
            Console.WriteLine();
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < i; j++)
                    { Console.Write(" "); }
                for (int k = 5; k > i; k--)
                    { Console.Write("*"); }
                Console.WriteLine();
            }
            //------------------------------------------------------
            Console.WriteLine();
            for (int i = 0; i < 6; i++)
            {
                for (int j = 5; j > i; j--)
                    { Console.Write(" "); }
                for (int k = 0; k < i; k++)
                    { Console.Write("*"); }
                Console.WriteLine();
            }
            //------------------------------------------------------
            Console.WriteLine();
            for (int i = 0; i < 5; i++)
            {
                for (int j = i; j < 5; j++)
                { Console.Write(" "); }
                Console.Write("/");
                for (int j = 0; j < i * 2; j++)
                { Console.Write(" "); }
                Console.Write("\\");
                Console.WriteLine();
            }
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j <= i; j++)
                { Console.Write(" "); }
                Console.Write("\\");
                for (int j = (i + 1) * 2; j < 5 * 2; j++)
                { Console.Write(" "); }
                Console.Write("/");
                Console.WriteLine();
            }

            //------------------------------------------------------
            Console.WriteLine();
            int e = 5;
            for (int i = 0; i < e; i++)
            {
                for (int j = 0; j < e; j++)
                { Console.Write(i % 2 == j % 2 ? "+" : "-"); }
                Console.WriteLine();
            }
#endif

#if TASK_2

			//Console.OutputEncoding = Encoding.GetEncoding(65001); Попытка решить вопрос с кодировкой не увенчалась успехом. Сделал кондово.
			int n = 8;
			Console.Write("┌");
			for (int k = 0; k < n * 2; k++)
			{ Console.Write("─"); }
			Console.WriteLine("┐");
			for (int i = 0; i < n; i++)
			{
				Console.Write("│");
				for (int j = 0; j < n * 2; j++)
				{ Console.Write(i % 2 == j / 2 % 2 ? "█" : " "); }
				Console.WriteLine("│");
			}
			Console.Write("└");
			for (int k = 0; k < n * 2; k++)
			{ Console.Write("─"); }
			Console.WriteLine("┘");
#endif

#if TASK_3
			int l = 5;
			for (int i = 0; i < l; i++)
			{
				for (int j = 0; j < l; j++)
				{
					for (int k = 0; k < l; k++)
					{
						for (int z = 0; z < l; z++)
						{
							if ((i + k) % 2 == 0) Console.Write("██");
							else Console.Write("  ");
						}
					}
					Console.WriteLine();
				}
			}
#endif

#if TASK_4
			//Console.SetWindowSize(60, 30);
			Random rand = new Random();
			int x = rand.Next(Console.WindowWidth - 1);
			int y = rand.Next(Console.WindowHeight - 3);
			//Console.Write("█");
			//Console.SetCursorPosition(0, Console.WindowHeight - 1);
			//Console.WriteLine($"X = {x}, Y = {y}");
			Console.SetBufferSize(Console.WindowWidth, Console.WindowHeight);
			do
			{
				Console.Clear();
				Console.SetCursorPosition(0, Console.WindowHeight - 1);
				Console.WriteLine($"X = {x}, Y = {y}");
				Console.SetCursorPosition(x, y);
				Console.Write("█");
				switch (Console.ReadKey().Key)
				{
					case ConsoleKey.W: case ConsoleKey.UpArrow: y--; break;
					case ConsoleKey.A: case ConsoleKey.LeftArrow: x--; break;
					case ConsoleKey.S: case ConsoleKey.DownArrow: y++; break;
					case ConsoleKey.D: case ConsoleKey.RightArrow: x++; break;
					case ConsoleKey.Escape: return;
				}
				//Решение проблемы с выходом за границы экрана слева сверху. Ограничить справа и снизу пока не догадался как.
				//Вариант через запрос размера буфера по вертикали и горизонтали не дает ограничение, а выкидывает exeption, поэтому его не использую.
				if (x < 0 || y < 0 || x > Console.WindowWidth - 1 || y > Console.WindowHeight - 3) Console.Beep();
				if (x < 0) x = 0;
				if (y < 0) y = 0;
				if (x > Console.WindowWidth - 1) x = Console.WindowWidth - 1;
				if (y > Console.WindowHeight - 3) y = Console.WindowHeight - 3;
				//Console.Clear();
				//Console.SetCursorPosition(0, Console.WindowHeight - 1);
				//Console.WriteLine($"X = {x}, Y = {y}");
				//Console.SetCursorPosition(x, y);
				//Console.Write("█");
			} while (true);

#endif

#if TASK_5

			do
			{
				Console.WriteLine("1.Сложение\t2.Вычитание\t3.Умножение\t4.Деление");
				Console.WriteLine("5.Возведение в степень\t6.Извлечение корня");
				double operand_1, operand_2, answer;
				switch (Convert.ToInt32(Console.ReadLine()))
				{
					case 1:
						{
							Console.Write("Введите операнд 1: ");
							operand_1 = Convert.ToDouble(Console.ReadLine());
							Console.Write("Введите операнд 2: ");
							operand_2 = Convert.ToDouble(Console.ReadLine());
							Console.WriteLine($"Ответ: {answer = operand_1 = operand_2}"); break;
						}
					case 2:
						{
							Console.Write("Введите операнд 1: ");
							operand_1 = Convert.ToDouble(Console.ReadLine());
							Console.Write("Введите операнд 2: ");
							operand_2 = Convert.ToDouble(Console.ReadLine());
							Console.WriteLine($"Ответ: {answer = operand_1 - operand_2}"); break;
						}
					case 3:
						{
							Console.Write("Введите операнд 1: ");
							operand_1 = Convert.ToDouble(Console.ReadLine());
							Console.Write("Введите операнд 2: ");
							operand_2 = Convert.ToDouble(Console.ReadLine());
							Console.WriteLine($"Ответ: {answer = operand_1 * operand_2}"); break;
						}
					case 4:
						{
							Console.Write("Введите операнд 1: ");
							operand_1 = Convert.ToDouble(Console.ReadLine());
							Console.Write("Введите операнд 2: ");
							operand_2 = Convert.ToDouble(Console.ReadLine());
							Console.WriteLine($"Ответ: {answer = operand_1 / operand_2}"); break;
						}
					case 5:
						{
							Console.WriteLine("Введите число для возведения: ");
							operand_1 = Convert.ToDouble(Console.ReadLine());
							Console.WriteLine("Введите степень, в которую нужно возвести число: ");
							operand_2 = Convert.ToDouble(Console.ReadLine());
							Console.WriteLine($"Ответ: {answer = Math.Pow(operand_1, operand_2)}"); break;
						}
					case 6:
						{
							Console.WriteLine("Введите число для извлечения корня: ");
							operand_1 = Convert.ToDouble(Console.ReadLine());
							Console.WriteLine($"Ответ: {answer = Math.Sqrt(operand_1)}"); break;
						}
					default: Console.WriteLine("Попробуйте еще раз. Нажмите Enter."); break;
				}
			} while (Console.ReadKey().Key != ConsoleKey.Escape);
#endif

#if TASK_6
			do
			{
				string exp;
				Console.Write("Введите выражение (без пробелов): ");
				exp = Console.ReadLine();
				DataTable table = new DataTable();
				double result = Convert.ToDouble(table.Compute(exp, " "));
				Console.WriteLine(result);
				Console.WriteLine("Для выхода нажмите ESCAPE, для продолжения нажмите ENTER.");
			} while (Console.ReadKey().Key != ConsoleKey.Escape);


#endif
		}
	}
}
