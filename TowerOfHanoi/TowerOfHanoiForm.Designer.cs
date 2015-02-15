namespace TowerOfHanoi
{

	partial class TowerOfHanoi
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
			this.rdb_solve_middle = new System.Windows.Forms.RadioButton();
			this.rdb_solve_right = new System.Windows.Forms.RadioButton();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
			this.tssl_timer = new System.Windows.Forms.ToolStripStatusLabel();
			this.btn_reset = new System.Windows.Forms.Button();
			this.lbl_n_discs = new System.Windows.Forms.Label();
			this.nud_n_discs = new System.Windows.Forms.NumericUpDown();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.trb_speed = new System.Windows.Forms.TrackBar();
			this.lbl_speed = new System.Windows.Forms.Label();
			this.pnl_debug = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.statusStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nud_n_discs)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.trb_speed)).BeginInit();
			this.pnl_debug.SuspendLayout();
			this.SuspendLayout();
			// 
			// pnl_hanoi
			// 
			this.pnl_hanoi.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pnl_hanoi.Location = new System.Drawing.Point(12, 92);
			this.pnl_hanoi.Name = "pnl_hanoi";
			this.pnl_hanoi.Size = new System.Drawing.Size(700, 300);
			this.pnl_hanoi.TabIndex = 0;
			this.pnl_hanoi.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_hanoi_Paint);
			// 
			// btn_solve
			// 
			this.btn_solve.Location = new System.Drawing.Point(320, 12);
			this.btn_solve.Name = "btn_solve";
			this.btn_solve.Size = new System.Drawing.Size(75, 23);
			this.btn_solve.TabIndex = 1;
			this.btn_solve.Text = "Solve Middle";
			this.btn_solve.UseVisualStyleBackColor = true;
			this.btn_solve.Click += new System.EventHandler(this.btn_solve_Click);
			// 
			// rdb_solve_middle
			// 
			this.rdb_solve_middle.AutoSize = true;
			this.rdb_solve_middle.Checked = true;
			this.rdb_solve_middle.Dock = System.Windows.Forms.DockStyle.Top;
			this.rdb_solve_middle.Location = new System.Drawing.Point(3, 16);
			this.rdb_solve_middle.Name = "rdb_solve_middle";
			this.rdb_solve_middle.Padding = new System.Windows.Forms.Padding(3);
			this.rdb_solve_middle.Size = new System.Drawing.Size(122, 23);
			this.rdb_solve_middle.TabIndex = 0;
			this.rdb_solve_middle.TabStop = true;
			this.rdb_solve_middle.Text = "Middle";
			this.rdb_solve_middle.UseVisualStyleBackColor = true;
			// 
			// rdb_solve_right
			// 
			this.rdb_solve_right.AutoSize = true;
			this.rdb_solve_right.Dock = System.Windows.Forms.DockStyle.Top;
			this.rdb_solve_right.Location = new System.Drawing.Point(3, 39);
			this.rdb_solve_right.Name = "rdb_solve_right";
			this.rdb_solve_right.Padding = new System.Windows.Forms.Padding(3);
			this.rdb_solve_right.Size = new System.Drawing.Size(122, 23);
			this.rdb_solve_right.TabIndex = 1;
			this.rdb_solve_right.Text = "Right";
			this.rdb_solve_right.UseVisualStyleBackColor = true;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.rdb_solve_right);
			this.groupBox1.Controls.Add(this.rdb_solve_middle);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(128, 65);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Solve to";
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.tssl_timer});
			this.statusStrip1.Location = new System.Drawing.Point(0, 407);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(924, 22);
			this.statusStrip1.SizingGrip = false;
			this.statusStrip1.TabIndex = 0;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// toolStripStatusLabel1
			// 
			this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			this.toolStripStatusLabel1.Size = new System.Drawing.Size(363, 17);
			this.toolStripStatusLabel1.Text = "Opdracht 1, Tower of Hanoi, door Jeroen van Warmerdam [448872]!";
			// 
			// tssl_timer
			// 
			this.tssl_timer.Name = "tssl_timer";
			this.tssl_timer.Size = new System.Drawing.Size(546, 17);
			this.tssl_timer.Spring = true;
			this.tssl_timer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// btn_reset
			// 
			this.btn_reset.Enabled = false;
			this.btn_reset.Location = new System.Drawing.Point(320, 41);
			this.btn_reset.Name = "btn_reset";
			this.btn_reset.Size = new System.Drawing.Size(75, 23);
			this.btn_reset.TabIndex = 5;
			this.btn_reset.Text = "Reset";
			this.btn_reset.UseVisualStyleBackColor = true;
			this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
			// 
			// lbl_n_discs
			// 
			this.lbl_n_discs.AutoSize = true;
			this.lbl_n_discs.Location = new System.Drawing.Point(146, 14);
			this.lbl_n_discs.Name = "lbl_n_discs";
			this.lbl_n_discs.Size = new System.Drawing.Size(84, 13);
			this.lbl_n_discs.TabIndex = 0;
			this.lbl_n_discs.Text = "Number of rings:";
			this.lbl_n_discs.Click += new System.EventHandler(this.lbl_n_discs_Click);
			// 
			// nud_n_discs
			// 
			this.nud_n_discs.Location = new System.Drawing.Point(236, 12);
			this.nud_n_discs.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
			this.nud_n_discs.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
			this.nud_n_discs.Name = "nud_n_discs";
			this.nud_n_discs.Size = new System.Drawing.Size(67, 20);
			this.nud_n_discs.TabIndex = 3;
			this.nud_n_discs.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
			this.nud_n_discs.ValueChanged += new System.EventHandler(this.nud_n_discs_ValueChanged);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(3, 19);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.textBox1.Size = new System.Drawing.Size(195, 357);
			this.textBox1.TabIndex = 1;
			// 
			// trb_speed
			// 
			this.trb_speed.Location = new System.Drawing.Point(229, 49);
			this.trb_speed.Name = "trb_speed";
			this.trb_speed.Size = new System.Drawing.Size(83, 45);
			this.trb_speed.TabIndex = 4;
			this.trb_speed.TickStyle = System.Windows.Forms.TickStyle.None;
			this.trb_speed.Value = 5;
			// 
			// lbl_speed
			// 
			this.lbl_speed.AutoSize = true;
			this.lbl_speed.Location = new System.Drawing.Point(146, 51);
			this.lbl_speed.Name = "lbl_speed";
			this.lbl_speed.Size = new System.Drawing.Size(81, 13);
			this.lbl_speed.TabIndex = 0;
			this.lbl_speed.Text = "Resolve speed:";
			this.lbl_speed.Click += new System.EventHandler(this.lbl_speed_Click);
			// 
			// pnl_debug
			// 
			this.pnl_debug.Controls.Add(this.label1);
			this.pnl_debug.Controls.Add(this.textBox1);
			this.pnl_debug.Location = new System.Drawing.Point(718, 12);
			this.pnl_debug.Name = "pnl_debug";
			this.pnl_debug.Size = new System.Drawing.Size(201, 379);
			this.pnl_debug.TabIndex = 6;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(3, 3);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(42, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Debug:";
			// 
			// TowerOfHanoi
			// 
			this.AcceptButton = this.btn_solve;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(924, 429);
			this.Controls.Add(this.pnl_hanoi);
			this.Controls.Add(this.pnl_debug);
			this.Controls.Add(this.lbl_speed);
			this.Controls.Add(this.trb_speed);
			this.Controls.Add(this.nud_n_discs);
			this.Controls.Add(this.lbl_n_discs);
			this.Controls.Add(this.btn_reset);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.btn_solve);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "TowerOfHanoi";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Tower of Hanoi";
			this.TransparencyKey = System.Drawing.Color.Magenta;
			this.Shown += new System.EventHandler(this.TowerOfHanoi_Shown);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.nud_n_discs)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.trb_speed)).EndInit();
			this.pnl_debug.ResumeLayout(false);
			this.pnl_debug.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.RadioButton rdb_solve_middle;
		private System.Windows.Forms.RadioButton rdb_solve_right;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
		private System.Windows.Forms.Button btn_reset;
		private System.Windows.Forms.Label lbl_n_discs;
		private System.Windows.Forms.NumericUpDown nud_n_discs;
		private System.Windows.Forms.ToolStripStatusLabel tssl_timer;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TrackBar trb_speed;
		private System.Windows.Forms.Label lbl_speed;
		private System.Windows.Forms.Panel pnl_debug;
		private System.Windows.Forms.Label label1;

	}
}

