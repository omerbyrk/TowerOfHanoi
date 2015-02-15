using System;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;

namespace TowerOfHanoi
{

	public partial class TowerOfHanoi : Form
	{

		#region fields and properties
		private Pile pile1, pile2, pile3;
		private Int32 nRings = 6;
		private Color[] colors = { 
			Color.Red, 
			Color.Yellow, 
			Color.Black, 
			Color.Blue, 
			Color.Green, 
			Color.Purple,
			Color.Lime,
			Color.Navy,
			Color.Orange
		};
		private Color pileColor = Color.Gray;
		private Int32 pileWidth = 200;
		private Int32 pileHeight;
		private Thread thread = null;
		private DateTime timer;
		#endregion fields and properties

		public TowerOfHanoi()
		{
			InitializeComponent();
			Control.CheckForIllegalCrossThreadCalls = false;
			hideDebugger();  // debugger code;

			pileHeight = pnl_hanoi.Height - 20;
			pileWidth = pnl_hanoi.Width / 3;
			nRings = (Int32)nud_n_discs.Value;

			draw();
		}

		private void draw()
		{
			pile1 = new Pile(pnl_hanoi, pileColor, 20 + 0, pileHeight, pileWidth - 40, pileHeight);
			pile2 = new Pile(pnl_hanoi, pileColor, 20 + pileWidth, pileHeight, pileWidth - 40, pileHeight);
			pile3 = new Pile(pnl_hanoi, pileColor, 20 + pileWidth * 2, pileHeight, pileWidth - 40, pileHeight);

			pile1.RemoveRings();
			pile2.RemoveRings();
			pile3.RemoveRings();

			for (Int32 r = 0; r < nRings; r++)
			{
				pile1.AddRing(
					new Ring(
						pnl_hanoi,
						colors[r],
						(nRings - r) * (pileWidth - 40) / (2 * nRings),
						pileHeight / nRings
					)
				);
			}
			this.Refresh();
		}

		private void doMoves(Pile from, Pile to, Pile temp, Int32 n)
		{
			Thread.Sleep(trb_speed.Value * trb_speed.Value * 2);

			textBox1.Text += String.Format("n:{0} ", n);
			textBox1.SelectionStart = textBox1.Text.Length;
			textBox1.ScrollToCaret();

			if (n == 1)
			{
				to.AddRing(from.RemoveRing());
				this.Refresh();

				if (from.isEmpty() && temp.isEmpty())
				{
					textBox1.Text += "DONE";
					textBox1.SelectionStart = textBox1.Text.Length;
					textBox1.ScrollToCaret();

					tssl_timer.Text = String.Format("~{0}ms", Math.Round((DateTime.Now - timer).TotalMilliseconds).ToString());
					return;
				}
			}
			else
			{
				doMoves(from, temp, to, n - 1);
				doMoves(from, to, temp, 1);
				doMoves(temp, to, from, n - 1);
			}
		}

		private void solveMiddle()
		{
			doMoves(pile1, pile2, pile3, nRings);
		}
		private void solveRight()
		{
			doMoves(pile1, pile3, pile2, nRings);
		}

		private void btn_solve_Click(object sender, System.EventArgs e)
		{
			timer = DateTime.Now;

			if (thread != null && thread.IsAlive)
			{
				thread.Abort();
			}

			if (rdb_solve_middle.Checked)
			{
				thread = new Thread(new System.Threading.ThreadStart(solveMiddle));
			}
			else if (rdb_solve_right.Checked)
			{
				thread = new Thread(new System.Threading.ThreadStart(solveRight));
			}

			thread.Start();

			btn_solve.Enabled = false;
			btn_reset.Enabled = true;
		}

		private void btn_reset_Click(object sender, System.EventArgs e)
		{
			tssl_timer.Text = String.Empty;

			draw();

			btn_solve.Enabled = true;
			btn_reset.Enabled = false;
		}

		private void pnl_hanoi_Paint(object sender, PaintEventArgs e)
		{
			pile1.Draw();
			pile2.Draw();
			pile3.Draw();
		}

		private void nud_n_discs_ValueChanged(object sender, EventArgs e)
		{
			nRings = (Int32)nud_n_discs.Value;

			this.btn_reset_Click(sender, e);
		}

		private void lbl_n_discs_Click(object sender, EventArgs e)
		{
			nud_n_discs.Focus();
		}

		private void lbl_speed_Click(object sender, EventArgs e)
		{
			trb_speed.Focus();
		}

		private void TowerOfHanoi_Shown(object sender, EventArgs e)
		{
			if (Program.isDebug)
			{
				openDebugger();
			}
		}


		#region Debugger;
		private Int32 debuggerSize = 200;
		private void hideDebugger()
		{
			debuggerSize = this.pnl_debug.Width;
			this.Width -= debuggerSize;
			pnl_debug.Hide();
		}
		private void openDebugger()
		{
			Int32 endSize = this.Width + debuggerSize;
			Double steps = debuggerSize / 30;
			while (this.Width <= endSize)
			{
				this.Width += (Int32)steps;
				this.Left -= (Int32)(steps / 2);
				Application.DoEvents();  // needed to not stall the program;
			}
			pnl_debug.Show();
		}
		#endregion Debugger;
	}
}
