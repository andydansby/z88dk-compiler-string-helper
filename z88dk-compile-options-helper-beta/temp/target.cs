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
	public partial class target : Form
	{
		public target()
		{
			InitializeComponent();
		}

		private void radioButton1_CheckedChanged(object sender, EventArgs e)
		{
			textBox1.Text = "zcc +zx ";
			zccvariables.machine = "zx";
		}

		private void radioButton2_CheckedChanged(object sender, EventArgs e)
		{
			textBox1.Text = "zcc +ts2068 ";
			zccvariables.machine = "ts2068";
		}

		private void radioButton49_CheckedChanged(object sender, EventArgs e)
		{
			textBox1.Text = "zcc +zx81 ";
			zccvariables.machine = "zx81";
		}

		private void radioButton42_CheckedChanged(object sender, EventArgs e)
		{
			textBox1.Text = "zcc +zx80 ";
			zccvariables.machine = "zx80";
		}

		private void radioButton3_CheckedChanged(object sender, EventArgs e)
		{
			textBox1.Text = "zcc +abc80 ";
			zccvariables.machine = "abc80";
		}

		private void radioButton4_CheckedChanged(object sender, EventArgs e)
		{
			textBox1.Text = "zcc +abc800 ";
			zccvariables.machine = "abc800";
		}

		private void radioButton5_CheckedChanged(object sender, EventArgs e)
		{
			textBox1.Text = "zcc +ace ";
			zccvariables.machine = "ace";
		}

		private void radioButton6_CheckedChanged(object sender, EventArgs e)
		{
			textBox1.Text = "zcc +aquarius ";
			zccvariables.machine = "aquarius";
		}

		private void radioButton7_CheckedChanged(object sender, EventArgs e)
		{
			textBox1.Text = "zcc +c128 ";
			zccvariables.machine = "c128";
		}

		private void radioButton8_CheckedChanged(object sender, EventArgs e)
		{
			textBox1.Text = "zcc +c7420 ";
			zccvariables.machine = "c7420";
		}

		private void radioButton9_CheckedChanged(object sender, EventArgs e)
		{
			textBox1.Text = "zcc +cpc ";
			zccvariables.machine = "cpc";
		}

		private void radioButton10_CheckedChanged(object sender, EventArgs e)
		{
			textBox1.Text = "zcc +cpm ";
			zccvariables.machine = "cpm";
		}

		private void radioButton11_CheckedChanged(object sender, EventArgs e)
		{
			textBox1.Text = "zcc +embedded ";
			zccvariables.machine = "embedded";
		}

		private void radioButton12_CheckedChanged(object sender, EventArgs e)
		{
			textBox1.Text = "zcc +enterprise ";
			zccvariables.machine = "enterprise";
		}

		private void radioButton13_CheckedChanged(object sender, EventArgs e)
		{
			textBox1.Text = "zcc +gal ";
			zccvariables.machine = "gal";
		}

		private void radioButton14_CheckedChanged(object sender, EventArgs e)
		{
			textBox1.Text = "zcc +lambda ";
			zccvariables.machine = "lambda";
		}

		private void radioButton15_CheckedChanged(object sender, EventArgs e)
		{
			textBox1.Text = "zcc +lynx ";
			zccvariables.machine = "lynx";
		}

		private void radioButton16_CheckedChanged(object sender, EventArgs e)
		{
			textBox1.Text = "zcc +m5 ";
			zccvariables.machine = "m5";
		}

		private void radioButton17_CheckedChanged(object sender, EventArgs e)
		{
			textBox1.Text = "zcc +mc1000 ";
			zccvariables.machine = "mc1000";
		}

		private void radioButton18_CheckedChanged(object sender, EventArgs e)
		{
			textBox1.Text = "zcc +msx ";
			zccvariables.machine = "msx";
		}

		private void radioButton19_CheckedChanged(object sender, EventArgs e)
		{
			textBox1.Text = "zcc +mtx ";
			zccvariables.machine = "mtx";
		}

		private void radioButton20_CheckedChanged(object sender, EventArgs e)
		{
			textBox1.Text = "zcc +nascom ";
			zccvariables.machine = "nascom";
		}

		private void radioButton21_CheckedChanged(object sender, EventArgs e)
		{
			textBox1.Text = "zcc +nc ";
			zccvariables.machine = "nc";
		}

		private void radioButton22_CheckedChanged(object sender, EventArgs e)
		{
			textBox1.Text = "zcc +newbrain ";
			zccvariables.machine = "newbrain";
		}

		private void radioButton23_CheckedChanged(object sender, EventArgs e)
		{
			textBox1.Text = "zcc +osca ";
			zccvariables.machine = "osca";
		}

		private void radioButton24_CheckedChanged(object sender, EventArgs e)
		{
			textBox1.Text = "zcc +oz ";
			zccvariables.machine = "oz";
		}

		private void radioButton25_CheckedChanged(object sender, EventArgs e)
		{
			textBox1.Text = "zcc +p2000 ";
			zccvariables.machine = "p2000";
		}

		private void radioButton26_CheckedChanged(object sender, EventArgs e)
		{
			textBox1.Text = "zcc +pc6001 ";
			zccvariables.machine = "pc6001";
		}

		private void radioButton27_CheckedChanged(object sender, EventArgs e)
		{
			textBox1.Text = "zcc +pps ";
			zccvariables.machine = "pps";
		}

		private void radioButton28_CheckedChanged(object sender, EventArgs e)
		{
			textBox1.Text = "zcc +rcmx000 ";
			zccvariables.machine = "rcmx000";
		}

		private void radioButton29_CheckedChanged(object sender, EventArgs e)
		{
			textBox1.Text = "zcc +rex ";
			zccvariables.machine = "rex";
		}

		private void radioButton30_CheckedChanged(object sender, EventArgs e)
		{
			textBox1.Text = "zcc +sam ";
			zccvariables.machine = "sam";
		}

		private void radioButton31_CheckedChanged(object sender, EventArgs e)
		{
			textBox1.Text = "zcc +sc3000 ";
			zccvariables.machine = "sc3000";
		}

		private void radioButton32_CheckedChanged(object sender, EventArgs e)
		{
			textBox1.Text = "zcc +sms ";
			zccvariables.machine = "sms";
		}

		private void radioButton33_CheckedChanged(object sender, EventArgs e)
		{
			textBox1.Text = "zcc +sos ";
			zccvariables.machine = "sos";
		}

		private void radioButton34_CheckedChanged(object sender, EventArgs e)
		{
			textBox1.Text = "zcc +srr ";
			zccvariables.machine = "srr";
		}

		private void radioButton35_CheckedChanged(object sender, EventArgs e)
		{
			textBox1.Text = "zcc +svi ";
			zccvariables.machine = "svi";
		}

		private void radioButton36_CheckedChanged(object sender, EventArgs e)
		{
			textBox1.Text = "zcc +ti8x ";
			zccvariables.machine = "ti8x";
		}

		private void radioButton37_CheckedChanged(object sender, EventArgs e)
		{
			textBox1.Text = "zcc +ti82 ";
			zccvariables.machine = "ti82";
		}

		private void radioButton38_CheckedChanged(object sender, EventArgs e)
		{
			textBox1.Text = "zcc +ti83 ";
			zccvariables.machine = "ti83";
		}

		private void radioButton39_CheckedChanged(object sender, EventArgs e)
		{
			textBox1.Text = "zcc +ti85 ";
			zccvariables.machine = "ti85";
		}

		private void radioButton40_CheckedChanged(object sender, EventArgs e)
		{
			textBox1.Text = "zcc +ti86 ";
			zccvariables.machine = "ti86";
		}

		private void radioButton41_CheckedChanged(object sender, EventArgs e)
		{
			textBox1.Text = "zcc +trs80 ";
			zccvariables.machine = "trs80";
		}

		private void radioButton43_CheckedChanged(object sender, EventArgs e)
		{
			textBox1.Text = "zcc +vg5k ";
			zccvariables.machine = "vg5k";
		}

		private void radioButton44_CheckedChanged(object sender, EventArgs e)
		{
			textBox1.Text = "zcc +vz ";
			zccvariables.machine = "vz";
		}

		private void radioButton45_CheckedChanged(object sender, EventArgs e)
		{
			textBox1.Text = "zcc +x1 ";
			zccvariables.machine = "x1";
		}

		private void radioButton46_CheckedChanged(object sender, EventArgs e)
		{
			textBox1.Text = "zcc +x07 ";
			zccvariables.machine = "x07";
		}

		private void radioButton47_CheckedChanged(object sender, EventArgs e)
		{
			textBox1.Text = "zcc +z88 ";
			zccvariables.machine = "z88";
		}

		private void radioButton48_CheckedChanged(object sender, EventArgs e)
		{
			textBox1.Text = "zcc +zcc ";
			zccvariables.machine = "zcc";
		}

		//next screen
		private void button1_Click(object sender, EventArgs e)
		{
			//this.Hide();
			compiler_choice frm = new compiler_choice(textBox1.Text);
			frm.Show();
			this.Close();
		}

	}
}
