using System.Web.Mvc;

namespace WS.Federation.Samples.RelyingParty.WebApi.App_Start
{
	public class FilterConfig
	{
		public static void RegisterGlobalFilters(GlobalFilterCollection filters)
		{
			filters.Add(new HandleErrorAttribute());
		}
	}
}