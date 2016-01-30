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
            Get["/out"] = paramater =>
            {
                return View["/signout"];
            };
            Get["/in"] = paramater =>
            {
                return View["/signin"];
            };
            Post["/up"] = _ =>
            {
                List<ViewsModel.User> list = new List<ViewsModel.User>();
                var user = this.Bind<ViewsModel.User>();
                list.Add(user);
                return View["/home", list];
            };
            Post["/in"] = _ =>
            {
                var user = this.Bind<ViewsModel.User>();
                //if (user.userName.Equals("nicat") && user.passWord.Equals("nicat"))
                return View["/index", user];
                //else return View["/home"];

            };
        }
    }
}