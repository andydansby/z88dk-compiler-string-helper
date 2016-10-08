using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z88dk_compile_options_helper_beta
{
	class Class1
	{

	}


	class zccvariables
	{

		public static string machine = "";
		public static byte mainMenuChoice = 0;

		public static bool restartForm1 = true;

		//public static string machine = "";
		public static bool classicCompiler = false;

		public static bool sdcc_compiler = true;
		

		public bool machine_type_for_floating_point(bool type)
		{
			if (machine == "zx")
			{
				return true;
			}

			else
			{
				return false;
			}
			//return true;
		}








	}









	/*
	public static class zccvariables
	{
		public static string machine = "";
		public static byte mainMenuChoice = 0;

		public static bool restartForm1 = true;

		//public static bool classicCompiler = false;
	}*/






}
