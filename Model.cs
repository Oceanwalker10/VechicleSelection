using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VechicleSelection
{
	[Serializable]
	public class Model
	{
		public string Name { get; set; }
		public string[] AvailableEngines { get; set; }
		public string[] AvailableInteriorClothColors { get; set; }
		public string[] AvailableInteriorLeatherColors { get; set; }
		public string[] AvailableExteriorColors { get; set; }
		public string[] Options { get; set; }
		public decimal[] TrimPrices { get; set; }
	}
}
