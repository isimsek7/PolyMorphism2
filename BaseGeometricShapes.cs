using System;
namespace PolyMorph
{
	public class BaseGeometricShapes
	{
		public BaseGeometricShapes()
		{
		}
		public int _width { get; set; }
		public int _length { get; set; }

		public virtual void CalcArea()
		{
			Console.WriteLine("Area is " + _width * _length + " centimeters.");
		}
	}
	public class Square : BaseGeometricShapes
	{

		public Square(int w)
		{
			_width = w;
			_length = w;
		}



	}
	public class Rectangle : BaseGeometricShapes
	{

		public Rectangle(int w, int l)
		{
			_width = w;
			_length = l;
		}
	}
	public class RightTriangle : BaseGeometricShapes
	{

		public RightTriangle(int w, int l)
		{
			_width = w;
			_length = l;
		}
		public override void CalcArea()
		{
			Console.WriteLine("Area is " + (_width * _length) / 2 + " centimeters.");
		}
	}
}









