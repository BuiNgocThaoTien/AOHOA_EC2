﻿using System.Web;
using System.Web.Mvc;

namespace Tuan2_LTW
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
