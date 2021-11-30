using System;
using System.Drawing;
using System.Windows.Forms;

namespace AIHanoiTowerHomework
{

	public class Tile
	{

		#region fields and properties
		private Panel panel;
		private Color color;
		private Int32 width;
		public Int32 Width
		{
			get
			{
				return width;
			}
			set
			{
				width = value;
			}
		}
		private Int32 height;
		public Int32 Height
		{
			get
			{
				return height;
			}
			set
			{
				height = value;
			}
		}
		private Int32 x = 0;
		public Int32 X
		{
			set
			{
				x = value;
			}
		}
		private Int32 y = 0;
		public Int32 Y
		{
			set
			{
				y = value;
			}
		}
		#endregion fields and properties

		public Tile(Panel _panel, Color _color, Int32 _width, Int32 _height)
		{
			panel = _panel;
			color = _color;
			width = _width;
			height = _height;
		}

		public void Draw()
		{
			Graphics g = Graphics.FromHwnd(panel.Handle);
			SolidBrush b = new SolidBrush(color);
			g.FillRectangle(b, x - width, y - height, width * 2, height);
		}

	}
}
