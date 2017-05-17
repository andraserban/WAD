using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;



namespace WADserver
{
    public class OptionsOverwriteFilter:ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            base.OnActionExecuting(filterContext);
            if (filterContext.HttpContext.Request.HttpMethod.CompareTo("OPTIONS") == 0)
            { 
                filterContext.HttpContext.Response.StatusCode = 200;
            }
        }

        public override void OnResultExecuting(ResultExecutingContext filterContext)
        {
            base.OnResultExecuting(filterContext);
            if (filterContext.HttpContext.Request.HttpMethod.CompareTo("OPTIONS") == 0)
            {
                filterContext.HttpContext.Response.StatusCode = 200;
            }
        }

    }
}