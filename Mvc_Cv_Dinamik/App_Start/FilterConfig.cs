﻿using System.Web;
using System.Web.Mvc;

namespace Mvc_Cv_Dinamik
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
