using Nancy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace nancy_demo.Modules
{
    public class RootModule : BaseModule
    {
        public RootModule() : base()
        {
            //Get[@"/(?<value>[0-9]*)"] = p =>
            //{
            //    return "数字||空：" + p.value;
            //};
            //Get[@"/(?<value>[a-zA-Z]+)"] = p =>
            //{
            //    return "字母：" + p.value;
            //};
            //Get[@"/(?<value>[a-zA-Z0-9]+)"] = p =>
            //{
            //    return Response.AsRedirect("/1");
            //};
        }
    }
}