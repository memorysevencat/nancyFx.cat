using Nancy.ModelBinding;
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
                return View["/home", userList()];
            };
            Get["/Views/{value}"] = p =>
            {
                return View["/home", userList()];
            };
            Get["/home"] = _ =>
            {
                return View["/home", userList()];
            };
            Get["/home/session"] = _ =>
            {
                List<ViewsModel.User> list = new List<ViewsModel.User>();
                for (int i = 0; i < 4; i++)
                {
                    ViewsModel.User u = new ViewsModel.User();
                    u.userId = i + 1;
                    u.userName = "nicat" + i;
                    u.userAge = i;
                    u.userGender = "boy";
                    u.passWord = "nicat" + i;
                    //u = u.installUser(u);
                    list.Add(u);
                }
                return View["/home", list];
            };
        }
        public static List<ViewsModel.User> userList()
        {
            List<ViewsModel.User> list = new List<ViewsModel.User>();
            for (int i = 0; i < 4; i++)
            {
                ViewsModel.User u = new ViewsModel.User();
                u.userName = "";
                //u = u.installUser(u);
                list.Add(u);
            }
            return list;
        }
    }
}