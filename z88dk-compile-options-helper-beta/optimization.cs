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
	public partial class optimization : Form
	{
		public List<string> ListOptions = new List<string>();

		public optimization()
		{
			InitializeComponent();
		}

		public optimization(string strTextBox)
		{
			InitializeComponent();
			textBox1.Text = strTextBox;
			string platform = strTextBox;
			ListOptions.Add(platform);

			if (zccvariables.sdcc_compiler == true)
			{
				MessageBox.Show("SDCC");

				enable_O_n.Enabled = true;
				enable_SO_n.Enabled = true;
				Enable_max_alloc_per_node.Enabled = true;
				Enable_OPT_Code_Size.Enabled = true;

				enable_O_n.Checked = false;
				enable_SO_n.Checked = false;
				Enable_max_alloc_per_node.Checked = false;
				Enable_OPT_Code_Size.Checked = false;

			}


			if (zccvariables.sdcc_compiler == false)
			{
				MessageBox.Show("SCCZ80");

				enable_O_n.Enabled = true;
				enable_SO_n.Enabled = false;
				Enable_max_alloc_per_node.Enabled = false;
				Enable_OPT_Code_Size.Enabled = false;

				enable_O_n.Checked = false;
				enable_SO_n.Checked = false;
				Enable_max_alloc_per_node.Checked = false;
				Enable_OPT_Code_Size.Checked = false;
			}

			this.StartPosition = FormStartPosition.Manual;
			this.Location = new Point(0, 0);

			enableOptions();
		}

		private void enableOptions()
		{


		}

		private void enable_O_n_CheckedChanged(object sender, EventArgs e)
		{
			if (enable_O_n.Checked == true)
			{
				O_0_optimizer.Enabled = true;
				O_1_optimizer.Enabled = true;
				O_2_optimizer.Enabled = true;
				O_3_optimizer.Enabled = true;

				O_0_optimizer.Checked = false;
				O_1_optimizer.Checked = false;
				O_2_optimizer.Checked = false;
				O_3_optimizer.Checked = false;

				

				SO_0_sdcc_optimizer.Enabled = false;
				SO_1_sdcc_optimizer.Enabled = false;
				SO_2_sdcc_optimizer.Enabled = false;
				SO_3_sdcc_optimizer.Enabled = false;

				enable_SO_n.Checked = false;

				SO_0_sdcc_optimizer.Checked = false;
				SO_1_sdcc_optimizer.Checked = false;
				SO_2_sdcc_optimizer.Checked = false;
				SO_3_sdcc_optimizer.Checked = false;

			}
			if (enable_O_n.Checked == false)
			{
				O_0_optimizer.Enabled = false;
				O_1_optimizer.Enabled = false;
				O_2_optimizer.Enabled = false;
				O_3_optimizer.Enabled = false;

				O_0_optimizer.Checked = false;
				O_1_optimizer.Checked = false;
				O_2_optimizer.Checked = false;
				O_3_optimizer.Checked = false;
			}
		}

		private void enable_SO_n_CheckedChanged(object sender, EventArgs e)
		{
			if (enable_SO_n.Checked == true)
			{
				SO_0_sdcc_optimizer.Enabled = true;
				SO_1_sdcc_optimizer.Enabled = true;
				SO_2_sdcc_optimizer.Enabled = true;
				SO_3_sdcc_optimizer.Enabled = true;

				SO_0_sdcc_optimizer.Checked = false;
				SO_1_sdcc_optimizer.Checked = false;
				SO_2_sdcc_optimizer.Checked = false;
				SO_3_sdcc_optimizer.Checked = false;


				O_0_optimizer.Enabled = false;
				O_1_optimizer.Enabled = false;
				O_2_optimizer.Enabled = false;
				O_3_optimizer.Enabled = false;

				enable_O_n.Checked = false;
				O_0_optimizer.Checked = false;
				O_1_optimizer.Checked = false;
				O_2_optimizer.Checked = false;
				O_3_optimizer.Checked = false;

			}
			if (enable_SO_n.Checked == false)
			{
				SO_0_sdcc_optimizer.Enabled = false;
				SO_1_sdcc_optimizer.Enabled = false;
				SO_2_sdcc_optimizer.Enabled = false;
				SO_3_sdcc_optimizer.Enabled = false;

				SO_0_sdcc_optimizer.Checked = false;
				SO_1_sdcc_optimizer.Checked = false;
				SO_2_sdcc_optimizer.Checked = false;
				SO_3_sdcc_optimizer.Checked = false;
			}
		}






	}
}
