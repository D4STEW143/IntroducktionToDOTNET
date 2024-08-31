using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fraction
{
	internal class Fraction
	{
		public int Integer { get; set; }
		public int Numerator { get; set; }
		int denominator;
		public int Denominator
		{
			get => denominator;
			set
			{
				if (value == 0) value = 1;
				denominator = value;
			}
		}
		public Fraction()
		{
			denominator = 1;
			//Console.WriteLine($"Def constr \t{this.GetHashCode()}");
		}
		public Fraction(int integer)
		{
			Integer = integer;
			Denominator = 1;
			//Console.WriteLine($"SA Constr \t{this.GetHashCode()}");
		}
		public Fraction(int numerator, int denominator)
		{
			Numerator = numerator;
			Denominator = denominator;
			//Console.WriteLine($"DA Constr \t{this.GetHashCode()}");
		}
		public Fraction(int integer, int numerator, int denominator)
		{
			Integer = integer;
			Numerator = numerator;
			Denominator = denominator;
			//Console.WriteLine($"TA Constr \t{this.GetHashCode()}");
		}

		public Fraction(Fraction other)
		{
			this.Integer = other.Integer;
			this.Numerator = other.Numerator;
			this.Denominator = other.Denominator;
			//Console.WriteLine($"Copy Constr \t{this.GetHashCode()}");
		}
		public Fraction(double number)
		{
			Integer = (int)Math.Truncate(number);
			int tmp_n = (int)((number-Math.Truncate(number))*100);
			int tmp_d = 100;
			int tmp_gcf = GCD(tmp_n, tmp_d);
			Numerator = tmp_n/tmp_gcf;
			Denominator = tmp_d/tmp_gcf;
		}
		~Fraction()
		{ //Console.WriteLine($"Def destr \t{this.GetHashCode()}");
		}

		//ArithmeticalOperators
		public static Fraction operator *(Fraction left, Fraction right)
		{
			/*Fraction left_copy = new Fraction(left);
			Fraction right_copy = new Fraction(right);
			left_copy.ToImproper();
			right_copy.ToImproper();*/
			//Fraction left_copy = left.ToImproper();
			//Fraction right_copy = right.ToImproper();
			//Fraction result = new Fraction
			//	(
			//	left_copy.Numerator * right_copy.Numerator,
			//	left_copy.Denominator * right_copy.Denominator
			//	);
			//return result.ToProper();
			//return new Fraction
			//	(
			//	left_copy.Numerator * right_copy.Numerator,
			//	left_copy.Denominator * right_copy.Denominator
			//	);
			return new Fraction
				(
					left.ToImproper().Numerator * right.ToImproper().Numerator,
					left.ToImproper().Denominator * right.ToImproper().Denominator
				);
		}
		public static Fraction operator /(Fraction left, Fraction right)
		{
			return left * right.Inverted();
		}
		public static Fraction operator +(Fraction left, Fraction right)
		{
			bool isEqual = left.Denominator.Equals(right.Denominator);
			switch (isEqual)
			{
				case true:
					return new Fraction(left.ToImproper().Numerator +
				right.ToImproper().Numerator, left.ToImproper().Denominator).ToProper();
				case false:
					int lcm = LCM(left.ToImproper().Denominator,
					right.ToImproper().Denominator);
					return new Fraction((left.ToImproper().Numerator * (lcm /
					left.ToImproper().Denominator)) + (right.ToImproper().Numerator * (lcm /
					right.ToImproper().Denominator)), lcm).ToProper();
				default: return new Fraction(0, 0);
			}
		}
		public static Fraction operator -(Fraction left, Fraction right)
		{
			bool isEqual = left.Denominator.Equals(right.Denominator);
			switch (isEqual)
			{
				case true:
					return new Fraction(left.ToImproper().Numerator -
				right.ToImproper().Numerator, left.ToImproper().Denominator).ToProper();
				case false:
					int lcm = LCM(left.ToImproper().Denominator,
					right.ToImproper().Denominator);
					return new Fraction((left.ToImproper().Numerator * (lcm /
					left.ToImproper().Denominator)) - (right.ToImproper().Numerator * (lcm /
					right.ToImproper().Denominator)), lcm).ToProper().Absolut();
				default: return new Fraction(0, 0);
			}
		}
		public static Fraction operator ++(Fraction left)
		{
			return new Fraction(left.ToImproper().Numerator + 1,
			left.Denominator).ToProper();
		}
		public static Fraction operator --(Fraction left)
		{
			return new Fraction(left.ToImproper().Numerator - 1,
			left.Denominator).ToProper();
		}
		//ComparisonOperatros
		public static bool operator ==(Fraction left, Fraction right)
		{
			return left.ToImproper().Numerator * right.ToImproper().Denominator == right.ToImproper().Numerator * left.ToImproper().Denominator;
		}
		public static bool operator !=(Fraction left, Fraction right)
		{
			return !(left == right);
		}
		public static bool operator <(Fraction left, Fraction right)
		{
			return left.ToImproper().Numerator * right.ToImproper().Denominator < right.ToImproper().Numerator * left.ToImproper().Denominator;
		}
		public static bool operator >(Fraction left, Fraction right)
		{
			return left.ToImproper().Numerator * right.ToImproper().Denominator > right.ToImproper().Numerator * left.ToImproper().Denominator;
		}
		public static bool operator <=(Fraction left, Fraction right)
		{
			return left.ToImproper().Numerator * right.ToImproper().Denominator <= right.ToImproper().Numerator * left.ToImproper().Denominator;
		}
		public static bool operator >=(Fraction left, Fraction right)
		{
			return left.ToImproper().Numerator * right.ToImproper().Denominator >= right.ToImproper().Numerator * left.ToImproper().Denominator;
		}


		//Methods
		public Fraction ToProper()
		{
			//Integer += Numerator / Denominator;
			//Numerator %= Denominator;
			//return this;
			Fraction proper = new Fraction();
			proper.Integer += Numerator / Denominator;
			proper.Numerator = Numerator % Denominator;
			proper.Denominator = Denominator;
			return proper;
		}
		public Fraction ToImproper()
		{
			//Numerator+=Integer*Denominator;
			//Integer = 0;
			//return this;
			return new Fraction(Numerator + Integer * Denominator, Denominator);

		}
		public Fraction Inverted()
		{
			//Fraction inverted = new Fraction(this);
			//inverted.ToImproper();
			Fraction inverted = ToImproper();
			(inverted.Numerator, inverted.Denominator) = (inverted.Denominator, inverted.Numerator);
			return inverted;
		}

		public Fraction Absolut()//Костыль, чтобы убрать знаки в числителе и знаменателе
		{
			return new Fraction(Integer, Math.Abs(Numerator), Math.Abs(Denominator));
		}

		public double ToDec()
		{
			return this.Integer + ((double)this.Numerator / (double)this.Denominator);
		}
		static int GCD(int a, int b)
		{
			while (b != 0)
			{
				int temp = b;
				b = a % b;
				a = temp;
			}
			return a;
		}
		static int LCM(int a, int b)
		{
			return (a / GCD(a, b)) * b;
		}
		public void Print()
		{
			if (Integer != 0) Console.Write(Integer);
			if (Numerator != 0)
			{
				if (Integer != 0) Console.Write("(");
				Console.Write($"{Numerator}/{Denominator}");
				if (Integer != 0) Console.Write(")");
			}
			else if (Integer == 0) Console.Write(0);
			Console.WriteLine();
		}
	}
}
