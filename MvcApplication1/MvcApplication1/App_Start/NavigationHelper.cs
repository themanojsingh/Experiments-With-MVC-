﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc.Html;
using System.Web.Mvc;

namespace MvcApplication1.App_Start
{
    public static class NavigationHelper
    {
        public static MvcHtmlString MenuLink(this System.Web.Mvc.HtmlHelper helper,
    string text, string action, string controller)
        {
            var routeData = helper.ViewContext.RouteData.Values;
            var currentController = routeData["controller"];
            var currentAction = routeData["action"];

            if (String.Equals(action, currentAction as string,
                      StringComparison.OrdinalIgnoreCase)
                &&
               String.Equals(controller, currentController as string,
                       StringComparison.OrdinalIgnoreCase))
            {
                return helper.ActionLink(
                    text, action, controller, null,
                    new { @class = "currentMenuItem" }
                    );
            }
            return helper.ActionLink(text, action, controller);
        }
    }
}