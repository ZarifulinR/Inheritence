using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace AbstractGeometry
{
	abstract class Triangle: Shape
	{
		public abstract double GetHwight();
		public Triangle(int startX, int startY, int lineWidth, Color color) : base(startX, startY, lineWidth, color) { }
		public override void Info(PaintEventArgs e)
		{
			Console.WriteLine($"Высота треугольника:{GetHwight()} ");
			base.Info(e);
		}
	}
}
