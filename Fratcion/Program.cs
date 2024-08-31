//#define CONSTR_CHECK
#define ARTHMETICAL_OPERATORS
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fraction
{
	internal class Program
	{
		static void Main(string[] args)
		{
#if CONSTR_CHECK
			Fraction A = new Fraction();
			A.Print();
			Fraction B = new Fraction(5);
			B.Print();
			Fraction C = new Fraction(1, 2);
			C.Print();
			Fraction D = new Fraction(2, 3, 4);
			D.Print();
#endif
#if ARTHMETICAL_OPERATORS
			Fraction A = new Fraction(2, 3, 4);
			Fraction B = new Fraction(3, 4, 5);
			Fraction C = new Fraction(A * B);
			Fraction D = new Fraction(A + B);
			Fraction E = new Fraction(A - B);
			A.Print();
			B.Print();
			C.Print();
			D.Print();
			E.Print();
			(A / B).Print();
            Console.WriteLine(A < B);
            Console.WriteLine(A > B);
            Console.WriteLine(A >= B);
            Console.WriteLine(A <= B);
            Console.WriteLine(A.ToDec());
            Console.WriteLine(B.ToDec());
#endif
			//Console.WriteLine(new Fraction(1, 2) == new Fraction(5, 11));

		}
	}
}
