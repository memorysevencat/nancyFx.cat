using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace nancy_demo.Modules
{
    public class HomeModule : BaseModule
    {
        public HomeModule()
        {
            Get["/"] = p =>
            {

                return View["/home"];
            };
            Get["/Views/{value}"] = p =>
            {
                return View["/home"];
            };
            Get["/home"] = _ =>
            {
                return View["/home"];
            };
        }
    }
}