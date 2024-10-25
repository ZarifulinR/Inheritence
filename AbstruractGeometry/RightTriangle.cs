using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace AbstractGeometry
{
	internal class RightTriangle : IsoscalesTriangle
	{
		 public RightTriangle(double legA, double legB, int startX, int startY, int linewidth, Color color)
		   : base(legA, legB, startX, startY, linewidth, color) { }


		public override double GetHwight() => Math.Min(TriangleBase, TriangleSide);
		public override double GetArea() => (TriangleBase * TriangleSide) / 2;
		public override double GetPerimeter() => TriangleBase + TriangleSide + Math.Sqrt(Math.Pow(TriangleBase, 2) + Math.Pow(TriangleSide, 2));

		public override void Draw(PaintEventArgs e)
		{
			Pen pen = new Pen(Color, LineWidth);
			Point[] points = new Point[]
			{
				new Point(StartX,StartY),
				new Point(StartX + (int)TriangleBase,StartY),
				new Point(StartX,StartY-(int)TriangleSide)
			};
			e.Graphics.DrawPolygon(pen, points);
		}




	}
}
