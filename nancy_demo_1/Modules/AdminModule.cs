using Nancy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace nancy_demo.Modules
{
    public class AdminModule : BaseModule
    {
        public AdminModule() : base("/admin")
        {
            //Get[""] = paramater =>
            //{
            //    return "admin null";
            //};
            Post["/login"] = paramater =>
            {
                //return Response.AsRedirect("/login");
                return "login";
            };
            Get["/out"] = paramater =>
            {
                //return Response.AsRedirect("/out");
                return "out";
            };
        }
    }
}