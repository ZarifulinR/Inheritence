using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace AbstractGeometry
{

	class Rectangle : Shape, IHaveDiagonal
	{
		double width;
		double heigth;
		public double Width
		{
			get => width;
			set => width = SizeFilter(value);
		}
		public double Heigth
		{
			get => heigth;
			set => heigth = SizeFilter(value);
		}
		public Rectangle
			(
			double width, double heigth, int startX,
			int startY, int lineWidth, Color color
			) : base(startX, startY, lineWidth, color)
		{
			Width = width;
			Heigth = heigth;
		}
		public double GetDiagonal()
		{
			return Math.Sqrt(Width * Width + Heigth * Heigth);
		}

		public override double GetArea() => Width * Heigth;

		public override double GetPerimeter() => 2 * (Width + Heigth);
		public override double GetSquare() => (Width * Heigth);
		public void DrawDiagonal(PaintEventArgs e)
		{
			Pen pen = new Pen(Color, LineWidth);
			e.Graphics.DrawLine(pen, StartX, StartY, StartX + (int)width, StartY + (int)heigth);
		}
		public override void Draw(PaintEventArgs e)
		{
			Pen pen = new Pen(Color, LineWidth);
			e.Graphics.DrawRectangle(pen, StartX, StartY, (int)Width, (int)Heigth);
			DrawDiagonal(e);
		}
		public override void Info(PaintEventArgs e)
		{
			Console.WriteLine(this.GetType());
			Console.WriteLine($"Ширина прямоугольника: {Width}");
			Console.WriteLine($"Высода прямоугольника: {Heigth}");
			base.Info(e);
		}
	}
}

