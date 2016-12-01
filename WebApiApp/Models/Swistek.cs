using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiApp.Models
{
	public class Swistek
	{
		public int Id { get; set; }
		public string Data { get; set; }
		public double Kwota { get; set; }
		public double Litry { get; set; }
	}
}