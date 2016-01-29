using Nancy;
using Nancy.ModelBinding;
using nancy_demo.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace nancy_demo.Modules
{
    public class SignModule : BaseModule
    {
        public SignModule() : base("/sign")
        {
            Get["/up"] = paramater =>
            {
                return View["/signup"];
            };
            Get["/in"] = paramater =>
            {
                return View["/signin"];
            };
            Post["/up"] = _ =>
            {
                var user = this.Bind<ViewsModel.User>();
                return View["/index/signup", user];
            };
            Post["/in"] = _ =>
            {
                var user = this.Bind<ViewsModel.User>();
                if (user.userName.Equals("nicat") && user.passWord.Equals("nicat"))
                    return View["/home", user];
                else return View["/home"];

            };
        }
    }
}