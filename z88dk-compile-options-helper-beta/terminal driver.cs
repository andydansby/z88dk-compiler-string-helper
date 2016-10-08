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
	public partial class terminal_driver : Form
	{
		public List<string> ListOptions = new List<string>();

		public terminal_driver()
		{
			InitializeComponent();




		}

		public terminal_driver(string strTextBox)
		{
			InitializeComponent();
			textBox1.Text = strTextBox;
			string platform = strTextBox;
			ListOptions.Add(platform);

			#region classic compiler
			if (zccvariables.classicCompiler == true)
			{
				MessageBox.Show("Classic Compiler");

				panel4.Enabled = true;
				panel3.Enabled = true;
				panel2.Enabled = false;

				panel3.BackColor = Color.CadetBlue;
				panel4.BackColor = Color.CadetBlue;
				panel2.BackColor = Color.DarkGray;

				radioButton1.Enabled = true;
				radioButton2.Enabled = true;
				radioButton3.Enabled = true;
				radioButton4.Enabled = true;
				radioButton5.Enabled = true;
				radioButton6.Enabled = true;
				radioButton7.Enabled = true;
				radioButton8.Enabled = false;
				radioButton9.Enabled = true;
				radioButton10.Enabled = true;
				radioButton11.Enabled = true;
				radioButton12.Enabled = true;
				radioButton13.Enabled = true;
				radioButton14.Enabled = true;
				radioButton15.Enabled = true;

				radioButton1.Checked = false;
				radioButton2.Checked = false;
				radioButton3.Checked = false;
				radioButton4.Checked = false;
				radioButton5.Checked = false;
				radioButton6.Checked = false;
				radioButton7.Checked = false;
				radioButton8.Checked = false;
				radioButton9.Checked = false;
				radioButton10.Checked = false;
				radioButton11.Checked = false;
				radioButton12.Checked = false;
				radioButton13.Checked = false;
				radioButton14.Checked = false;
				radioButton15.Checked = false;
			}
			#endregion

			#region new compiler
			if (zccvariables.classicCompiler == false)
			{
				MessageBox.Show("New Compiler");

				panel4.Enabled = false;
				panel3.Enabled = false;
				panel2.Enabled = true;

				panel3.BackColor = Color.DarkGray;
				panel4.BackColor = Color.DarkGray;
				panel2.BackColor = Color.CadetBlue;

				radioButton1.Enabled = false;
				radioButton2.Enabled = false;
				radioButton3.Enabled = false;
				radioButton4.Enabled = false;
				radioButton5.Enabled = false;
				radioButton6.Enabled = false;
				radioButton7.Enabled = false;
				radioButton8.Enabled = true;
				radioButton9.Enabled = false;
				radioButton10.Enabled = false;
				radioButton11.Enabled = false;
				radioButton12.Enabled = false;
				radioButton13.Enabled = false;
				radioButton14.Enabled = false;
				radioButton15.Enabled = false;

				radioButton1.Checked = false;
				radioButton2.Checked = false;
				radioButton3.Checked = false;
				radioButton4.Checked = false;
				radioButton5.Checked = false;
				radioButton6.Checked = false;
				radioButton7.Checked = false;
				radioButton8.Checked = false;
				radioButton9.Checked = false;
				radioButton10.Checked = false;
				radioButton11.Checked = false;
				radioButton12.Checked = false;
				radioButton13.Checked = false;
				radioButton14.Checked = false;
				radioButton15.Checked = false;
			}
			#endregion
						
			enableOptions();
		}

		private void enableOptions()
		{


		}

	}
}
