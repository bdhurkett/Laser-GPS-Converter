using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Laser_GPS_Converter
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Form1());
		}
	}

	class metadata
	{
		string name = "";
		string desc = "";
		string author = "";
		string keywords = "";
		string url = "";
		string email = "";
		string authorurl = "";

		public metadata()
		{
		}

		public metadata(string n, string d, string a, string k, string u, string e, string au)
		{
			name = n;
			desc = d;
			author = a;
			keywords = k;
			url = u;
			email = e;
			authorurl = au;
		}
	}
}
