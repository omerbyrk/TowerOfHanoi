using System;
using System.Collections;
using System.Drawing;
using System.Windows.Forms;

namespace TowerOfHanoi
{

	public class Pile
	{

		#region fields and properties
		private Stack rings;
		private Panel panel;
		private Color color;
		private Int32 x, y;
		private Int32 width, height;
		private Int32 pileWidth = 20;
		private Int32 pileHeight = 20;
		#endregion fields and properties

		public Pile(Panel _panel, Color _color, Int32 _x, Int32 _y, Int32 _width, Int32 _height)
		{
			rings = new Stack();
			panel = _panel;
			color = _color;
			x = _x;
			y = _y;
			width = _width;
			height = _height;
		}

		public void AddRing(Ring r)
		{
			r.X = x + (width / 2);
			r.Y = y - (rings.Count * r.Height);
			rings.Push(r);
		}

		public Ring RemoveRing()
		{
			return (Ring)rings.Pop();
		}

		public void RemoveRings()
		{
			rings.Clear();
		}

		public void Draw()
		{
			Graphics g = Graphics.FromHwnd(panel.Handle);
			SolidBrush b = new SolidBrush(color);
			g.FillRectangle(b, x, y, width, pileHeight);
			g.FillRectangle(b, x + (width / 2) - (pileWidth / 2), y - height, pileWidth, height);

			try  // error: "Collection was modified; enumeration operation may not execute."
			{
				foreach (Ring r in rings)
				{
					r.Draw();
				}
			}
			catch (Exception) { }
		}

		public Boolean isEmpty()
		{
			return rings.Count <= 0;
		}
	}
}
