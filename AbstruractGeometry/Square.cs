﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace AbstractGeometry
{
	class Square:Rectangle,IHaveDiagonal
	{
		
		public Square
			(double side,  int startX,
			int startY, int lineWidth, Color color) : base(side, side, startX, startY, lineWidth, color) { }
		
	}
}
