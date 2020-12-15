using System.Web;
using System.Web.Mvc;

namespace Exec02.FrontEnd.Site
{
	public class FilterConfig
	{
		public static void RegisterGlobalFilters(GlobalFilterCollection filters)
		{
			filters.Add(new HandleErrorAttribute());
		}
	}
}
