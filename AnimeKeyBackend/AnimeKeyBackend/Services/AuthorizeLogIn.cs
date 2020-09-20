using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace AnimeKeyBackend.Services
{
    public class AuthorizeLogIn : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if (AppSession.IsArabic == AppSession.IsEngligh == AppSession.IsIndonesia == false)
            {
                AppSession.IsEngligh = true;
            }
            if (AppSession.CurrentUser == null)
                filterContext.Result = new RedirectResult("~/Account/LogIn");
        }
    }
}
