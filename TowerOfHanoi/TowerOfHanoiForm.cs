using System;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;

namespace AIHanoiTowerHomework
{

	public partial class AIHanoiTowerHomework : Form
	{

		#region fields and properties
		private Stick stick1, stick2, stick3;
		private int nRings = 3;
		private Color[] colors = { 
			Color.Lime,
			Color.Navy,
			Color.Orange
		};
		private Color stiackColor = Color.Gray;
		private int stickWidth = 200;
		private int stickHeight;
		private Thread thread = null;
		private DateTime timer;
		#endregion fields and properties

		public AIHanoiTowerHomework()
		{
			InitializeComponent();
			Control.CheckForIllegalCrossThreadCalls = false;

			stickHeight = pnl_hanoi.Height - 20;
			stickWidth = pnl_hanoi.Width / 3;

			prepareScreen();
		}


		private void makeMovement(Stick from, Stick to, Stick temp, int n)
		{
			Thread.Sleep(250);

			if (n == 1)
			{
				to.AddTile(from.RemoveRing());
				this.Refresh();

				if (from.isEmpty() && temp.isEmpty())
				{
					return;
				}
			}
			else
			{
				makeMovement(from, temp, to, n - 1);
				makeMovement(from, to, temp, 1);
				makeMovement(temp, to, from, n - 1);
			}
		}


		private void btnSolveClick(object sender, System.EventArgs e)
		{
			timer = DateTime.Now;

			if (thread != null && thread.IsAlive)
			{
				thread.Abort();
			}


		    thread = new Thread(new System.Threading.ThreadStart(() => makeMovement(stick1, stick2, stick3, nRings)));


			thread.Start();

			btn_solve.Enabled = false;
			btn_reset.Enabled = true;
		}

		private void btnResetClick(object sender, System.EventArgs e)
		{

			prepareScreen();

			btn_solve.Enabled = true;
			btn_reset.Enabled = false;
		}

		private void panelPaint(object sender, PaintEventArgs e)
		{
			stick1.Draw();
			stick2.Draw();
			stick3.Draw();
		}

		private void prepareScreen()
		{
			stick1 = new Stick(pnl_hanoi, stiackColor, 20 + 0, stickHeight, stickWidth - 60, stickHeight - 60);
			stick2 = new Stick(pnl_hanoi, stiackColor, 20 + stickWidth, stickHeight, stickWidth - 60, stickHeight - 60);
			stick3 = new Stick(pnl_hanoi, stiackColor, 20 + stickWidth * 2, stickHeight, stickWidth - 60, stickHeight - 60);

			stick1.RemoveRings();
			stick2.RemoveRings();
			stick3.RemoveRings();

			for (int r = 0; r < nRings; r++)
			{
				stick1.AddTile(
					new Tile(
						pnl_hanoi,
						colors[r],
						(nRings - r) * (stickWidth - 60) / (2 * nRings),
						(stickHeight / nRings - 60)
					)
				);
			}
			this.Refresh();
		}
	}
}
