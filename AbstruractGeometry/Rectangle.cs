using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace AbstractGeometry
{

	class Rectangle:Shape
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
			double width, double heigth,int startX, 
			int startY, int lineWidth, Color color
			):base(startX,startY,lineWidth,color)
		{
			Width = width;
			Heigth = heigth;
		}
		public override double GetArea() => Width * Heigth;

		public override double GetPerimeter() => 2 * (Width + Heigth);

		public override void Draw(PaintEventArgs e)
		{
			Pen pen = new Pen(Color, LineWidth);
			e.Graphics.DrawRectangle(pen, StartX, StartY, (int)Width, (int)Heigth);
		}

	}
}

