//#define FACTORIAL_1
#define FACTORIAL_2

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Factorial
{
	internal class Program
	{
		static void Main(string[] args)
		{
#if FACTORIAL_1
			Console.Write("Введите число: ");
			int n = Convert.ToInt32(Console.ReadLine());
			long f = 1;
			int i = 1;
			try
			{
				for (; i <= n; i++)
				{
					f *= i;
					Console.WriteLine($"{i}! = {f}");
				}
				Console.WriteLine($"Конечный результат: {--i}! = {f}");
			}
			catch (Exception ex)
			{

				Console.WriteLine(ex.Message);
				i--;
				Console.WriteLine($"Последний правильный результат: {i}! = {f}");
			}
#endif

#if FACTORIAL_2//Скопипастить код с гита
			Console.Write("Введите число: ");
			int n = Convert.ToInt32(Console.ReadLine());
			biginteger f = 1;
			int i = 1;
			try
			{
				for (; i <= n; i++)
				{
					f *= i;
					Console.WriteLine($"{i}! = {f}");
				}
				Console.WriteLine($"Конечный результат: {--i}! = {f}");
			}
			catch (Exception ex)
			{

				Console.WriteLine(ex.Message);
				i--;
				Console.WriteLine($"Последний правильный результат: {i}! = {f}");
			}
#endif
		}
	}
}
