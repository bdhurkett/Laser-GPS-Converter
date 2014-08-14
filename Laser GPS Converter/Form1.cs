using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Xml;


namespace Laser_GPS_Converter
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			openFileDialog1.InitialDirectory = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86), "Laser GPS");
			openFileDialog1.FileName = "BridgeMin.dll";
		}

		private void btnLoad_Click(object sender, EventArgs e)
		{
			listTracks.Items.Clear();

			DialogResult result = openFileDialog1.ShowDialog();

			//if result = dialogresult.cancel etc
			//for now, assume it's found and openable

			string strAccessConn = @"Provider=Microsoft.JET.OLEDB.4.0;Data Source=" + openFileDialog1.FileName + "; Jet OLEDB:Database Password=danger";

			string strAccessSelect = "SELECT Cnumber,Track_Date,TrackDist FROM TrackPoint1";

			// Create the dataset and add the Categories table to it:
			DataSet myDataSet = new DataSet();
			OleDbConnection myAccessConn = null;
			try
			{
				myAccessConn = new OleDbConnection(strAccessConn);
			}
			catch (Exception ex)
			{
				Console.WriteLine("Error: Failed to create a database connection. \n{0}", ex.Message);
				return;
			}

			try
			{

				OleDbCommand myAccessCommand = new OleDbCommand(strAccessSelect, myAccessConn);
				OleDbDataAdapter myDataAdapter = new OleDbDataAdapter(myAccessCommand);

				myAccessConn.Open();
				myDataAdapter.Fill(myDataSet, "TrackPoint1");

			}
			catch (Exception ex)
			{
				Console.WriteLine("Error: Failed to retrieve the required data from the DataBase.\n{0}", ex.Message);
				return;
			}
			finally
			{
				myAccessConn.Close();
			}

			// A dataset can contain multiple tables, so let's get them
			// all into an array:
			DataTableCollection dta = myDataSet.Tables;
			
			// The next several lines show how to get information on
			// a specific table by name from the dataset:
			//Console.WriteLine("{0} rows in TP table", myDataSet.Tables["TrackPoint1"].Rows.Count);
			// The column info is automatically fetched from the database,
			// so we can read it here:
			//Console.WriteLine("{0} columns in TP table", myDataSet.Tables["TrackPoint1"].Columns.Count);
			DataColumnCollection drc = myDataSet.Tables["TrackPoint1"].Columns;
			foreach (DataColumn dc in drc)
			{
				// Print the column subscript, then the column's name
				// and its data type:
				//Console.WriteLine("Column name[{0}] is {1}, of type {2}", i++, dc.ColumnName, dc.DataType);
			}
			DataRowCollection dra = myDataSet.Tables["TrackPoint1"].Rows;
			foreach (DataRow dr in dra)
			{
				// Print the CategoryID as a subscript, then the CategoryName:
				string l = dr[0] + ": " + dr[1].ToString().TrimEnd(' ') + " (" + Math.Round(Convert.ToDouble(dr[2])/100000,2) + " km)";
				listTracks.Items.Add(l);
			}

		}

		private void btnExport_Click(object sender, EventArgs e)
		{
			metadata m = new metadata(txtName.Text, txtDesc.Text, txtAuthor.Text, txtKeywords.Text, txtURL.Text, txtEmail.Text, txtAuthorURL.Text);

			char[] colon = {':'};
			if (listTracks.SelectedIndex < 0)
				return;
			int t = Convert.ToInt32(listTracks.SelectedItem.ToString().Split(colon)[0]);

			Export(t, m);
		}

		private void Export(int cNumber, metadata Details)
		{
			int year, month, day;
			//int hour, minute, second;
			string[] localstart = listTracks.SelectedItem.ToString().Split(' ');
			string[] localdate = localstart[1].Split('-');
			//string[] localtime = localstart[2].Split(':');

			year = Convert.ToInt32(localdate[0]);
			month = Convert.ToInt32(localdate[1]);
			day = Convert.ToInt32(localdate[2]);
			//hour = Convert.ToInt32(localtime[0]);
			//minute = Convert.ToInt32(localtime[1]);
			//second = Convert.ToInt32(localtime[2]);

			//DateTime d = new DateTime(year, month, day, hour, minute, second);
			DateTime d = new DateTime(year, month, day);
			DateTime UTCd = d.AddHours(Convert.ToDouble(numericUpDown1.Value));

			//select file to save to
			DialogResult result = saveFileDialog1.ShowDialog();
			//if result == ok etc

			//open connection to db
			string strAccessConn = @"Provider=Microsoft.JET.OLEDB.4.0;Data Source=" + openFileDialog1.FileName + "; Jet OLEDB:Database Password=danger";
			string strAccessSelect = "SELECT LongitudeN,LatitudeN,TrackTime,LonSign,LatSign FROM TrackPoint WHERE Cnumber = " + cNumber + " ORDER BY SerNo";

			// Create the dataset and add the Categories table to it:
			DataSet myDataSet = new DataSet();
			OleDbConnection myAccessConn = null;
			try
			{
				myAccessConn = new OleDbConnection(strAccessConn);
			}
			catch (Exception ex)
			{
				Console.WriteLine("Error: Failed to create a database connection. \n{0}", ex.Message);
				return;
			}

			try
			{

				OleDbCommand myAccessCommand = new OleDbCommand(strAccessSelect, myAccessConn);
				OleDbDataAdapter myDataAdapter = new OleDbDataAdapter(myAccessCommand);

				myAccessConn.Open();
				myDataAdapter.Fill(myDataSet, "TrackPoint");

			}
			catch (Exception ex)
			{
				Console.WriteLine("Error: Failed to retrieve the required data from the DataBase.\n{0}", ex.Message);
				return;
			}
			finally
			{
				myAccessConn.Close();
			}

			XmlWriterSettings xs = new XmlWriterSettings();
			//xs.CheckCharacters = false;
			xs.Indent = true;

			XmlWriter writer = XmlWriter.Create(saveFileDialog1.FileName,xs);

			
			writer.WriteStartDocument();

			writer.WriteStartElement("gpx", @"http://www.topografix.com/GPX/1/0");
			//writer.WriteAttributeString("xmlns", @"http://www.topografix.com/GPX/1/0");
			writer.WriteAttributeString("creator", "Laser GPS Converter");
			writer.WriteAttributeString("version", "1.0");
			writer.WriteAttributeString("xsi","xlmns", @"http://www.w3.org/2001/XMLSchema-instance");
			writer.WriteAttributeString("schemaLocation","xsi", @"http://www.topografix.com/GPX/1/0 http://www.topografix.com/GPX/1/0/gpx.xsd");
			
			//assume no metadata for now - skip

			writer.WriteStartElement("trk");

			writer.WriteStartElement("trkseg");


			DataRowCollection dra = myDataSet.Tables["TrackPoint"].Rows;
			foreach (DataRow dr in dra)
			{
				writer.WriteStartElement("trkpt");
				if (dr[4].ToString().Trim().Equals("N"))
					writer.WriteAttributeString("lat", dr[1].ToString());
				else
					writer.WriteAttributeString("lat", "-" + dr[1].ToString());

				if (dr[3].ToString().Trim().Equals("E"))
					writer.WriteAttributeString("lon", dr[0].ToString());
				else
					writer.WriteAttributeString("lon", "-" + dr[0].ToString());

				writer.WriteStartElement("time");

				//dr[2] = 14:48:25, etc
				string[] localtime = dr[2].ToString().Trim().Split(':');
				DateTime localT = UTCd.AddHours(Convert.ToInt32(localtime[0]));
				localT = localT.AddMinutes(Convert.ToInt32(localtime[1]));
				localT = localT.AddSeconds(Convert.ToInt32(localtime[2]));

				writer.WriteString(String.Join("-",localT.Year,localT.Month,localT.Day) + "T" + String.Join(":",localT.Hour,localT.Minute,localT.Second) + "Z");
				writer.WriteEndElement();

				writer.WriteEndElement();
			}

			writer.WriteEndDocument();
			writer.Close();

			//update tracktime to add date from listTracks
			//retrieve timezone setting, convert from number to timezone, update tracktime
			//create gpx file, start xml
			//write metadata to gpx file if necessary
			//retrieve matching datapoints
			//write each to gpx file
			//finish xml
			//close file
		}
	}
}
