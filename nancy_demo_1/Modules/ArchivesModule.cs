using Nancy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace nancy_demo.Modules
{
    public class ArchivesModule : BaseModule
    {
        public ArchivesModule() : base("/archives")
        {
            Get[""] = _ =>
            {
                return "archives null";
            };
            Get[@"/(?<year>[0-9]*)/(?<month>[0-9]*)", (ctx) => ctx.Request.Form.remember] = paramater =>
            {
                return string.Format("{0}.{1}", paramater.year, paramater.month);
            };
            Get[@"/(?<year>[0-9]*)"] = paramater =>
            {
                return string.Format("{0}", paramater.year);
            };

        }
    }
}