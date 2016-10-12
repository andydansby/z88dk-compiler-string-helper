namespace z88dk_compile_options_helper_beta
{
	partial class output_file
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
			this.panel6 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.outputFileTextbox = new System.Windows.Forms.TextBox();
			this.button2 = new System.Windows.Forms.Button();
			this.remove_file = new System.Windows.Forms.Button();
			this.create_app = new System.Windows.Forms.CheckBox();
			this.add_file = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.panel6.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel6
			// 
			this.panel6.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.panel6.Controls.Add(this.label1);
			this.panel6.Controls.Add(this.button1);
			this.panel6.Controls.Add(this.outputFileTextbox);
			this.panel6.Controls.Add(this.button2);
			this.panel6.Controls.Add(this.remove_file);
			this.panel6.Controls.Add(this.create_app);
			this.panel6.Controls.Add(this.add_file);
			this.panel6.Location = new System.Drawing.Point(12, 12);
			this.panel6.Name = "panel6";
			this.panel6.Size = new System.Drawing.Size(430, 84);
			this.panel6.TabIndex = 142;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(20, 28);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(89, 13);
			this.label1.TabIndex = 134;
			this.label1.Text = "Output File Name";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(119, 23);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(21, 23);
			this.button1.TabIndex = 123;
			this.button1.Text = "?";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// outputFileTextbox
			// 
			this.outputFileTextbox.Location = new System.Drawing.Point(4, 50);
			this.outputFileTextbox.Name = "outputFileTextbox";
			this.outputFileTextbox.Size = new System.Drawing.Size(282, 20);
			this.outputFileTextbox.TabIndex = 126;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(119, 0);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(21, 23);
			this.button2.TabIndex = 123;
			this.button2.Text = "?";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// remove_file
			// 
			this.remove_file.Enabled = false;
			this.remove_file.Location = new System.Drawing.Point(363, 47);
			this.remove_file.Name = "remove_file";
			this.remove_file.Size = new System.Drawing.Size(59, 23);
			this.remove_file.TabIndex = 128;
			this.remove_file.Text = "Remove";
			this.remove_file.UseVisualStyleBackColor = true;
			this.remove_file.Click += new System.EventHandler(this.remove_file_Click);
			// 
			// create_app
			// 
			this.create_app.AutoSize = true;
			this.create_app.Location = new System.Drawing.Point(4, 4);
			this.create_app.Name = "create_app";
			this.create_app.Size = new System.Drawing.Size(79, 17);
			this.create_app.TabIndex = 0;
			this.create_app.Text = "Create App";
			this.create_app.UseVisualStyleBackColor = true;
			this.create_app.CheckedChanged += new System.EventHandler(this.create_app_CheckedChanged);
			// 
			// add_file
			// 
			this.add_file.Location = new System.Drawing.Point(292, 48);
			this.add_file.Name = "add_file";
			this.add_file.Size = new System.Drawing.Size(59, 23);
			this.add_file.TabIndex = 127;
			this.add_file.Text = "Add";
			this.add_file.UseVisualStyleBackColor = true;
			this.add_file.Click += new System.EventHandler(this.add_file_Click);
			// 
			// button5
			// 
			this.button5.BackColor = System.Drawing.Color.LightGreen;
			this.button5.Location = new System.Drawing.Point(485, 138);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(75, 23);
			this.button5.TabIndex = 145;
			this.button5.Text = "NEXT";
			this.button5.UseVisualStyleBackColor = false;
			// 
			// button6
			// 
			this.button6.BackColor = System.Drawing.Color.Coral;
			this.button6.Location = new System.Drawing.Point(485, 99);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(75, 23);
			this.button6.TabIndex = 144;
			this.button6.Text = "Start Over";
			this.button6.UseVisualStyleBackColor = false;
			this.button6.Click += new System.EventHandler(this.button6_Click);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(12, 121);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(460, 40);
			this.textBox1.TabIndex = 143;
			// 
			// output_file
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(574, 206);
			this.ControlBox = false;
			this.Controls.Add(this.button5);
			this.Controls.Add(this.button6);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.panel6);
			this.Name = "output_file";
			this.Text = "output_file";
			this.panel6.ResumeLayout(false);
			this.panel6.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel panel6;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox outputFileTextbox;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button remove_file;
		private System.Windows.Forms.CheckBox create_app;
		private System.Windows.Forms.Button add_file;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.TextBox textBox1;

	}
}