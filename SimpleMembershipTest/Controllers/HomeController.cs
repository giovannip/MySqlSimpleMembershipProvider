using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MySql.Web.Extension.MySql.Web.Security.Tables.Negocio;
using SimpleMembershipTest.Dac;


namespace SimpleMembershipTest.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
            string str = User.Identity.Name;
            using (var db = SimpleMembershipTestDbContext.CreateContext())
            {
                var asd = db.Bancos.ToArray();

                db.Bancos.Add(new Banco() { Nome = "Itau" + str, CriadoEm = DateTime.Now });
                db.SaveChanges();

                var qwe = db.Bancos.ToArray();

                int i = 1 - 5 * 9;

            }

			ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

			return View();
		}

		public ActionResult About()
		{
			ViewBag.Message = "Your app description page.";

			return View();
		}

		public ActionResult Contact()
		{
			ViewBag.Message = "Your contact page.";

			return View();
		}
	}
}
