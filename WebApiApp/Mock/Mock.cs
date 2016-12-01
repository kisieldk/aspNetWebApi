using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApiApp.Models;

namespace WebApiApp
{ 
	public static class Mock
	{
		public static IList<Swistek> Lista = new List<Swistek>()
		{
			new Swistek() { Id=1,Data="2015-11-12",Kwota=120.32, Litry=145.02 },
			new Swistek() { Id=2,Data="2015-11-12",Kwota=132, Litry=14.02 },
			new Swistek() { Id=3,Data="2015-11-12",Kwota=1203.2, Litry=150.2 }
		};
	}
}