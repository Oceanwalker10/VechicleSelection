using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VechicleSelection
{
	// to view xml file, use view order program
	static class Program
	{
		// store the collection of user inputs
		public static List<Vehicle> datas = new List<Vehicle>();

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Control.ReadVehicles("../../vehicles.xml");
			Control.ReadFromStorage("../../Order.xml");
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new VehicleForm());

		}
	}
}
