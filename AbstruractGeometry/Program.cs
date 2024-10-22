using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Runtime.InteropServices;

namespace AbstractGeometry
{
	class Program
	{
		static void Main(string[] args)
		{
			IntPtr hwnd = GetConsoleWindow();
			Graphics graphics = Graphics.FromHwnd(hwnd);
			System.Drawing.Rectangle window_rect = new System.Drawing.Rectangle
				(
				Console.WindowLeft, Console.WindowTop,
				Console.WindowWidth, Console.WindowHeight
				);
			PaintEventArgs e = new PaintEventArgs(graphics, window_rect);
			
			Rectangle rectangle = new Rectangle(100, 50, 450, 100, 3, System.Drawing.Color.Red);
			rectangle.Info(e);
			Circle circle = new Circle(30, 570, 95, 3, System.Drawing.Color.Gold);
			Square square = new Square(75, 750, 95, 1, System.Drawing.Color.Aqua);
			square.Info(e);
			circle.Info(e);
			IsoscalesTriangle i_triangle = new IsoscalesTriangle(80, 80, 650, 85, 3, Color.Green);
			i_triangle.Info(e);
			EquilLateralTriangle e_triangle = new EquilLateralTriangle(100, 450, 160, 3, Color.GreenYellow);
			e_triangle.Info(e);
		}
		[DllImport("kernel32.dll")]
		public static extern IntPtr GetConsoleWindow();
		[DllImport("kernel32.dll")]
		public static extern IntPtr GetDC(IntPtr hwnd); 
	}
}
