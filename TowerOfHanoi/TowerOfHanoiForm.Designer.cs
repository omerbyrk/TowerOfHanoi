namespace AIHanoiTowerHomework
{

	partial class AIHanoiTowerHomework
	{

		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Panel pnl_hanoi;
		private System.Windows.Forms.Button btn_solve;

		#region Windows Form Designer generated code
		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}


		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.pnl_hanoi = new System.Windows.Forms.Panel();
            this.btn_solve = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pnl_hanoi
            // 
            this.pnl_hanoi.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_hanoi.Location = new System.Drawing.Point(12, 92);
            this.pnl_hanoi.Name = "pnl_hanoi";
            this.pnl_hanoi.Size = new System.Drawing.Size(700, 300);
            this.pnl_hanoi.TabIndex = 0;
            this.pnl_hanoi.Paint += new System.Windows.Forms.PaintEventHandler(this.panelPaint);
            // 
            // btn_solve
            // 
            this.btn_solve.Location = new System.Drawing.Point(247, 54);
            this.btn_solve.Name = "btn_solve";
            this.btn_solve.Size = new System.Drawing.Size(75, 23);
            this.btn_solve.TabIndex = 1;
            this.btn_solve.Text = "Solve Middle";
            this.btn_solve.UseVisualStyleBackColor = true;
            this.btn_solve.Click += new System.EventHandler(this.btnSolveClick);
            // 
            // btn_reset
            // 
            this.btn_reset.Enabled = false;
            this.btn_reset.Location = new System.Drawing.Point(338, 54);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(75, 23);
            this.btn_reset.TabIndex = 5;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btnResetClick);
            // 
            // AIHanoiTowerHomework
            // 
            this.AcceptButton = this.btn_solve;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 429);
            this.Controls.Add(this.pnl_hanoi);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_solve);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AIHanoiTowerHomework";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AIHanoiTowerHomework - Omer Bayrak - 171180501";
            this.TransparencyKey = System.Drawing.Color.Magenta;
            this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Button btn_reset;

	}
}

