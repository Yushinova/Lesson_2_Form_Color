namespace WF_dz2
{
	partial class Form_Colors
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

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

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lb_1_title = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lb_Color = new System.Windows.Forms.Label();
            this.trackBar_B = new System.Windows.Forms.TrackBar();
            this.trackBar_G = new System.Windows.Forms.TrackBar();
            this.lb_B = new System.Windows.Forms.Label();
            this.lb_G = new System.Windows.Forms.Label();
            this.lb_R = new System.Windows.Forms.Label();
            this.trackBar_R = new System.Windows.Forms.TrackBar();
            this.tb_RGB = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_B)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_G)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_R)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lb_1_title);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer1.Size = new System.Drawing.Size(784, 461);
            this.splitContainer1.SplitterDistance = 102;
            this.splitContainer1.TabIndex = 0;
            this.splitContainer1.TabStop = false;
            // 
            // lb_1_title
            // 
            this.lb_1_title.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_1_title.AutoSize = true;
            this.lb_1_title.Font = new System.Drawing.Font("Neons", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_1_title.Location = new System.Drawing.Point(212, 31);
            this.lb_1_title.Name = "lb_1_title";
            this.lb_1_title.Size = new System.Drawing.Size(429, 42);
            this.lb_1_title.TabIndex = 0;
            this.lb_1_title.Text = "Изменение цвета формы";
            this.lb_1_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 76F));
            this.tableLayoutPanel1.Controls.Add(this.lb_Color, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.trackBar_B, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.trackBar_G, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lb_B, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lb_G, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lb_R, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.trackBar_R, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tb_RGB, 1, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(784, 355);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lb_Color
            // 
            this.lb_Color.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_Color.AutoSize = true;
            this.lb_Color.Font = new System.Drawing.Font("Elmer_P Font", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Color.Location = new System.Drawing.Point(3, 264);
            this.lb_Color.Name = "lb_Color";
            this.lb_Color.Size = new System.Drawing.Size(182, 91);
            this.lb_Color.TabIndex = 8;
            this.lb_Color.Text = "RGB value";
            this.lb_Color.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // trackBar_B
            // 
            this.trackBar_B.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBar_B.BackColor = System.Drawing.SystemColors.Control;
            this.trackBar_B.Location = new System.Drawing.Point(191, 206);
            this.trackBar_B.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
            this.trackBar_B.Maximum = 255;
            this.trackBar_B.Name = "trackBar_B";
            this.trackBar_B.Size = new System.Drawing.Size(590, 55);
            this.trackBar_B.TabIndex = 7;
            this.trackBar_B.TabStop = false;
            this.trackBar_B.TickFrequency = 10;
            this.trackBar_B.Value = 128;
            this.trackBar_B.Scroll += new System.EventHandler(this.change_color);
            // 
            // trackBar_G
            // 
            this.trackBar_G.BackColor = System.Drawing.SystemColors.Control;
            this.trackBar_G.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trackBar_G.Location = new System.Drawing.Point(191, 118);
            this.trackBar_G.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
            this.trackBar_G.Maximum = 255;
            this.trackBar_G.Name = "trackBar_G";
            this.trackBar_G.Size = new System.Drawing.Size(590, 55);
            this.trackBar_G.TabIndex = 6;
            this.trackBar_G.TabStop = false;
            this.trackBar_G.TickFrequency = 10;
            this.trackBar_G.Value = 128;
            this.trackBar_G.Scroll += new System.EventHandler(this.change_color);
            // 
            // lb_B
            // 
            this.lb_B.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_B.AutoSize = true;
            this.lb_B.Font = new System.Drawing.Font("Elmer_P Font", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_B.Location = new System.Drawing.Point(3, 176);
            this.lb_B.Name = "lb_B";
            this.lb_B.Size = new System.Drawing.Size(182, 88);
            this.lb_B.TabIndex = 4;
            this.lb_B.Text = "B";
            this.lb_B.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_G
            // 
            this.lb_G.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_G.AutoSize = true;
            this.lb_G.Font = new System.Drawing.Font("Elmer_P Font", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_G.Location = new System.Drawing.Point(3, 88);
            this.lb_G.Name = "lb_G";
            this.lb_G.Size = new System.Drawing.Size(182, 88);
            this.lb_G.TabIndex = 2;
            this.lb_G.Text = "G";
            this.lb_G.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_R
            // 
            this.lb_R.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_R.AutoSize = true;
            this.lb_R.Font = new System.Drawing.Font("Elmer_P Font", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_R.Location = new System.Drawing.Point(3, 0);
            this.lb_R.Name = "lb_R";
            this.lb_R.Size = new System.Drawing.Size(182, 88);
            this.lb_R.TabIndex = 0;
            this.lb_R.Text = "R";
            this.lb_R.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // trackBar_R
            // 
            this.trackBar_R.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBar_R.BackColor = System.Drawing.SystemColors.Control;
            this.trackBar_R.Location = new System.Drawing.Point(191, 30);
            this.trackBar_R.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
            this.trackBar_R.Maximum = 255;
            this.trackBar_R.Name = "trackBar_R";
            this.trackBar_R.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.trackBar_R.Size = new System.Drawing.Size(590, 55);
            this.trackBar_R.TabIndex = 5;
            this.trackBar_R.TabStop = false;
            this.trackBar_R.TickFrequency = 10;
            this.trackBar_R.Value = 128;
            this.trackBar_R.Scroll += new System.EventHandler(this.change_color);
            // 
            // tb_RGB
            // 
            this.tb_RGB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_RGB.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_RGB.Location = new System.Drawing.Point(191, 284);
            this.tb_RGB.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.tb_RGB.Name = "tb_RGB";
            this.tb_RGB.ReadOnly = true;
            this.tb_RGB.Size = new System.Drawing.Size(590, 44);
            this.tb_RGB.TabIndex = 9;
            this.tb_RGB.TabStop = false;
            this.tb_RGB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form_Colors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.splitContainer1);
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Name = "Form_Colors";
            this.Text = "Colors";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_B)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_G)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_R)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.Label lb_1_title;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Label lb_B;
		private System.Windows.Forms.Label lb_G;
		private System.Windows.Forms.Label lb_R;
		private System.Windows.Forms.TrackBar trackBar_B;
		private System.Windows.Forms.TrackBar trackBar_G;
		private System.Windows.Forms.TrackBar trackBar_R;
		private System.Windows.Forms.Label lb_Color;
		private System.Windows.Forms.TextBox tb_RGB;
	}
}

