using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	internal class Program
	{
		class tamGiac
	{
		double a, b, c;
		public double A
        {
			get { return a; }
			set { a = value; }
        }
		public double B
        {
			get { return b; }
			set { b = value; }
        }
		public double C
        {
			get { return c; }
			set { c = value; }
        }
		

		
	}
	class hinhThang
	{

		double a, b, h;
		public double A
		{
			get { return a; }
			set { a = value; }
		}
		public double B
		{
			get { return b; }
			set { b = value; }
		}
		public double H
		{
			get { return h; }
			set { h = value; }
		}

		void Nhap()
		{
			Console.WriteLine("Nhap a = ");
			a = System.Double.Parse(Console.ReadLine());

			Console.WriteLine("Nhap b = ");
			b = System.Double.Parse(Console.ReadLine());

			Console.WriteLine("Nhap h = ");
			h = System.Double.Parse(Console.ReadLine());
		}

		double dientich()
		{
			double S2 = (((a + b) / 2) * h);
			return S2;
		}
	}
	class hinhThoi
	{
		double a, h;
		public double A
		{
			get { return a; }
			set { a = value; }
		}
		
		public double H
		{
			get { return h; }
			set { h = value; }
		}

		void Nhap()
		{
			Console.WriteLine("Nhap a = ");
			a = System.Double.Parse(Console.ReadLine());

			Console.WriteLine("Nhap h = ");
			h = System.Double.Parse(Console.ReadLine());
		}
		double dientich()
		{
			double S3 = a * h;
			return S3;
		}

	}
	
		static void Main(string[] args) {
			tamGiac tg = new tamGiac() ;
			Console.WriteLine("Nhap a = ");
			tg.A = System.Double.Parse(Console.ReadLine());

			Console.WriteLine("Nhap b = ");
			tg.B = System.Double.Parse(Console.ReadLine());

			Console.WriteLine("Nhap c = ");
			tg.C = System.Double.Parse(Console.ReadLine());

			double p = (tg.A + tg.B + tg.C) / 2;
			double S1 = Math.Sqrt(p * (p - tg.A) * (p - tg.B) * (p - tg.C));


		}
	}
		

			


		
	
    
}
