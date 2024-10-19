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
		public override double GetArea() => Math.PI * Math.Pow(radius,2);
		public override double GetPerimeter()=> 2 * Math.PI * radius;
		public override double GetSquare() => Math.PI * Math.Pow(radius, 2);
		public override void Draw(PaintEventArgs e)
		{
			Pen pen = new Pen(Color, LineWidth);
			e.Graphics.DrawEllipse(pen, StartX,StartY, (int)radius, (int)radius);
		}

	}
}
