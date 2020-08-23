namespace VechicleSelection
{
	partial class VehicleForm
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
			this.modelLabel = new System.Windows.Forms.Label();
			this.submit = new System.Windows.Forms.Button();
			this.engineBox = new System.Windows.Forms.ListBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.vehicleBox = new System.Windows.Forms.ComboBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.engineLabel = new System.Windows.Forms.Label();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.exteriorColorBox = new System.Windows.Forms.ComboBox();
			this.exteriorColorLabel = new System.Windows.Forms.Label();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.espTrimLevel = new System.Windows.Forms.RadioButton();
			this.trimLevelLabel = new System.Windows.Forms.Label();
			this.zTrimLevel = new System.Windows.Forms.RadioButton();
			this.dTrimLevel = new System.Windows.Forms.RadioButton();
			this.xTrimLevel = new System.Windows.Forms.RadioButton();
			this.groupBox5 = new System.Windows.Forms.GroupBox();
			this.upgrade9 = new System.Windows.Forms.CheckBox();
			this.trimOptionLebel = new System.Windows.Forms.Label();
			this.upgrade8 = new System.Windows.Forms.CheckBox();
			this.upgrade1 = new System.Windows.Forms.CheckBox();
			this.upgrade4 = new System.Windows.Forms.CheckBox();
			this.upgrade3 = new System.Windows.Forms.CheckBox();
			this.upgrade7 = new System.Windows.Forms.CheckBox();
			this.upgrade5 = new System.Windows.Forms.CheckBox();
			this.upgrade2 = new System.Windows.Forms.CheckBox();
			this.upgrade6 = new System.Windows.Forms.CheckBox();
			this.groupBox6 = new System.Windows.Forms.GroupBox();
			this.interiorColorLabel = new System.Windows.Forms.Label();
			this.interiorColorBox = new System.Windows.Forms.ComboBox();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.title = new System.Windows.Forms.Label();
			this.getDateLabel = new System.Windows.Forms.Label();
			this.getDate = new System.Windows.Forms.DateTimePicker();
			this.getAddress = new System.Windows.Forms.TextBox();
			this.getLName = new System.Windows.Forms.TextBox();
			this.getAddressLabel = new System.Windows.Forms.Label();
			this.getLNameLabel = new System.Windows.Forms.Label();
			this.getFName = new System.Windows.Forms.TextBox();
			this.getFNameLabel = new System.Windows.Forms.Label();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.tabPage4 = new System.Windows.Forms.TabPage();
			this.addOrder = new System.Windows.Forms.Button();
			this.nextTab = new System.Windows.Forms.Button();
			this.backTab = new System.Windows.Forms.Button();
			this.progressBar1 = new System.Windows.Forms.ProgressBar();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.groupBox5.SuspendLayout();
			this.groupBox6.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.tabPage3.SuspendLayout();
			this.tabPage4.SuspendLayout();
			this.SuspendLayout();
			// 
			// modelLabel
			// 
			this.modelLabel.AutoEllipsis = true;
			this.modelLabel.AutoSize = true;
			this.modelLabel.Location = new System.Drawing.Point(5, 18);
			this.modelLabel.Name = "modelLabel";
			this.modelLabel.Size = new System.Drawing.Size(256, 17);
			this.modelLabel.TabIndex = 1;
			this.modelLabel.Text = "1. Choose models of vehicles available:";
			// 
			// submit
			// 
			this.submit.Location = new System.Drawing.Point(9, 124);
			this.submit.Margin = new System.Windows.Forms.Padding(4);
			this.submit.Name = "submit";
			this.submit.Size = new System.Drawing.Size(100, 28);
			this.submit.TabIndex = 3;
			this.submit.Text = "Review";
			this.submit.UseVisualStyleBackColor = true;
			this.submit.Click += new System.EventHandler(this.submit_Click);
			// 
			// engineBox
			// 
			this.engineBox.FormattingEnabled = true;
			this.engineBox.ItemHeight = 16;
			this.engineBox.Location = new System.Drawing.Point(9, 49);
			this.engineBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.engineBox.Name = "engineBox";
			this.engineBox.Size = new System.Drawing.Size(296, 116);
			this.engineBox.TabIndex = 4;
			this.engineBox.SelectedIndexChanged += new System.EventHandler(this.engineBox_SelectedIndexChanged);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.vehicleBox);
			this.groupBox1.Controls.Add(this.modelLabel);
			this.groupBox1.Location = new System.Drawing.Point(6, 4);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.groupBox1.Size = new System.Drawing.Size(322, 93);
			this.groupBox1.TabIndex = 6;
			this.groupBox1.TabStop = false;
			this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
			// 
			// vehicleBox
			// 
			this.vehicleBox.FormattingEnabled = true;
			this.vehicleBox.Location = new System.Drawing.Point(22, 48);
			this.vehicleBox.Name = "vehicleBox";
			this.vehicleBox.Size = new System.Drawing.Size(121, 24);
			this.vehicleBox.TabIndex = 2;
			this.vehicleBox.SelectedIndexChanged += new System.EventHandler(this.vehicleBox_SelectedIndexChanged);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.engineLabel);
			this.groupBox2.Controls.Add(this.engineBox);
			this.groupBox2.Location = new System.Drawing.Point(6, 101);
			this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.groupBox2.Size = new System.Drawing.Size(322, 170);
			this.groupBox2.TabIndex = 7;
			this.groupBox2.TabStop = false;
			this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
			// 
			// engineLabel
			// 
			this.engineLabel.AutoSize = true;
			this.engineLabel.Location = new System.Drawing.Point(5, 18);
			this.engineLabel.Name = "engineLabel";
			this.engineLabel.Size = new System.Drawing.Size(242, 17);
			this.engineLabel.TabIndex = 5;
			this.engineLabel.Text = "2. The follwing engines are available:";
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.exteriorColorBox);
			this.groupBox3.Controls.Add(this.exteriorColorLabel);
			this.groupBox3.Location = new System.Drawing.Point(6, 285);
			this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.groupBox3.Size = new System.Drawing.Size(325, 109);
			this.groupBox3.TabIndex = 8;
			this.groupBox3.TabStop = false;
			this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
			// 
			// exteriorColorBox
			// 
			this.exteriorColorBox.FormattingEnabled = true;
			this.exteriorColorBox.Location = new System.Drawing.Point(9, 68);
			this.exteriorColorBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.exteriorColorBox.Name = "exteriorColorBox";
			this.exteriorColorBox.Size = new System.Drawing.Size(108, 24);
			this.exteriorColorBox.TabIndex = 10;
			this.exteriorColorBox.SelectedIndexChanged += new System.EventHandler(this.exteriorColorBox_SelectedIndexChanged);
			// 
			// exteriorColorLabel
			// 
			this.exteriorColorLabel.AutoSize = true;
			this.exteriorColorLabel.CausesValidation = false;
			this.exteriorColorLabel.Location = new System.Drawing.Point(5, 27);
			this.exteriorColorLabel.Name = "exteriorColorLabel";
			this.exteriorColorLabel.Size = new System.Drawing.Size(209, 34);
			this.exteriorColorLabel.TabIndex = 9;
			this.exteriorColorLabel.Text = "3. Choose the following exterior \r\ncolor options for your vehicle:";
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.espTrimLevel);
			this.groupBox4.Controls.Add(this.trimLevelLabel);
			this.groupBox4.Controls.Add(this.zTrimLevel);
			this.groupBox4.Controls.Add(this.dTrimLevel);
			this.groupBox4.Controls.Add(this.xTrimLevel);
			this.groupBox4.Location = new System.Drawing.Point(8, 4);
			this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.groupBox4.Size = new System.Drawing.Size(222, 149);
			this.groupBox4.TabIndex = 9;
			this.groupBox4.TabStop = false;
			this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
			// 
			// espTrimLevel
			// 
			this.espTrimLevel.AutoSize = true;
			this.espTrimLevel.Location = new System.Drawing.Point(9, 116);
			this.espTrimLevel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.espTrimLevel.Name = "espTrimLevel";
			this.espTrimLevel.Size = new System.Drawing.Size(126, 21);
			this.espTrimLevel.TabIndex = 13;
			this.espTrimLevel.TabStop = true;
			this.espTrimLevel.Text = "ESP Trim Level";
			this.espTrimLevel.UseVisualStyleBackColor = true;
			this.espTrimLevel.CheckedChanged += new System.EventHandler(this.espTrimLevel_CheckedChanged);
			// 
			// trimLevelLabel
			// 
			this.trimLevelLabel.AutoSize = true;
			this.trimLevelLabel.Location = new System.Drawing.Point(5, 18);
			this.trimLevelLabel.Name = "trimLevelLabel";
			this.trimLevelLabel.Size = new System.Drawing.Size(212, 17);
			this.trimLevelLabel.TabIndex = 10;
			this.trimLevelLabel.Text = "4. Chose the trim level you want:";
			// 
			// zTrimLevel
			// 
			this.zTrimLevel.AutoSize = true;
			this.zTrimLevel.Location = new System.Drawing.Point(9, 92);
			this.zTrimLevel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.zTrimLevel.Name = "zTrimLevel";
			this.zTrimLevel.Size = new System.Drawing.Size(108, 21);
			this.zTrimLevel.TabIndex = 12;
			this.zTrimLevel.TabStop = true;
			this.zTrimLevel.Text = "Z Trim Level";
			this.zTrimLevel.UseVisualStyleBackColor = true;
			this.zTrimLevel.CheckedChanged += new System.EventHandler(this.zTrimLevel_CheckedChanged);
			// 
			// dTrimLevel
			// 
			this.dTrimLevel.AutoSize = true;
			this.dTrimLevel.Location = new System.Drawing.Point(9, 44);
			this.dTrimLevel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dTrimLevel.Name = "dTrimLevel";
			this.dTrimLevel.Size = new System.Drawing.Size(109, 21);
			this.dTrimLevel.TabIndex = 10;
			this.dTrimLevel.TabStop = true;
			this.dTrimLevel.Text = "D Trim Level";
			this.dTrimLevel.UseVisualStyleBackColor = true;
			this.dTrimLevel.CheckedChanged += new System.EventHandler(this.dTrimLevel_CheckedChanged);
			// 
			// xTrimLevel
			// 
			this.xTrimLevel.AutoSize = true;
			this.xTrimLevel.Location = new System.Drawing.Point(9, 68);
			this.xTrimLevel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.xTrimLevel.Name = "xTrimLevel";
			this.xTrimLevel.Size = new System.Drawing.Size(108, 21);
			this.xTrimLevel.TabIndex = 11;
			this.xTrimLevel.TabStop = true;
			this.xTrimLevel.Text = "X Trim Level";
			this.xTrimLevel.UseVisualStyleBackColor = true;
			this.xTrimLevel.CheckedChanged += new System.EventHandler(this.xTrimLevel_CheckedChanged);
			// 
			// groupBox5
			// 
			this.groupBox5.Controls.Add(this.upgrade9);
			this.groupBox5.Controls.Add(this.trimOptionLebel);
			this.groupBox5.Controls.Add(this.upgrade8);
			this.groupBox5.Controls.Add(this.upgrade1);
			this.groupBox5.Controls.Add(this.upgrade4);
			this.groupBox5.Controls.Add(this.upgrade3);
			this.groupBox5.Controls.Add(this.upgrade7);
			this.groupBox5.Controls.Add(this.upgrade5);
			this.groupBox5.Controls.Add(this.upgrade2);
			this.groupBox5.Controls.Add(this.upgrade6);
			this.groupBox5.Location = new System.Drawing.Point(8, 157);
			this.groupBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.groupBox5.Name = "groupBox5";
			this.groupBox5.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.groupBox5.Size = new System.Drawing.Size(344, 256);
			this.groupBox5.TabIndex = 10;
			this.groupBox5.TabStop = false;
			this.groupBox5.Enter += new System.EventHandler(this.groupBox5_Enter);
			// 
			// upgrade9
			// 
			this.upgrade9.AutoSize = true;
			this.upgrade9.Location = new System.Drawing.Point(15, 222);
			this.upgrade9.Name = "upgrade9";
			this.upgrade9.Size = new System.Drawing.Size(156, 21);
			this.upgrade9.TabIndex = 11;
			this.upgrade9.Text = "Clearcoat Protector ";
			this.upgrade9.UseVisualStyleBackColor = true;
			// 
			// trimOptionLebel
			// 
			this.trimOptionLebel.AutoSize = true;
			this.trimOptionLebel.Location = new System.Drawing.Point(13, 18);
			this.trimOptionLebel.Name = "trimOptionLebel";
			this.trimOptionLebel.Size = new System.Drawing.Size(173, 34);
			this.trimOptionLebel.TabIndex = 11;
			this.trimOptionLebel.Text = "5. Any other upgrade you \r\nwould like to have:";
			// 
			// upgrade8
			// 
			this.upgrade8.AutoSize = true;
			this.upgrade8.Location = new System.Drawing.Point(112, 196);
			this.upgrade8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.upgrade8.Name = "upgrade8";
			this.upgrade8.Size = new System.Drawing.Size(162, 21);
			this.upgrade8.TabIndex = 18;
			this.upgrade8.Text = "Heated/cooled Seats";
			this.upgrade8.UseVisualStyleBackColor = true;
			// 
			// upgrade1
			// 
			this.upgrade1.AutoSize = true;
			this.upgrade1.Location = new System.Drawing.Point(15, 54);
			this.upgrade1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.upgrade1.Name = "upgrade1";
			this.upgrade1.Size = new System.Drawing.Size(110, 21);
			this.upgrade1.TabIndex = 11;
			this.upgrade1.Text = "Cloth Interior";
			this.upgrade1.UseVisualStyleBackColor = true;
			this.upgrade1.CheckedChanged += new System.EventHandler(this.upgrade1_CheckedChanged);
			// 
			// upgrade4
			// 
			this.upgrade4.AutoSize = true;
			this.upgrade4.Location = new System.Drawing.Point(174, 79);
			this.upgrade4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.upgrade4.Name = "upgrade4";
			this.upgrade4.Size = new System.Drawing.Size(161, 21);
			this.upgrade4.TabIndex = 14;
			this.upgrade4.Text = "Premium 17\" Wheels";
			this.upgrade4.UseVisualStyleBackColor = true;
			this.upgrade4.CheckedChanged += new System.EventHandler(this.upgrade4_CheckedChanged);
			// 
			// upgrade3
			// 
			this.upgrade3.AutoSize = true;
			this.upgrade3.Location = new System.Drawing.Point(174, 54);
			this.upgrade3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.upgrade3.Name = "upgrade3";
			this.upgrade3.Size = new System.Drawing.Size(164, 21);
			this.upgrade3.TabIndex = 13;
			this.upgrade3.Text = "Standard 16\" Wheels";
			this.upgrade3.UseVisualStyleBackColor = true;
			this.upgrade3.CheckedChanged += new System.EventHandler(this.upgrade3_CheckedChanged);
			// 
			// upgrade7
			// 
			this.upgrade7.AutoSize = true;
			this.upgrade7.Location = new System.Drawing.Point(15, 196);
			this.upgrade7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.upgrade7.Name = "upgrade7";
			this.upgrade7.Size = new System.Drawing.Size(89, 21);
			this.upgrade7.TabIndex = 17;
			this.upgrade7.Text = "Sun Roof";
			this.upgrade7.UseVisualStyleBackColor = true;
			// 
			// upgrade5
			// 
			this.upgrade5.AutoSize = true;
			this.upgrade5.Location = new System.Drawing.Point(15, 122);
			this.upgrade5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.upgrade5.Name = "upgrade5";
			this.upgrade5.Size = new System.Drawing.Size(129, 21);
			this.upgrade5.TabIndex = 15;
			this.upgrade5.Text = "Standard Radio";
			this.upgrade5.UseVisualStyleBackColor = true;
			this.upgrade5.CheckedChanged += new System.EventHandler(this.upgrade5_CheckedChanged);
			// 
			// upgrade2
			// 
			this.upgrade2.AutoSize = true;
			this.upgrade2.Location = new System.Drawing.Point(15, 79);
			this.upgrade2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.upgrade2.Name = "upgrade2";
			this.upgrade2.Size = new System.Drawing.Size(127, 21);
			this.upgrade2.TabIndex = 12;
			this.upgrade2.Text = "Leather Interior";
			this.upgrade2.UseVisualStyleBackColor = true;
			this.upgrade2.CheckedChanged += new System.EventHandler(this.upgrade2_CheckedChanged);
			// 
			// upgrade6
			// 
			this.upgrade6.AutoSize = true;
			this.upgrade6.Location = new System.Drawing.Point(15, 147);
			this.upgrade6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.upgrade6.Name = "upgrade6";
			this.upgrade6.Size = new System.Drawing.Size(126, 21);
			this.upgrade6.TabIndex = 16;
			this.upgrade6.Text = "Premium Radio";
			this.upgrade6.UseVisualStyleBackColor = true;
			this.upgrade6.CheckedChanged += new System.EventHandler(this.upgrade6_CheckedChanged);
			// 
			// groupBox6
			// 
			this.groupBox6.Controls.Add(this.interiorColorLabel);
			this.groupBox6.Controls.Add(this.interiorColorBox);
			this.groupBox6.Location = new System.Drawing.Point(8, 4);
			this.groupBox6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.groupBox6.Name = "groupBox6";
			this.groupBox6.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.groupBox6.Size = new System.Drawing.Size(222, 93);
			this.groupBox6.TabIndex = 20;
			this.groupBox6.TabStop = false;
			this.groupBox6.Enter += new System.EventHandler(this.groupBox6_Enter);
			// 
			// interiorColorLabel
			// 
			this.interiorColorLabel.AutoSize = true;
			this.interiorColorLabel.Location = new System.Drawing.Point(13, 18);
			this.interiorColorLabel.Name = "interiorColorLabel";
			this.interiorColorLabel.Size = new System.Drawing.Size(183, 17);
			this.interiorColorLabel.TabIndex = 21;
			this.interiorColorLabel.Text = "6. Choose the interior color:";
			// 
			// interiorColorBox
			// 
			this.interiorColorBox.FormattingEnabled = true;
			this.interiorColorBox.Location = new System.Drawing.Point(17, 39);
			this.interiorColorBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.interiorColorBox.Name = "interiorColorBox";
			this.interiorColorBox.Size = new System.Drawing.Size(108, 24);
			this.interiorColorBox.TabIndex = 21;
			this.interiorColorBox.SelectedIndexChanged += new System.EventHandler(this.interiorColorBox_SelectedIndexChanged);
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Controls.Add(this.tabPage3);
			this.tabControl1.Controls.Add(this.tabPage4);
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
			this.tabControl1.Location = new System.Drawing.Point(0, 0);
			this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(415, 462);
			this.tabControl1.TabIndex = 21;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.title);
			this.tabPage1.Controls.Add(this.getDateLabel);
			this.tabPage1.Controls.Add(this.getDate);
			this.tabPage1.Controls.Add(this.getAddress);
			this.tabPage1.Controls.Add(this.getLName);
			this.tabPage1.Controls.Add(this.getAddressLabel);
			this.tabPage1.Controls.Add(this.getLNameLabel);
			this.tabPage1.Controls.Add(this.getFName);
			this.tabPage1.Controls.Add(this.getFNameLabel);
			this.tabPage1.Location = new System.Drawing.Point(4, 25);
			this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tabPage1.Size = new System.Drawing.Size(407, 433);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "tabPage1";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// title
			// 
			this.title.AutoSize = true;
			this.title.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.title.Location = new System.Drawing.Point(34, 25);
			this.title.Name = "title";
			this.title.Size = new System.Drawing.Size(326, 33);
			this.title.TabIndex = 8;
			this.title.Text = "Vehicle Purchase Form";
			// 
			// getDateLabel
			// 
			this.getDateLabel.AutoSize = true;
			this.getDateLabel.Location = new System.Drawing.Point(8, 245);
			this.getDateLabel.Name = "getDateLabel";
			this.getDateLabel.Size = new System.Drawing.Size(166, 17);
			this.getDateLabel.TabIndex = 7;
			this.getDateLabel.Text = "Requested Delivery Date";
			// 
			// getDate
			// 
			this.getDate.Location = new System.Drawing.Point(8, 274);
			this.getDate.Name = "getDate";
			this.getDate.Size = new System.Drawing.Size(200, 22);
			this.getDate.TabIndex = 6;
			this.getDate.ValueChanged += new System.EventHandler(this.getDate_ValueChanged);
			// 
			// getAddress
			// 
			this.getAddress.Location = new System.Drawing.Point(98, 174);
			this.getAddress.Name = "getAddress";
			this.getAddress.Size = new System.Drawing.Size(262, 22);
			this.getAddress.TabIndex = 5;
			this.getAddress.TextChanged += new System.EventHandler(this.getAddress_TextChanged);
			// 
			// getLName
			// 
			this.getLName.Location = new System.Drawing.Point(98, 134);
			this.getLName.Name = "getLName";
			this.getLName.Size = new System.Drawing.Size(135, 22);
			this.getLName.TabIndex = 4;
			this.getLName.TextChanged += new System.EventHandler(this.getLName_TextChanged);
			// 
			// getAddressLabel
			// 
			this.getAddressLabel.AutoSize = true;
			this.getAddressLabel.Location = new System.Drawing.Point(8, 174);
			this.getAddressLabel.Name = "getAddressLabel";
			this.getAddressLabel.Size = new System.Drawing.Size(68, 17);
			this.getAddressLabel.TabIndex = 3;
			this.getAddressLabel.Text = "Address: ";
			// 
			// getLNameLabel
			// 
			this.getLNameLabel.AutoSize = true;
			this.getLNameLabel.Location = new System.Drawing.Point(8, 134);
			this.getLNameLabel.Name = "getLNameLabel";
			this.getLNameLabel.Size = new System.Drawing.Size(84, 17);
			this.getLNameLabel.TabIndex = 2;
			this.getLNameLabel.Text = "Last Name: ";
			// 
			// getFName
			// 
			this.getFName.Location = new System.Drawing.Point(98, 97);
			this.getFName.Name = "getFName";
			this.getFName.Size = new System.Drawing.Size(135, 22);
			this.getFName.TabIndex = 1;
			this.getFName.TextChanged += new System.EventHandler(this.getFName_TextChanged);
			// 
			// getFNameLabel
			// 
			this.getFNameLabel.AutoSize = true;
			this.getFNameLabel.Location = new System.Drawing.Point(8, 97);
			this.getFNameLabel.Name = "getFNameLabel";
			this.getFNameLabel.Size = new System.Drawing.Size(84, 17);
			this.getFNameLabel.TabIndex = 0;
			this.getFNameLabel.Text = "First Name: ";
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.groupBox1);
			this.tabPage2.Controls.Add(this.groupBox3);
			this.tabPage2.Controls.Add(this.groupBox2);
			this.tabPage2.Location = new System.Drawing.Point(4, 25);
			this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tabPage2.Size = new System.Drawing.Size(407, 433);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "tabPage2";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// tabPage3
			// 
			this.tabPage3.Controls.Add(this.groupBox5);
			this.tabPage3.Controls.Add(this.groupBox4);
			this.tabPage3.Location = new System.Drawing.Point(4, 25);
			this.tabPage3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tabPage3.Size = new System.Drawing.Size(407, 433);
			this.tabPage3.TabIndex = 2;
			this.tabPage3.Text = "tabPage3";
			this.tabPage3.UseVisualStyleBackColor = true;
			// 
			// tabPage4
			// 
			this.tabPage4.Controls.Add(this.addOrder);
			this.tabPage4.Controls.Add(this.submit);
			this.tabPage4.Controls.Add(this.groupBox6);
			this.tabPage4.Location = new System.Drawing.Point(4, 25);
			this.tabPage4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tabPage4.Name = "tabPage4";
			this.tabPage4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tabPage4.Size = new System.Drawing.Size(407, 433);
			this.tabPage4.TabIndex = 3;
			this.tabPage4.Text = "tabPage4";
			this.tabPage4.UseVisualStyleBackColor = true;
			// 
			// addOrder
			// 
			this.addOrder.BackColor = System.Drawing.Color.Transparent;
			this.addOrder.Location = new System.Drawing.Point(9, 172);
			this.addOrder.Name = "addOrder";
			this.addOrder.Size = new System.Drawing.Size(155, 32);
			this.addOrder.TabIndex = 21;
			this.addOrder.Text = "Add Another Vehicle";
			this.addOrder.UseVisualStyleBackColor = false;
			this.addOrder.Visible = false;
			this.addOrder.Click += new System.EventHandler(this.addOrder_Click);
			// 
			// nextTab
			// 
			this.nextTab.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.nextTab.Location = new System.Drawing.Point(334, 495);
			this.nextTab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.nextTab.Name = "nextTab";
			this.nextTab.Size = new System.Drawing.Size(77, 28);
			this.nextTab.TabIndex = 22;
			this.nextTab.Text = "Next";
			this.nextTab.UseVisualStyleBackColor = false;
			this.nextTab.Click += new System.EventHandler(this.nextTab_Click);
			// 
			// backTab
			// 
			this.backTab.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.backTab.Location = new System.Drawing.Point(4, 495);
			this.backTab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.backTab.Name = "backTab";
			this.backTab.Size = new System.Drawing.Size(60, 28);
			this.backTab.TabIndex = 23;
			this.backTab.Text = "Back";
			this.backTab.UseVisualStyleBackColor = false;
			this.backTab.Visible = false;
			this.backTab.Click += new System.EventHandler(this.backTab_Click);
			// 
			// progressBar1
			// 
			this.progressBar1.Dock = System.Windows.Forms.DockStyle.Top;
			this.progressBar1.Location = new System.Drawing.Point(0, 462);
			this.progressBar1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.progressBar1.Name = "progressBar1";
			this.progressBar1.Size = new System.Drawing.Size(415, 24);
			this.progressBar1.TabIndex = 24;
			// 
			// VehicleForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(415, 600);
			this.Controls.Add(this.progressBar1);
			this.Controls.Add(this.backTab);
			this.Controls.Add(this.nextTab);
			this.Controls.Add(this.tabControl1);
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "VehicleForm";
			this.Text = "Vehicle Purchase";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.groupBox4.ResumeLayout(false);
			this.groupBox4.PerformLayout();
			this.groupBox5.ResumeLayout(false);
			this.groupBox5.PerformLayout();
			this.groupBox6.ResumeLayout(false);
			this.groupBox6.PerformLayout();
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			this.tabPage2.ResumeLayout(false);
			this.tabPage3.ResumeLayout(false);
			this.tabPage4.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Label modelLabel;
		private System.Windows.Forms.Button submit;
		private System.Windows.Forms.ListBox engineBox;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label engineLabel;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Label exteriorColorLabel;
		private System.Windows.Forms.ComboBox exteriorColorBox;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.Label trimLevelLabel;
		private System.Windows.Forms.RadioButton espTrimLevel;
		private System.Windows.Forms.RadioButton zTrimLevel;
		private System.Windows.Forms.RadioButton dTrimLevel;
		private System.Windows.Forms.RadioButton xTrimLevel;
		private System.Windows.Forms.GroupBox groupBox5;
		private System.Windows.Forms.Label trimOptionLebel;
		private System.Windows.Forms.CheckBox upgrade8;
		private System.Windows.Forms.CheckBox upgrade7;
		private System.Windows.Forms.CheckBox upgrade1;
		private System.Windows.Forms.CheckBox upgrade6;
		private System.Windows.Forms.CheckBox upgrade2;
		private System.Windows.Forms.CheckBox upgrade5;
		private System.Windows.Forms.CheckBox upgrade3;
		private System.Windows.Forms.CheckBox upgrade4;
		private System.Windows.Forms.GroupBox groupBox6;
		private System.Windows.Forms.Label interiorColorLabel;
		private System.Windows.Forms.ComboBox interiorColorBox;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.TabPage tabPage3;
		private System.Windows.Forms.TabPage tabPage4;
		private System.Windows.Forms.Button nextTab;
		private System.Windows.Forms.Button backTab;
		private System.Windows.Forms.ProgressBar progressBar1;
		private System.Windows.Forms.ComboBox vehicleBox;
		private System.Windows.Forms.Label getFNameLabel;
		private System.Windows.Forms.Label getAddressLabel;
		private System.Windows.Forms.Label getLNameLabel;
		private System.Windows.Forms.TextBox getFName;
		private System.Windows.Forms.TextBox getLName;
		private System.Windows.Forms.TextBox getAddress;
		private System.Windows.Forms.DateTimePicker getDate;
		private System.Windows.Forms.Label title;
		private System.Windows.Forms.Label getDateLabel;
		private System.Windows.Forms.CheckBox upgrade9;
		private System.Windows.Forms.Button addOrder;
	}
}

