using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiApp.Models;

namespace WebApiApp.Controllers
{
    public class DefaultController : ApiController
    {

		[HttpPost]
		[ActionName("AddSwistek")]
		public int PostSwistek(Swistek swistek)
		{
			int maxId = Mock.Lista.Max(e => e.Id);
			swistek.Id = maxId+1;
			Mock.Lista.Add(swistek);
			ResponseMessage(new HttpResponseMessage() { StatusCode = HttpStatusCode.OK});
			return swistek.Id;
		}

		[HttpGet]
		[ActionName("getAllSwistek")]
		public IEnumerable<Swistek> GetAll()
		{
			return Mock.Lista;
		}

		[HttpGet]
		[ActionName("GetSwistekById")]
		public Swistek GetOne(int Id)
		{
			return Mock.Lista.FirstOrDefault(e => e.Id==Id);
		}
	}
}
