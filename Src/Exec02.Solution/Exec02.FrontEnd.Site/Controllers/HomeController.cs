using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Exec02.FrontEnd.Application.News;
using Exec02.FrontEnd.Application.ViewModels;

namespace Exec02.FrontEnd.Site.Controllers
{
	public class HomeController : Controller
	{
		private readonly HotNewsApi _hotNewsApi;

		public HomeController(HotNewsApi hotNewsApi)
		{
			_hotNewsApi = hotNewsApi;
		}
		public ActionResult Index()
		{
			return View();
		}

		public ActionResult _HotNews()
		{
			int maxRows = 5;
			IEnumerable<HotNewsVM> model = _hotNewsApi.GetHotNews(maxRows);

			return PartialView(model);
		}
	}
}