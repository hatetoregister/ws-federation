using System.Web.Mvc;

namespace WS.Federation.Samples.RelyingParty.Mvc.App_Start
{
	public class FilterConfig
	{
		public static void RegisterGlobalFilters(GlobalFilterCollection filters)
		{
			filters.Add(new HandleErrorAttribute());
		}
	}
}