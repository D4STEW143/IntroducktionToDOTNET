using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
	internal class Point
	{
		double x;
		double y;
		//Properties
		public double X
		{
			get => x; 
			set 
			{
				x = value;  //Ключевое слово value возвращает значение, которое приходит из вне.
			}
		}
		public double Y
		{
			get => y;
			set { y = value; }
		}
		//Get-Set
		public double GetX()
		{
			return x;
		}
		public double GetY()
		{
			return y;
		}
		public void SetX(double x)
		{
			this.x = x;
		}
		public void SetY(double y)
		{
			this.y = y;
		}

		//Можно использовать автосвойство.
		//public double X { get; set; }
		//public double Y { get; set; }

		public Point (double x = 0, double y = 0)
		{
			X = x;
			Y = y;
            Console.WriteLine($"Constructor: \t {this.GetHashCode()}");
        }
		~Point()
		{
			Console.WriteLine($"Destructor: \t {this.GetHashCode()}");
		}

	}
}
