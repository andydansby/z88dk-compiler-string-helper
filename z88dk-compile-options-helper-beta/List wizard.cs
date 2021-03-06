﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace z88dk_compile_options_helper_beta
{
	public partial class List_wizard : Form
	{
		public List<string> ListOptions = new List<string>();

		public List_wizard()
		{
			InitializeComponent();
		}

		public List_wizard(string strTextBox)
		{
			InitializeComponent();
			textBox1.Text = strTextBox;
			string platform = strTextBox;
			ListOptions.Add(platform);
			
			enableOptions();

			if (zccvariables.choosenTarget == false)
			{
				choose_target.Enabled = true;
				compiler_choice.Enabled = false;
				verbose_options.Enabled = false;
				cleanup_options.Enabled = false;
				floating_point_options.Enabled = false;
				zorg_options.Enabled = false;
				optimization_options.Enabled = false;
				terminal_options.Enabled = false;
			}


			//tick off options once selected
			if (zccvariables.choosenTarget == true)
			{
				label1.Visible = true;
				choose_target.Enabled = false;
				compiler_choice.Enabled = true;
			}
			//tick off options once selected
			if (zccvariables.compilerChoice == true)
			{
				label2.Visible = true;
				compiler_choice.Enabled = false;
				verbose_options.Enabled = true;
				cleanup_options.Enabled = true;
				floating_point_options.Enabled = true;
				zorg_options.Enabled = true;
				optimization_options.Enabled = true;
				terminal_options.Enabled = true;
				media_options.Enabled = true;
				output_file.Enabled = true;
			}
			if (zccvariables.verboseOptions == true)
			{
				label3.Visible = true;
				verbose_options.Enabled = false;
			}
			if (zccvariables.cleanupOptions == true)
			{
				label4.Visible = true;
				cleanup_options.Enabled = false;
			}
			if (zccvariables.floatingPointOptions == true)
			{
				label5.Visible = true;
				floating_point_options.Enabled = false;
			}
			if (zccvariables.zorgOptions == true)
			{
				label6.Visible = true;
				zorg_options.Enabled = false;
			}
			if (zccvariables.optimizationOptions == true)
			{
				label7.Visible = true;
				optimization_options.Enabled = false;
			}
			if (zccvariables.terminalOptions == true)
			{
				label8.Visible = true;
				terminal_options.Enabled = false;
			}
			if (zccvariables.mediaOptions == true)
			{
				label9.Visible = true;
				media_options.Enabled = false;
			}

		}

		private void enableOptions()
		{
		}


		private void choose_target_Click(object sender, EventArgs e)
		{
			target frm = new target();
			frm.Show();
			this.Close();
		}


		private void compiler_choice_Click(object sender, EventArgs e)
		{
			compiler_choice frm = new compiler_choice(textBox1.Text);
			frm.Show();
			this.Close();
		}

		private void verbose_options_Click(object sender, EventArgs e)
		{
			verbose_options frm = new verbose_options(textBox1.Text);
			frm.Show();
			this.Close();
		}

		private void cleanup_options_Click(object sender, EventArgs e)
		{
			//option_preserve
			option_preserve frm = new option_preserve(textBox1.Text);
			frm.Show();
			this.Close();
		}

		private void floating_point_options_Click(object sender, EventArgs e)
		{
			floating_point frm = new floating_point(textBox1.Text);
			frm.Show();
			this.Close();
		}

		private void zorg_options_Click(object sender, EventArgs e)
		{
			zorg frm = new zorg(textBox1.Text);
			frm.Show();
			this.Close();
		}

		private void optimization_options_Click(object sender, EventArgs e)
		{
			//optimization
			optimization frm = new optimization(textBox1.Text);
			frm.Show();
			this.Close();
		}

		private void terminal_options_Click(object sender, EventArgs e)
		{
			//terminal_driver
			terminal_driver frm = new terminal_driver(textBox1.Text);
			frm.Show();
			this.Close();
		}

		private void media_options_Click(object sender, EventArgs e)
		{
			Output_Media frm = new Output_Media(textBox1.Text);
			frm.Show();
			this.Close();
		}

		private void output_file_Click(object sender, EventArgs e)
		{
			//output_file
			output_file frm = new output_file(textBox1.Text);
			frm.Show();
			this.Close();
		}


	}
}
