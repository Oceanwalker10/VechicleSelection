using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace VechicleSelection
{
	class Control
	{
		// store data from the xml
		public static List<Model> models = new List<Model>();

		// store data from the pervious file
		public static List<Vehicle> db = new List<Vehicle>();

		public static void ReadVehicles(string filename)
		{
			XmlSerializer serializer = new XmlSerializer(typeof(Model[]));
			FileStream fs = new FileStream(filename, FileMode.Open);
			Model[] vehicles;
			vehicles = (Model[])serializer.Deserialize(fs);
			models.AddRange(vehicles);
		}

		public static void ReadFromStorage(string filename)
		{
			XmlSerializer serializer = new XmlSerializer(typeof(Vehicle[]));
			FileStream fs = new FileStream(filename, FileMode.Open);
			Vehicle[] vehicles;
			vehicles = (Vehicle[])serializer.Deserialize(fs);
			db.AddRange(vehicles);
			fs.Close();
		}

		//CreateVehicles("../../Order.xml", models.ToArray());
		public static void CreateVehicles(string filename, Vehicle[] vehicles, bool append = false)
		{
			// Create an instance of the XmlSerializer class;
			// specify the type of object to serialize.
			XmlSerializer serializer = new XmlSerializer(typeof(Vehicle[]));
			using (TextWriter writer = new StreamWriter(filename, append))
			{
				// Serialize the vehicles, and close the TextWriter.
				serializer.Serialize(writer, vehicles);
			}
		}
	}
}

