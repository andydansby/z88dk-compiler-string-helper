namespace z88dk_compile_options_helper_beta
{
	partial class zorg
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(zorg));
			this.panel1 = new System.Windows.Forms.Panel();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.trackBar1 = new System.Windows.Forms.TrackBar();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.option_ZORG = new System.Windows.Forms.CheckBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.panel1.Controls.Add(this.textBox3);
			this.panel1.Controls.Add(this.trackBar1);
			this.panel1.Controls.Add(this.textBox2);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.option_ZORG);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.button1);
			this.panel1.Location = new System.Drawing.Point(12, 12);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(412, 150);
			this.panel1.TabIndex = 125;
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(14, 126);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(100, 20);
			this.textBox3.TabIndex = 147;
			this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
			// 
			// trackBar1
			// 
			this.trackBar1.Location = new System.Drawing.Point(14, 40);
			this.trackBar1.Maximum = 65535;
			this.trackBar1.Name = "trackBar1";
			this.trackBar1.Size = new System.Drawing.Size(347, 45);
			this.trackBar1.TabIndex = 146;
			this.trackBar1.TickFrequency = 1024;
			this.trackBar1.Value = 1;
			this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
			// 
			// textBox2
			// 
			this.textBox2.Enabled = false;
			this.textBox2.Location = new System.Drawing.Point(297, 126);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(100, 20);
			this.textBox2.TabIndex = 143;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(165, 88);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(37, 13);
			this.label5.TabIndex = 145;
			this.label5.Text = "32768";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(324, 88);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(37, 13);
			this.label4.TabIndex = 144;
			this.label4.Text = "65535";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(11, 88);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(13, 13);
			this.label1.TabIndex = 143;
			this.label1.Text = "0";
			// 
			// option_ZORG
			// 
			this.option_ZORG.AutoSize = true;
			this.option_ZORG.Location = new System.Drawing.Point(14, 22);
			this.option_ZORG.Name = "option_ZORG";
			this.option_ZORG.Size = new System.Drawing.Size(57, 17);
			this.option_ZORG.TabIndex = 140;
			this.option_ZORG.Text = "ZORG";
			this.option_ZORG.UseVisualStyleBackColor = true;
			this.option_ZORG.CheckedChanged += new System.EventHandler(this.option_ZORG_CheckedChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(156, 5);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(46, 13);
			this.label2.TabIndex = 138;
			this.label2.Text = "Optional";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(11, 3);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(50, 16);
			this.label3.TabIndex = 131;
			this.label3.Text = "ZORG";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(352, 5);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(24, 23);
			this.button1.TabIndex = 123;
			this.button1.Text = "?";
			this.toolTip1.SetToolTip(this.button1, resources.GetString("button1.ToolTip"));
			this.button1.UseVisualStyleBackColor = true;
			// 
			// richTextBox1
			// 
			this.richTextBox1.Location = new System.Drawing.Point(12, 198);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(406, 206);
			this.richTextBox1.TabIndex = 126;
			this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(12, 430);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(412, 40);
			this.textBox1.TabIndex = 127;
			// 
			// zorg
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(497, 494);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.richTextBox1);
			this.Controls.Add(this.panel1);
			this.Name = "zorg";
			this.Text = "zorg";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.CheckBox option_ZORG;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TrackBar trackBar1;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.ToolTip toolTip1;
	}
}