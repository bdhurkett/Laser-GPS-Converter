namespace Laser_GPS_Converter
{
	partial class Form1
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.btnLoad = new System.Windows.Forms.Button();
			this.listTracks = new System.Windows.Forms.ListBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.txtAuthorURL = new System.Windows.Forms.TextBox();
			this.txtEmail = new System.Windows.Forms.TextBox();
			this.txtURL = new System.Windows.Forms.TextBox();
			this.txtKeywords = new System.Windows.Forms.TextBox();
			this.txtAuthor = new System.Windows.Forms.TextBox();
			this.txtDesc = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtName = new System.Windows.Forms.TextBox();
			this.txtHovertip = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btnExport = new System.Windows.Forms.Button();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
			this.label8 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.textBox1);
			this.groupBox1.Controls.Add(this.btnLoad);
			this.groupBox1.Controls.Add(this.listTracks);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(200, 302);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Track List";
			// 
			// textBox1
			// 
			this.textBox1.Enabled = false;
			this.textBox1.Location = new System.Drawing.Point(6, 176);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(188, 91);
			this.textBox1.TabIndex = 2;
			// 
			// btnLoad
			// 
			this.btnLoad.Location = new System.Drawing.Point(6, 273);
			this.btnLoad.Name = "btnLoad";
			this.btnLoad.Size = new System.Drawing.Size(75, 23);
			this.btnLoad.TabIndex = 1;
			this.btnLoad.Text = "Load...";
			this.btnLoad.UseVisualStyleBackColor = true;
			this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
			// 
			// listTracks
			// 
			this.listTracks.AllowDrop = true;
			this.listTracks.FormattingEnabled = true;
			this.listTracks.IntegralHeight = false;
			this.listTracks.Location = new System.Drawing.Point(6, 19);
			this.listTracks.Name = "listTracks";
			this.listTracks.ScrollAlwaysVisible = true;
			this.listTracks.Size = new System.Drawing.Size(188, 155);
			this.listTracks.TabIndex = 0;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.txtAuthorURL);
			this.groupBox2.Controls.Add(this.txtEmail);
			this.groupBox2.Controls.Add(this.txtURL);
			this.groupBox2.Controls.Add(this.txtKeywords);
			this.groupBox2.Controls.Add(this.txtAuthor);
			this.groupBox2.Controls.Add(this.txtDesc);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Controls.Add(this.label7);
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Controls.Add(this.txtName);
			this.groupBox2.Controls.Add(this.txtHovertip);
			this.groupBox2.Controls.Add(this.label1);
			this.groupBox2.Location = new System.Drawing.Point(218, 12);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(318, 247);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Optional Metadata";
			// 
			// txtAuthorURL
			// 
			this.txtAuthorURL.Location = new System.Drawing.Point(76, 181);
			this.txtAuthorURL.Name = "txtAuthorURL";
			this.txtAuthorURL.Size = new System.Drawing.Size(236, 20);
			this.txtAuthorURL.TabIndex = 15;
			// 
			// txtEmail
			// 
			this.txtEmail.Location = new System.Drawing.Point(76, 154);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(236, 20);
			this.txtEmail.TabIndex = 14;
			// 
			// txtURL
			// 
			this.txtURL.Location = new System.Drawing.Point(76, 127);
			this.txtURL.Name = "txtURL";
			this.txtURL.Size = new System.Drawing.Size(236, 20);
			this.txtURL.TabIndex = 13;
			// 
			// txtKeywords
			// 
			this.txtKeywords.Location = new System.Drawing.Point(76, 100);
			this.txtKeywords.Name = "txtKeywords";
			this.txtKeywords.Size = new System.Drawing.Size(236, 20);
			this.txtKeywords.TabIndex = 12;
			// 
			// txtAuthor
			// 
			this.txtAuthor.Location = new System.Drawing.Point(76, 73);
			this.txtAuthor.Name = "txtAuthor";
			this.txtAuthor.Size = new System.Drawing.Size(236, 20);
			this.txtAuthor.TabIndex = 11;
			// 
			// txtDesc
			// 
			this.txtDesc.Location = new System.Drawing.Point(76, 46);
			this.txtDesc.Name = "txtDesc";
			this.txtDesc.Size = new System.Drawing.Size(236, 20);
			this.txtDesc.TabIndex = 10;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(7, 184);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(63, 13);
			this.label5.TabIndex = 9;
			this.label5.Text = "Author URL";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(38, 157);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(32, 13);
			this.label6.TabIndex = 8;
			this.label6.Text = "Email";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(41, 130);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(29, 13);
			this.label7.TabIndex = 7;
			this.label7.Text = "URL";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(17, 103);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(53, 13);
			this.label4.TabIndex = 6;
			this.label4.Text = "Keywords";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(32, 76);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(38, 13);
			this.label3.TabIndex = 5;
			this.label3.Text = "Author";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(10, 49);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(60, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "Description";
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(76, 19);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(236, 20);
			this.txtName.TabIndex = 3;
			// 
			// txtHovertip
			// 
			this.txtHovertip.BackColor = System.Drawing.SystemColors.Control;
			this.txtHovertip.Enabled = false;
			this.txtHovertip.Location = new System.Drawing.Point(6, 207);
			this.txtHovertip.Multiline = true;
			this.txtHovertip.Name = "txtHovertip";
			this.txtHovertip.ReadOnly = true;
			this.txtHovertip.Size = new System.Drawing.Size(306, 34);
			this.txtHovertip.TabIndex = 2;
			this.txtHovertip.TabStop = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(35, 22);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(35, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Name";
			// 
			// btnExport
			// 
			this.btnExport.Location = new System.Drawing.Point(461, 291);
			this.btnExport.Name = "btnExport";
			this.btnExport.Size = new System.Drawing.Size(75, 23);
			this.btnExport.TabIndex = 2;
			this.btnExport.Text = "Export...";
			this.btnExport.UseVisualStyleBackColor = true;
			this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.AddExtension = false;
			this.openFileDialog1.FileName = "openFileDialog1";
			this.openFileDialog1.Filter = "Default filename|BridgeMin.dll|Jet Database|*.mdb|All files|*.*";
			this.openFileDialog1.Title = "Select Laser GPS Database";
			// 
			// saveFileDialog1
			// 
			this.saveFileDialog1.DefaultExt = "gpx";
			this.saveFileDialog1.Filter = "GPX file|*.gpx";
			this.saveFileDialog1.Title = "Save As...";
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.DecimalPlaces = 1;
			this.numericUpDown1.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
			this.numericUpDown1.Location = new System.Drawing.Point(416, 266);
			this.numericUpDown1.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
			this.numericUpDown1.Minimum = new decimal(new int[] {
            12,
            0,
            0,
            -2147483648});
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
			this.numericUpDown1.TabIndex = 4;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(305, 268);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(105, 13);
			this.label8.TabIndex = 5;
			this.label8.Text = "Time offset (optional)";
			// 
			// Form1
			// 
			this.AcceptButton = this.btnExport;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(548, 326);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.numericUpDown1);
			this.Controls.Add(this.btnExport);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.Text = "Laser GPS Track Export";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btnLoad;
		private System.Windows.Forms.ListBox listTracks;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.TextBox txtHovertip;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnExport;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txtAuthorURL;
		private System.Windows.Forms.TextBox txtEmail;
		private System.Windows.Forms.TextBox txtURL;
		private System.Windows.Forms.TextBox txtKeywords;
		private System.Windows.Forms.TextBox txtAuthor;
		private System.Windows.Forms.TextBox txtDesc;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.NumericUpDown numericUpDown1;
		private System.Windows.Forms.Label label8;
	}
}

