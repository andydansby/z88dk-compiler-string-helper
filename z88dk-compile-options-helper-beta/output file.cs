using System;
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
	public partial class output_file : Form
	{
		public List<string> ListOptions = new List<string>();

		string outputFile = "";

		public output_file()
		{
			InitializeComponent();
		}

		public output_file(string strTextBox)
		{
			InitializeComponent();
			textBox1.Text = strTextBox;
			string platform = strTextBox;
			ListOptions.Add(platform);

			enableOptions();
		}

		private void enableOptions()
		{
		}

		private void create_app_CheckedChanged(object sender, EventArgs e)
		{
			//-create-app
			if (create_app.Checked)
			{
				string createApp = "-create-app ";
				ListOptions.Add(createApp);
				//MessageBox.Show("Radio Button 2 off");
				string create = string.Join("", ListOptions.ToArray());
				textBox1.Text = create;

			}
			else if (create_app.Checked == false)
			{
				string createApp = "-create-app ";
				ListOptions.Remove(createApp);
				string create = string.Join("", ListOptions.ToArray());
				textBox1.Text = create;
			}
		}

		private void add_file_Click(object sender, EventArgs e)
		{
			if (outputFileTextbox.Text == "")
			{
				add_file.Enabled = true;
				remove_file.Enabled = false;
			}
			else
			{
				outputFile = outputFileTextbox.Text;
				string file = "-o " + outputFile + " ";
				ListOptions.Add(file);

				string create = string.Join("", ListOptions.ToArray());
				textBox1.Text = create;

				add_file.Enabled = false;
				remove_file.Enabled = true;
			}
		}

		private void remove_file_Click(object sender, EventArgs e)
		{
			outputFileTextbox.Text = "";

			string file = "-o " + outputFile + " ";
			ListOptions.Remove(file);
			string create = string.Join("", ListOptions.ToArray());
			textBox1.Text = create;

			add_file.Enabled = true;
			remove_file.Enabled = false;
		}

		private void button6_Click(object sender, EventArgs e)
		{
			zccvariables.restartForm1 = true;

			Form1 startOver = (Form1)Application.OpenForms["Form1"];
			startOver.Show();

			this.Close();
		}
	}
}
