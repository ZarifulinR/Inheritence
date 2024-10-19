using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace AbstractGeometry
{
	class Circle:Shape
	{
		double PI = 3.14;
		double radius;
		public double Radius
		{
			get => radius;
			set => radius = SizeFilter(value);
		}
		public Circle
			(int radius, int startX, int startY, int lineWidth, Color color)
			:base( startX,  startY, lineWidth,  color)
		{
			Radius = radius;
		}
		public override double GetArea() => PI * Math.Pow(radius,2);
		public override double GetPerimeter()=> 2 * PI * radius;
		public override double GetSquare() => PI * Math.Pow(radius, 2);
		public override void Draw(PaintEventArgs e)
		{
			Pen pen = new Pen(Color, LineWidth);
			e.Graphics.DrawEllipse(pen, StartX,StartY, LineWidth,(int)radius);
		}

	}
}
