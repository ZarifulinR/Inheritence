using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace AbstractGeometry
{
	class Circle:Shape,IHaveDiameter
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
		public double GetDiameter() => 2 * radius;
		public override double GetArea() => Math.PI * Math.Pow(radius,2);
		public override double GetPerimeter()=> 2 * Math.PI * radius;
		public override double GetSquare() => GetArea();
		
		public void DrawDiameter(PaintEventArgs e)
		{
			int dx = (int)(radius * (1 - 1 / Math.Sqrt(2)));
			
			Pen pen = new Pen(Color, LineWidth);
			e.Graphics.DrawLine(pen, StartX+dx, StartY+dx,StartX+(int)GetDiameter()-dx,StartY+(int)GetDiameter()-dx );
			
		}

		

		public override void Draw(PaintEventArgs e)
			
		{
			Pen pen = new Pen(Color, LineWidth);
			e.Graphics.DrawEllipse(pen, StartX,StartY, (int)GetDiameter(), (int)GetDiameter());
			DrawDiameter(e);
		}

	}
}
