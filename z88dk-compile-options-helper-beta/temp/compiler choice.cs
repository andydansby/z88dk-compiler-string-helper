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
	public partial class compiler_choice : Form
	{
		public List<string> ListOptions = new List<string>();

		public int targetMachine;

		public compiler_choice()
		{
			InitializeComponent();
		}

		public compiler_choice(string strTextBox)
		{
			InitializeComponent();
			textBox1.Text = strTextBox;
			string platform = strTextBox;
			ListOptions.Add(platform);
			
			enableOptions();
		}

		private void enableOptions()
		{

			//MessageBox.Show(zccvariables.machine);

			#region abc80
			if (zccvariables.machine == "abc80")
			{
				radioButton1.Enabled = false;//sdcc_ix
				radioButton2.Enabled = false;//sdcc_iy
				radioButton3.Enabled = false;//new
				radioButton4.Enabled = true;//ansi
				radioButton5.Enabled = false;//net
				radioButton6.Enabled = false;//mt
				radioButton7.Enabled = false;//g007
				radioButton8.Enabled = false;//udg
				radioButton9.Enabled = false;//wrxansi
				radioButton10.Enabled = false;//arx
				radioButton11.Enabled = false;//wrx
				radioButton12.Enabled = false;//wrx64ansi
				radioButton13.Enabled = false;//mt64
				radioButton14.Enabled = false;//arx64
				radioButton15.Enabled = false;//wrx64
			}
			#endregion

			#region abc800
			if (zccvariables.machine == "abc800")
			{
				radioButton1.Enabled = false;//sdcc_ix
				radioButton2.Enabled = false;//sdcc_iy
				radioButton3.Enabled = false;//new
				radioButton4.Enabled = true;//ansi
				radioButton5.Enabled = false;//net
				radioButton6.Enabled = false;//mt
				radioButton7.Enabled = false;//g007
				radioButton8.Enabled = false;//udg
				radioButton9.Enabled = false;//wrxansi
				radioButton10.Enabled = false;//arx
				radioButton11.Enabled = false;//wrx
				radioButton12.Enabled = false;//wrx64ansi
				radioButton13.Enabled = false;//mt64
				radioButton14.Enabled = false;//arx64
				radioButton15.Enabled = false;//wrx64
			}
			#endregion

			#region ace
			if (zccvariables.machine == "ace")
			{
				radioButton1.Enabled = false;//sdcc_ix
				radioButton2.Enabled = false;//sdcc_iy
				radioButton3.Enabled = false;//new
				radioButton4.Enabled = true;//ansi
				radioButton5.Enabled = false;//net
				radioButton6.Enabled = true;//mt
				radioButton7.Enabled = true;//g007
				radioButton8.Enabled = true;//udg
				radioButton9.Enabled = true;//wrxansi
				radioButton10.Enabled = true;//arx
				radioButton11.Enabled = true;//wrx
				radioButton12.Enabled = true;//wrx64ansi
				radioButton13.Enabled = true;//mt64
				radioButton14.Enabled = true;//arx64
				radioButton15.Enabled = true;//wrx64
			}
			#endregion

			#region aquarius
			if (zccvariables.machine == "aquarius")
			{
				radioButton1.Enabled = false;//sdcc_ix
				radioButton2.Enabled = false;//sdcc_iy
				radioButton3.Enabled = false;//new
				radioButton4.Enabled = true;//ansi
				radioButton5.Enabled = false;//net
				radioButton6.Enabled = false;//mt
				radioButton7.Enabled = false;//g007
				radioButton8.Enabled = false;//udg
				radioButton9.Enabled = false;//wrxansi
				radioButton10.Enabled = false;//arx
				radioButton11.Enabled = false;//wrx
				radioButton12.Enabled = false;//wrx64ansi
				radioButton13.Enabled = false;//mt64
				radioButton14.Enabled = false;//arx64
				radioButton15.Enabled = false;//wrx64
			}
			#endregion

			#region c128
			if (zccvariables.machine == "c128")
			{
				radioButton1.Enabled = false;//sdcc_ix
				radioButton2.Enabled = false;//sdcc_iy
				radioButton3.Enabled = false;//new
				radioButton4.Enabled = true;//ansi
				radioButton5.Enabled = false;//net
				radioButton6.Enabled = false;//mt
				radioButton7.Enabled = false;//g007
				radioButton8.Enabled = false;//udg
				radioButton9.Enabled = false;//wrxansi
				radioButton10.Enabled = false;//arx
				radioButton11.Enabled = false;//wrx
				radioButton12.Enabled = false;//wrx64ansi
				radioButton13.Enabled = false;//mt64
				radioButton14.Enabled = false;//arx64
				radioButton15.Enabled = false;//wrx64
			}
			#endregion

			#region c7420
			if (zccvariables.machine == "c7420")
			{
				radioButton1.Enabled = false;//sdcc_ix
				radioButton2.Enabled = false;//sdcc_iy
				radioButton3.Enabled = false;//new
				radioButton4.Enabled = true;//ansi
				radioButton5.Enabled = false;//net
				radioButton6.Enabled = false;//mt
				radioButton7.Enabled = false;//g007
				radioButton8.Enabled = false;//udg
				radioButton9.Enabled = false;//wrxansi
				radioButton10.Enabled = false;//arx
				radioButton11.Enabled = false;//wrx
				radioButton12.Enabled = false;//wrx64ansi
				radioButton13.Enabled = false;//mt64
				radioButton14.Enabled = false;//arx64
				radioButton15.Enabled = false;//wrx64
			}
			#endregion

			#region cpc
			if (zccvariables.machine == "cpc")
			{
				radioButton1.Enabled = false;//sdcc_ix
				radioButton2.Enabled = false;//sdcc_iy
				radioButton3.Enabled = false;//new
				radioButton4.Enabled = true;//ansi
				radioButton5.Enabled = false;//net
				radioButton6.Enabled = false;//mt
				radioButton7.Enabled = false;//g007
				radioButton8.Enabled = false;//udg
				radioButton9.Enabled = false;//wrxansi
				radioButton10.Enabled = false;//arx
				radioButton11.Enabled = false;//wrx
				radioButton12.Enabled = false;//wrx64ansi
				radioButton13.Enabled = false;//mt64
				radioButton14.Enabled = false;//arx64
				radioButton15.Enabled = false;//wrx64
			}
			#endregion

			#region cpm
			if (zccvariables.machine == "cpm")
			{
				radioButton1.Enabled = false;//sdcc_ix
				radioButton2.Enabled = false;//sdcc_iy
				radioButton3.Enabled = false;//new
				radioButton4.Enabled = true;//ansi
				radioButton5.Enabled = false;//net
				radioButton6.Enabled = false;//mt
				radioButton7.Enabled = false;//g007
				radioButton8.Enabled = false;//udg
				radioButton9.Enabled = false;//wrxansi
				radioButton10.Enabled = false;//arx
				radioButton11.Enabled = false;//wrx
				radioButton12.Enabled = false;//wrx64ansi
				radioButton13.Enabled = false;//mt64
				radioButton14.Enabled = false;//arx64
				radioButton15.Enabled = false;//wrx64
			}
			#endregion




			#region lambda
			//Lambda 8300
			//improved chinese clone of the ZX81
			if (zccvariables.machine == "lambda")
			{
				radioButton1.Enabled = false;//sdcc_ix
				radioButton2.Enabled = false;//sdcc_iy
				radioButton3.Enabled = false;//new
				radioButton4.Enabled = true;//ansi
				radioButton5.Enabled = false;//net
				radioButton6.Enabled = true;//mt
				radioButton7.Enabled = true;//g007
				radioButton8.Enabled = true;//udg
				radioButton9.Enabled = true;//wrxansi
				radioButton10.Enabled = true;//arx
				radioButton11.Enabled = true;//wrx
				radioButton12.Enabled = true;//wrx64ansi
				radioButton13.Enabled = true;//mt64
				radioButton14.Enabled = true;//arx64
				radioButton15.Enabled = true;//wrx64
			}
			#endregion



			#region mc1000
			if (zccvariables.machine == "mc1000")
			{
				radioButton1.Enabled = false;//sdcc_ix
				radioButton2.Enabled = false;//sdcc_iy
				radioButton3.Enabled = false;//new
				radioButton4.Enabled = true;//ansi
				radioButton5.Enabled = false;//net
				radioButton6.Enabled = false;//mt
				radioButton7.Enabled = false;//g007
				radioButton8.Enabled = false;//udg
				radioButton9.Enabled = false;//wrxansi
				radioButton10.Enabled = false;//arx
				radioButton11.Enabled = false;//wrx
				radioButton12.Enabled = false;//wrx64ansi
				radioButton13.Enabled = false;//mt64
				radioButton14.Enabled = false;//arx64
				radioButton15.Enabled = false;//wrx64
			}
			#endregion




			#region nascom
			//nascom
			if (zccvariables.machine == "nascom")
			{
				radioButton1.Enabled = false;//sdcc_ix
				radioButton2.Enabled = false;//sdcc_iy
				radioButton3.Enabled = false;//new
				radioButton4.Enabled = true;//ansi
				radioButton5.Enabled = false;//net
				radioButton6.Enabled = false;//mt
				radioButton7.Enabled = false;//g007
				radioButton8.Enabled = false;//udg
				radioButton9.Enabled = false;//wrxansi
				radioButton10.Enabled = false;//arx
				radioButton11.Enabled = false;//wrx
				radioButton12.Enabled = false;//wrx64ansi
				radioButton13.Enabled = false;//mt64
				radioButton14.Enabled = false;//arx64
				radioButton15.Enabled = false;//wrx64
			}
			#endregion


			#region p2000
			//p2000
			if (zccvariables.machine == "p2000")
			{
				radioButton1.Enabled = false;//sdcc_ix
				radioButton2.Enabled = false;//sdcc_iy
				radioButton3.Enabled = false;//new
				radioButton4.Enabled = true;//ansi
				radioButton5.Enabled = false;//net
				radioButton6.Enabled = false;//mt
				radioButton7.Enabled = false;//g007
				radioButton8.Enabled = false;//udg
				radioButton9.Enabled = false;//wrxansi
				radioButton10.Enabled = false;//arx
				radioButton11.Enabled = false;//wrx
				radioButton12.Enabled = false;//wrx64ansi
				radioButton13.Enabled = false;//mt64
				radioButton14.Enabled = false;//arx64
				radioButton15.Enabled = false;//wrx64
			}
			#endregion





			#region pc6001
			if (zccvariables.machine == "pc6001")
			{
				radioButton1.Enabled = false;//sdcc_ix
				radioButton2.Enabled = false;//sdcc_iy
				radioButton3.Enabled = false;//new
				radioButton4.Enabled = true;//ansi
				radioButton5.Enabled = false;//net
				radioButton6.Enabled = false;//mt
				radioButton7.Enabled = false;//g007
				radioButton8.Enabled = false;//udg
				radioButton9.Enabled = false;//wrxansi
				radioButton10.Enabled = false;//arx
				radioButton11.Enabled = false;//wrx
				radioButton12.Enabled = false;//wrx64ansi
				radioButton13.Enabled = false;//mt64
				radioButton14.Enabled = false;//arx64
				radioButton15.Enabled = false;//wrx64
			}
			#endregion



			#region pps
			if (zccvariables.machine == "pps")
			{
				radioButton1.Enabled = false;//sdcc_ix
				radioButton2.Enabled = false;//sdcc_iy
				radioButton3.Enabled = false;//new
				radioButton4.Enabled = true;//ansi
				radioButton5.Enabled = false;//net
				radioButton6.Enabled = false;//mt
				radioButton7.Enabled = false;//g007
				radioButton8.Enabled = false;//udg
				radioButton9.Enabled = false;//wrxansi
				radioButton10.Enabled = false;//arx
				radioButton11.Enabled = false;//wrx
				radioButton12.Enabled = false;//wrx64ansi
				radioButton13.Enabled = false;//mt64
				radioButton14.Enabled = false;//arx64
				radioButton15.Enabled = false;//wrx64
			}
			#endregion


			#region sam
			if (zccvariables.machine == "sam")
			{
				radioButton1.Enabled = false;//sdcc_ix
				radioButton2.Enabled = false;//sdcc_iy
				radioButton3.Enabled = false;//new
				radioButton4.Enabled = true;//ansi
				radioButton5.Enabled = false;//net
				radioButton6.Enabled = false;//mt
				radioButton7.Enabled = false;//g007
				radioButton8.Enabled = false;//udg
				radioButton9.Enabled = false;//wrxansi
				radioButton10.Enabled = false;//arx
				radioButton11.Enabled = false;//wrx
				radioButton12.Enabled = false;//wrx64ansi
				radioButton13.Enabled = false;//mt64
				radioButton14.Enabled = false;//arx64
				radioButton15.Enabled = false;//wrx64
			}
			#endregion





			#region ts2068
			if (zccvariables.machine == "ts2068")
			{
				radioButton1.Enabled = true;//sdcc_ix
				radioButton2.Enabled = true;//sdcc_iy
				radioButton3.Enabled = true;//new
				radioButton4.Enabled = true;//ansi
				radioButton5.Enabled = false;//net
				radioButton6.Enabled = false;//mt
				radioButton7.Enabled = false;//g007
				radioButton8.Enabled = false;//udg
				radioButton9.Enabled = false;//wrxansi
				radioButton10.Enabled = false;//arx
				radioButton11.Enabled = false;//wrx
				radioButton12.Enabled = false;//wrx64ansi
				radioButton13.Enabled = false;//mt64
				radioButton14.Enabled = false;//arx64
				radioButton15.Enabled = false;//wrx64
			}
			#endregion

			

			


			#region vg5k
			//vg5000
			if (zccvariables.machine == "vg5k")
			{
				radioButton1.Enabled = false;//sdcc_ix
				radioButton2.Enabled = false;//sdcc_iy
				radioButton3.Enabled = false;//new
				radioButton4.Enabled = true;//ansi
				radioButton5.Enabled = false;//net
				radioButton6.Enabled = false;//mt
				radioButton7.Enabled = false;//g007
				radioButton8.Enabled = false;//udg
				radioButton9.Enabled = false;//wrxansi
				radioButton10.Enabled = false;//arx
				radioButton11.Enabled = false;//wrx
				radioButton12.Enabled = false;//wrx64ansi
				radioButton13.Enabled = false;//mt64
				radioButton14.Enabled = false;//arx64
				radioButton15.Enabled = false;//wrx64
			}
			#endregion


			#region vz
			if (zccvariables.machine == "vz")
			{
				radioButton1.Enabled = false;//sdcc_ix
				radioButton2.Enabled = false;//sdcc_iy
				radioButton3.Enabled = false;//new
				radioButton4.Enabled = true;//ansi
				radioButton5.Enabled = false;//net
				radioButton6.Enabled = false;//mt
				radioButton7.Enabled = false;//g007
				radioButton8.Enabled = false;//udg
				radioButton9.Enabled = false;//wrxansi
				radioButton10.Enabled = false;//arx
				radioButton11.Enabled = false;//wrx
				radioButton12.Enabled = false;//wrx64ansi
				radioButton13.Enabled = false;//mt64
				radioButton14.Enabled = false;//arx64
				radioButton15.Enabled = false;//wrx64
			}
			#endregion







			



			










			#region zx spectrum
			if (zccvariables.machine == "zx")
			{
				radioButton1.Enabled = true;//sdcc_ix
				radioButton2.Enabled = true;//sdcc_iy
				radioButton3.Enabled = true;//new
				radioButton4.Enabled = true;//ansi
				radioButton5.Enabled = false;//net
				radioButton6.Enabled = false;//mt
				radioButton7.Enabled = false;//g007
				radioButton8.Enabled = false;//udg
				radioButton9.Enabled = false;//wrxansi
				radioButton10.Enabled = false;//arx
				radioButton11.Enabled = false;//wrx
				radioButton12.Enabled = false;//wrx64ansi
				radioButton13.Enabled = false;//mt64
				radioButton14.Enabled = false;//arx64
				radioButton15.Enabled = false;//wrx64
			}
			#endregion

			#region zx80
			if (zccvariables.machine == "zx80")
			{
				radioButton1.Enabled = false;//sdcc_ix
				radioButton2.Enabled = false;//sdcc_iy
				radioButton3.Enabled = false;//new
				radioButton4.Enabled = true;//ansi
				radioButton5.Enabled = false;//net
				radioButton6.Enabled = false;//mt
				radioButton7.Enabled = false;//g007
				radioButton8.Enabled = false;//udg
				radioButton9.Enabled = false;//wrxansi
				radioButton10.Enabled = false;//arx
				radioButton11.Enabled = false;//wrx
				radioButton12.Enabled = false;//wrx64ansi
				radioButton13.Enabled = false;//mt64
				radioButton14.Enabled = false;//arx64
				radioButton15.Enabled = false;//wrx64
			}
			#endregion

			#region zx81
			if (zccvariables.machine == "zx81")
			{
				radioButton1.Enabled = false;//sdcc_ix
				radioButton2.Enabled = false;//sdcc_iy
				radioButton3.Enabled = false;//new
				radioButton4.Enabled = true;//ansi
				radioButton5.Enabled = false;//net
				radioButton6.Enabled = true;//mt
				radioButton7.Enabled = true;//g007
				radioButton8.Enabled = true;//udg
				radioButton9.Enabled = true;//wrxansi
				radioButton10.Enabled = true;//arx
				radioButton11.Enabled = true;//wrx
				radioButton12.Enabled = true;//wrx64ansi
				radioButton13.Enabled = true;//mt64
				radioButton14.Enabled = true;//arx64
				radioButton15.Enabled = true;//wrx64
			}
			#endregion

		}

		private void radioButton1_CheckedChanged(object sender, EventArgs e)
		{
			string assemblertype = "-clib=sdcc_ix  ";
			if (radioButton1.Checked)
			{
				//string assemblertype = "-clib=sdcc_ix  ";
				ListOptions.Add(assemblertype);
				string assembler = string.Join("", ListOptions.ToArray());
				textBox1.Text = assembler;
			}
			else if (radioButton1.Checked == false)
			{
				//string assemblertype = "-clib=sdcc_ix  ";
				ListOptions.Remove(assemblertype);
				string assembler = string.Join("", ListOptions.ToArray());
				textBox1.Text = assembler;
			}

		}

		private void radioButton2_CheckedChanged(object sender, EventArgs e)
		{
			//-clib=sdcc_iy
			string assemblertype = "-clib=sdcc_iy  ";
			if (radioButton2.Checked)
			{
				//string assemblertype = "-clib=sdcc_ix  ";
				ListOptions.Add(assemblertype);
				string assembler = string.Join("", ListOptions.ToArray());
				textBox1.Text = assembler;
			}
			else if (radioButton2.Checked == false)
			{
				//string assemblertype = "-clib=sdcc_ix  ";
				ListOptions.Remove(assemblertype);
				string assembler = string.Join("", ListOptions.ToArray());
				textBox1.Text = assembler;
			}
		}

		private void radioButton3_CheckedChanged(object sender, EventArgs e)
		{
			//-clib=new
			string assemblertype = "-clib=new  ";
			if (radioButton3.Checked)
			{
				//string assemblertype = "-clib=sdcc_ix  ";
				ListOptions.Add(assemblertype);
				string assembler = string.Join("", ListOptions.ToArray());
				textBox1.Text = assembler;
			}
			else if (radioButton3.Checked == false)
			{
				//string assemblertype = "-clib=sdcc_ix  ";
				ListOptions.Remove(assemblertype);
				string assembler = string.Join("", ListOptions.ToArray());
				textBox1.Text = assembler;
			}
		}

		private void radioButton4_CheckedChanged(object sender, EventArgs e)
		{
			//-clib=ansi
			string assemblertype = "-clib=ansi  ";
			if (radioButton4.Checked)
			{
				//string assemblertype = "-clib=sdcc_ix  ";
				ListOptions.Add(assemblertype);
				string assembler = string.Join("", ListOptions.ToArray());
				textBox1.Text = assembler;
			}
			else if (radioButton4.Checked == false)
			{
				//string assemblertype = "-clib=sdcc_ix  ";
				ListOptions.Remove(assemblertype);
				string assembler = string.Join("", ListOptions.ToArray());
				textBox1.Text = assembler;
			}

		}

		private void radioButton5_CheckedChanged(object sender, EventArgs e)
		{
			//-clib=ansi
			string assemblertype = "-clib=net  ";
			if (radioButton5.Checked)
			{
				//string assemblertype = "-clib=sdcc_ix  ";
				ListOptions.Add(assemblertype);
				string assembler = string.Join("", ListOptions.ToArray());
				textBox1.Text = assembler;
			}
			else if (radioButton5.Checked == false)
			{
				//string assemblertype = "-clib=sdcc_ix  ";
				ListOptions.Remove(assemblertype);
				string assembler = string.Join("", ListOptions.ToArray());
				textBox1.Text = assembler;
			}
		}

		private void radioButton6_CheckedChanged(object sender, EventArgs e)
		{
			string assemblertype = "-clib=mt ";
			if (radioButton6.Checked)
			{
				ListOptions.Add(assemblertype);
				string assembler = string.Join("", ListOptions.ToArray());
				textBox1.Text = assembler;
			}
			else if (radioButton6.Checked == false)
			{
				ListOptions.Remove(assemblertype);
				string assembler = string.Join("", ListOptions.ToArray());
				textBox1.Text = assembler;
			}
		}

		private void radioButton7_CheckedChanged(object sender, EventArgs e)
		{
			string assemblertype = "-clib=g007 ";
			if (radioButton7.Checked)
			{
				ListOptions.Add(assemblertype);
				string assembler = string.Join("", ListOptions.ToArray());
				textBox1.Text = assembler;
			}
			else if (radioButton7.Checked == false)
			{
				ListOptions.Remove(assemblertype);
				string assembler = string.Join("", ListOptions.ToArray());
				textBox1.Text = assembler;
			}
		}

		private void radioButton8_CheckedChanged(object sender, EventArgs e)
		{
			string assemblertype = "-clib=udg ";
			if (radioButton8.Checked)
			{
				ListOptions.Add(assemblertype);
				string assembler = string.Join("", ListOptions.ToArray());
				textBox1.Text = assembler;
			}
			else if (radioButton8.Checked == false)
			{
				ListOptions.Remove(assemblertype);
				string assembler = string.Join("", ListOptions.ToArray());
				textBox1.Text = assembler;
			}
		}

		private void radioButton9_CheckedChanged(object sender, EventArgs e)
		{
			string assemblertype = "-clib=wrxansi ";
			if (radioButton9.Checked)
			{
				ListOptions.Add(assemblertype);
				string assembler = string.Join("", ListOptions.ToArray());
				textBox1.Text = assembler;
			}
			else if (radioButton9.Checked == false)
			{
				ListOptions.Remove(assemblertype);
				string assembler = string.Join("", ListOptions.ToArray());
				textBox1.Text = assembler;
			}
		}

		private void radioButton13_CheckedChanged(object sender, EventArgs e)
		{
			string assemblertype = "-clib=mt64 ";
			if (radioButton13.Checked)
			{
				ListOptions.Add(assemblertype);
				string assembler = string.Join("", ListOptions.ToArray());
				textBox1.Text = assembler;
			}
			else if (radioButton13.Checked == false)
			{
				ListOptions.Remove(assemblertype);
				string assembler = string.Join("", ListOptions.ToArray());
				textBox1.Text = assembler;
			}
		}

		private void radioButton12_CheckedChanged(object sender, EventArgs e)
		{
			string assemblertype = "-clib=wrx64 ";
			if (radioButton12.Checked)
			{
				ListOptions.Add(assemblertype);
				string assembler = string.Join("", ListOptions.ToArray());
				textBox1.Text = assembler;
			}
			else if (radioButton12.Checked == false)
			{
				ListOptions.Remove(assemblertype);
				string assembler = string.Join("", ListOptions.ToArray());
				textBox1.Text = assembler;
			}
		}

		private void radioButton10_CheckedChanged(object sender, EventArgs e)
		{
			string assemblertype = "-clib=arx ";
			if (radioButton10.Checked)
			{
				ListOptions.Add(assemblertype);
				string assembler = string.Join("", ListOptions.ToArray());
				textBox1.Text = assembler;
			}
			else if (radioButton10.Checked == false)
			{
				ListOptions.Remove(assemblertype);
				string assembler = string.Join("", ListOptions.ToArray());
				textBox1.Text = assembler;
			}
		}

		private void radioButton14_CheckedChanged(object sender, EventArgs e)
		{
			string assemblertype = "-clib=arx64 ";
			if (radioButton14.Checked)
			{
				ListOptions.Add(assemblertype);
				string assembler = string.Join("", ListOptions.ToArray());
				textBox1.Text = assembler;
			}
			else if (radioButton14.Checked == false)
			{
				ListOptions.Remove(assemblertype);
				string assembler = string.Join("", ListOptions.ToArray());
				textBox1.Text = assembler;
			}
		}

		private void radioButton11_CheckedChanged(object sender, EventArgs e)
		{
			string assemblertype = "-clib=wrx ";
			if (radioButton11.Checked)
			{
				ListOptions.Add(assemblertype);
				string assembler = string.Join("", ListOptions.ToArray());
				textBox1.Text = assembler;
			}
			else if (radioButton11.Checked == false)
			{
				ListOptions.Remove(assemblertype);
				string assembler = string.Join("", ListOptions.ToArray());
				textBox1.Text = assembler;
			}
		}

		private void radioButton15_CheckedChanged(object sender, EventArgs e)
		{
			string assemblertype = "-clib=wrx64 ";
			if (radioButton15.Checked)
			{
				ListOptions.Add(assemblertype);
				string assembler = string.Join("", ListOptions.ToArray());
				textBox1.Text = assembler;
			}
			else if (radioButton15.Checked == false)
			{
				ListOptions.Remove(assemblertype);
				string assembler = string.Join("", ListOptions.ToArray());
				textBox1.Text = assembler;
			}
		}
	}
}
