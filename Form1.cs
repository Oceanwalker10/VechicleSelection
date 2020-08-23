using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Zilin(Ian) Chen
 * CS3386
 * 10/24/2019
 * 
 * The user of your program will be able to select from a list of available models, 
 * pick different options available and review their selections at the end. Create 
 * the application using Windows Forms and C#.
 Details

    Modify project 1
        See ConsoleApp3.zip. Inside you will find a file vehicles.xml. That is an XML file with a serialized array of Models. You'll find the Models class in the zip file as well. Your program should take a file like this vehicles.xml and use it to populate the dropdowns on your form. Note, I may send out a new file so don't try and cheat the process and hard-code the values
        The models now have a string array called TrimPrices. Element 0 is the prices for the D trim, 1 for X, 2 for Z and 3 for ESP. Use these to keep track of how much the car costs
            Additionally, the following upgrade prices apply
                Upgrade radio: $300
                Upgrade wheels: $1200
                Sunroof: $895
                Heated Seats: $300
                Clearcoat protector (new option): $545
        When the user is done, give them an overview in a message box (like in project 1). After the box is closed, write the order to a file.
            What you'll probably want to do is create an Order class that holds the values you need. You'll then create an array of orders and write that to the file. Each time an order is created, deserialize the order array from the file, add the new order and then serialize it back to the file (overwrite it).
            Also, you'll need to add the following fields to your form to associate with the order:
                Customer first name
                Customer last name
                Customer address
                Requested delivery date
*/

namespace VechicleSelection
{
	public partial class VehicleForm : Form
	{
		// store user input
		private Vehicle data = new Vehicle();
		private decimal[] trimCost;
		private decimal totalCost;

		// array store the progress bar process
		private byte[] pro = new byte[] {1, 1, 1, 1, 1, 1, 1, 1, 1};


		public VehicleForm()
		{
			InitializeComponent();

			tabControl1.Appearance = TabAppearance.FlatButtons;
			tabControl1.ItemSize = new Size(0, 1);
			tabControl1.SizeMode = TabSizeMode.Fixed;
			progressBar1.Maximum = 9;

		}

		private void Form1_Load(object sender, EventArgs e)
		{
			// the minume availabe delivery date
			getDate.MinDate = DateTime.Today.AddDays(14);

			// populate the model list
			List<string> vehicleList = new List<string>();

			foreach (var items in Control.models)
			{
				vehicleList.Add(items.Name);
			}

			vehicleBox.Items.AddRange(vehicleList.ToArray());
		}

		private void submit_Click(object sender, EventArgs e)
		{

			CalculatetotalCost();

			// Add user entered info into popup window
			upgradeSelected();
			StringBuilder output = new StringBuilder();
			string tmp = string.Join(", ", data.Options);
			output.Append("You Selected:\r\n");
			output.Append("Your Name: " + data.FName + " " + data.LName + "\r\n");
			output.Append("Delivery Address: " + data.DeliveryAddress + "\r\n");
			output.Append("Delivery Date: " + data.DeliveryDate + "\r\n");
			output.Append("Model: " + data.VehicleName + "\r\n");
			output.Append("Engine: " + data.Engines + "\r\n");
			output.Append("Exterior Color: " + data.ExteriorColors + "\r\n");
			output.Append("Trim Level: " + data.TrimLevel + "\r\n");
			output.Append("Upgrade: "+ tmp + "\r\n");
			output.Append("Interior Color: " + data.InteriorColors + "\r\n");
			output.Append("Your total cost is: " + data.Cost + "\r\n");

			string title = "Review";
			string message;
			MessageBoxButtons buttons;
			if (progressBar1.Value < 9){
				output.Append("\r\n You have not complete your form, please go back complete the form.");
				buttons = MessageBoxButtons.OK;
				message = output.ToString();
			}
			else{
				output.Append("\r\n Are you ready to submite?");
				buttons = MessageBoxButtons.YesNo;
				message = output.ToString();
			}
			
			DialogResult result = MessageBox.Show(message, title, buttons);
			if (result == DialogResult.Yes)
			{
				Control.db.Add(data);
				Control.CreateVehicles("../../Order.xml", Control.db.ToArray());
				addOrder.Visible = true;
			}
		}

		private void getFName_TextChanged(object sender, EventArgs e)
		{
			// Update Progress Bar
			progressBar1.Value += pro[0];
			pro[0] = 0;

			data.FName = getFName.Text;
		}

		private void getLName_TextChanged(object sender, EventArgs e)
		{
			// Update Progress Bar
			progressBar1.Value += pro[1];
			pro[1] = 0;

			data.LName = getLName.Text;
		}

		private void getAddress_TextChanged(object sender, EventArgs e)
		{
			// Update Progress Bar
			progressBar1.Value += pro[2];
			pro[2] = 0;

			data.DeliveryAddress = getAddress.Text;
		}

		private void getDate_ValueChanged(object sender, EventArgs e)
		{
			// Update Progress Bar
			progressBar1.Value += pro[3];
			pro[3] = 0;

			data.DeliveryDate = getDate.Value;
		}

		private void vehicleBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			engineBox.Items.Clear();
			engineBox.Items.AddRange(Control.models[vehicleBox.SelectedIndex].AvailableEngines.ToArray());
			exteriorColorBox.Items.Clear();
			exteriorColorBox.Items.AddRange(Control.models[vehicleBox.SelectedIndex].AvailableExteriorColors.ToArray());
			data.VehicleName = vehicleBox.SelectedItem.ToString();
			trimCost = Control.models[vehicleBox.SelectedIndex].TrimPrices;
		}

		private void engineBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (engineBox.SelectedItem != null)
			{
				data.Engines = engineBox.SelectedItem.ToString();
			} else {
				data.Engines = "Nothing selected.";
			}
		}

		private void exteriorColorBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			data.ExteriorColors = exteriorColorBox.SelectedItem.ToString();
		}

		private void dTrimLevel_CheckedChanged(object sender, EventArgs e)
		{
			UncheckUpgrade();

			upgrade1.Checked = true;
			upgrade3.Checked = true;
			upgrade5.Checked = true;

			data.TrimLevel = dTrimLevel.Text;

			// populate cloth interior color drop down menu
			ClothInterior();
		}

		private void xTrimLevel_CheckedChanged(object sender, EventArgs e)
		{
			UncheckUpgrade();

			upgrade1.Checked = true;
			upgrade3.Checked = true;
			upgrade6.Checked = true;

			upgrade5.Enabled = false;
			upgrade6.Enabled = false;

			data.TrimLevel = xTrimLevel.Text;

			// populate cloth interior color drop down menu
			ClothInterior();
		}

		private void zTrimLevel_CheckedChanged(object sender, EventArgs e)
		{
			UncheckUpgrade();

			upgrade2.Checked = true;
			upgrade4.Checked = true;
			upgrade6.Checked = true;

			upgrade1.Enabled = false;
			upgrade2.Enabled = false;
			upgrade3.Enabled = false;
			upgrade4.Enabled = false;
			upgrade5.Enabled = false;
			upgrade6.Enabled = false;

			data.TrimLevel = zTrimLevel.Text;

			// populate leather interior color drop down menu
			LeatherInterior();
		}

		private void espTrimLevel_CheckedChanged(object sender, EventArgs e)
		{
			UncheckUpgrade();
			
			upgrade2.Checked = true;
			upgrade4.Checked = true;
			upgrade6.Checked = true;
			upgrade7.Checked = true;
			upgrade8.Checked = true;

			upgrade1.Enabled = false;
			upgrade2.Enabled = false;
			upgrade3.Enabled = false;
			upgrade4.Enabled = false;
			upgrade5.Enabled = false;
			upgrade6.Enabled = false;
			upgrade7.Enabled = false;
			upgrade8.Enabled = false;

			data.TrimLevel = espTrimLevel.Text;

			// populate leather interior color drop down menu
			LeatherInterior();
		}

		private void interiorColorBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			data.InteriorColors = interiorColorBox.SelectedItem.ToString();
		}

		// rest the upgrade section
		public void UncheckUpgrade()
		{
			upgrade1.Checked = false;
			upgrade2.Checked = false;
			upgrade3.Checked = false;
			upgrade4.Checked = false;
			upgrade5.Checked = false;
			upgrade6.Checked = false;
			upgrade7.Checked = false;
			upgrade8.Checked = false;
			upgrade9.Checked = false;
			upgrade1.Enabled = true;
			upgrade2.Enabled = true;
			upgrade3.Enabled = true;
			upgrade4.Enabled = true;
			upgrade5.Enabled = true;
			upgrade6.Enabled = true;
			upgrade7.Enabled = true;
			upgrade8.Enabled = true;
			upgrade9.Enabled = true;
		}

		private void upgrade1_CheckedChanged(object sender, EventArgs e)
		{
			upgrade2.Checked = !upgrade1.Checked;
			ClothInterior();
		}

		private void upgrade2_CheckedChanged(object sender, EventArgs e)
		{
			upgrade1.Checked = !upgrade2.Checked;
			LeatherInterior();
		}

		private void upgrade3_CheckedChanged(object sender, EventArgs e)
		{
			upgrade4.Checked = !upgrade3.Checked;
		}

		private void upgrade4_CheckedChanged(object sender, EventArgs e)
		{
			upgrade3.Checked = !upgrade4.Checked;
		}

		private void upgrade5_CheckedChanged(object sender, EventArgs e)
		{
			upgrade6.Checked = !upgrade5.Checked;
		}

		private void upgrade6_CheckedChanged(object sender, EventArgs e)
		{
			upgrade5.Checked = !upgrade6.Checked;
		}

		private void ClothInterior()
		{
			interiorColorBox.Items.Clear();
			try{
				interiorColorBox.Items.AddRange(Control.models[vehicleBox.SelectedIndex].AvailableInteriorClothColors.ToArray());
			}
			catch(Exception e){ }
			
		}

		private void LeatherInterior()
		{
			interiorColorBox.Items.Clear();
			try{ 
				interiorColorBox.Items.AddRange(Control.models[vehicleBox.SelectedIndex].AvailableInteriorLeatherColors.ToArray()); 
			}
			catch(Exception e){ }
			
		}

		// gather what user has selected in upgrade area
		private void upgradeSelected()
		{
			if (upgrade1.Checked == true)
			{
				data.Options.Add(upgrade1.Text);
			}
			else
			{
				data.Options.Add(upgrade2.Text);
			}

			if (upgrade3.Checked == true)
			{
				data.Options.Add(upgrade3.Text);
			}
			else
			{
				data.Options.Add(upgrade4.Text);
			}

			if (upgrade5.Checked == true)
			{
				data.Options.Add(upgrade5.Text);
			}
			else
			{
				data.Options.Add(upgrade6.Text);
			}

			if (upgrade7.Checked == true)
			{
				data.Options.Add(upgrade7.Text);
			}


			if (upgrade8.Checked == true)
			{
				data.Options.Add(upgrade8.Text);
			}

		}

		private void nextTab_Click(object sender, EventArgs e)
		{
			if(tabControl1.SelectedIndex <= tabControl1.TabPages.Count)
			{
				tabControl1.SelectedIndex++;
			}

			if(tabControl1.SelectedIndex == tabControl1.TabPages.Count - 1)
			{
				nextTab.Hide();
			} 
			
			if(tabControl1.SelectedIndex > 0)
			{
				backTab.Show();
			}
		}

		private void backTab_Click(object sender, EventArgs e)
		{
			if(tabControl1.SelectedIndex > 0)
			{
				tabControl1.SelectedIndex--;
			}

			if(tabControl1.SelectedIndex == 0)
			{
				backTab.Hide();
				nextTab.Show();
			}

			if(tabControl1.SelectedIndex < 3)
			{
				nextTab.Show();
			}
		}

		/*
		 * Update the progress bar on group boxs
		 */	
		private void groupBox1_Enter(object sender, EventArgs e)
		{
			progressBar1.Value += pro[4];
			pro[4] = 0;
		}

		private void groupBox2_Enter(object sender, EventArgs e)
		{
			progressBar1.Value += pro[5];
			pro[5] = 0;

		}

		private void groupBox3_Enter(object sender, EventArgs e)
		{
			progressBar1.Value += pro[6];
			pro[6] = 0;

		}

		private void groupBox4_Enter(object sender, EventArgs e)
		{
			progressBar1.Value += pro[7];
			pro[7] = 0;

		}

		private void groupBox5_Enter(object sender, EventArgs e)
		{}

		private void groupBox6_Enter(object sender, EventArgs e)
		{
			progressBar1.Value += pro[8];
			pro[8] = 0;

		}

		private void CalculatetotalCost()
		{
			totalCost = 0;
			string trimLevel ="";
			try{
				string checkedTrimLevel = groupBox4.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Name;
				trimLevel = checkedTrimLevel;
			}
			catch(Exception e){ }
					
			switch (trimLevel)
			{
				case "dTrimLevel":
					totalCost = trimCost[0];
					break;
				case "xTrimLevel":
					totalCost = trimCost[1];
					break;
				case "zTrimLevel":
					totalCost = trimCost[2];
					break;
				case "espTrimLevel":
					totalCost = trimCost[3];
					break;
			}

			if(upgrade4.Checked && (trimLevel == "dTrimLevel" || trimLevel == "xTrimLevel"))
			{
				totalCost += 1200;
			}

			if(upgrade6.Checked && trimLevel == "dTrimLevel"){
				totalCost += 300;
			}

			if(upgrade7.Checked && trimLevel != "espTrimLevel")
			{
				totalCost += 895;
			}

			if(upgrade8.Checked && trimLevel != "espTrimLevel")
			{
				totalCost += 300;
			}

			if(upgrade9.Checked){
				totalCost += 545;
			}

			data.Cost = totalCost;
		}

		// rest the form and prepare for new order
		private void addOrder_Click(object sender, EventArgs e)
		{
			VehicleForm NewForm = new VehicleForm();
			NewForm.Show();
			this.Dispose(false);
		}
	}
	
}
