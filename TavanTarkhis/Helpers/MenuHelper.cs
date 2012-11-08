﻿﻿using System.Web.Mvc;
using System.Web.Mvc.Html;

namespace TavanTarkhis.Helpers
{
    public static class MenuHelper
    {
        public static MvcHtmlString MenuLink(
            this HtmlHelper htmlHelper,
            string linkText,
            string actionName,
            string controllerName
            )
        {
            string currentAction = htmlHelper.ViewContext.RouteData.GetRequiredString("action");
            string currentController = htmlHelper.ViewContext.RouteData.GetRequiredString("controller");
            var ulTag = new TagBuilder("li");
            var link = htmlHelper.ActionLink(
                linkText,
                actionName,
                controllerName);
            if (actionName == currentAction && controllerName == currentController)
            {
                ulTag.AddCssClass("active");
            }
            ulTag.InnerHtml = link.ToHtmlString();
            return MvcHtmlString.Create(ulTag.ToString());
        }
    }
}