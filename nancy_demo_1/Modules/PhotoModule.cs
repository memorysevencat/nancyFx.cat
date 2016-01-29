using Nancy;
using Nancy.ModelBinding;
using Nancy.Routing.Constraints;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace nancy_demo.Modules
{
    public class PhotoModule : BaseModule
    {
        public PhotoModule() : base("/photo")
        {
            Get["/1p"] = paramater =>
            {
                result r = new result();
                r.identiy = true;
                List<ViewsModel.User> l = new List<ViewsModel.User>();
                ViewsModel.User u = new ViewsModel.User();
                u.passWord = "cat";
                u.userName = "cat";
                l.Add(u);
                r.entify = l;
                return Response.AsJson(r);
            };
            Get["/test/test"] = paramater =>
            {
                string[] x = new string[2];
                x[1] = "1";
                if (x[0] != null|| x[1] != null)
                    return "1";
                else return "0";

            };
            Get["/2p"] = paramater =>
            {
                return View["Home"];
            };
            Get["/login/{value}"] = paramater =>
            {
                model.user = new ViewsModel.User { userName = "7cat", passWord = "BOY" };
                model.news = new ViewsModel.News { title = "标题", content = "内容" };
                return View["Home", model];
                //return paramater.value;
            };
            Get["/post/{value}", runAsync: true] = async (paramter, token) =>
            {
                //token.
                await DoWork();
                return "post" + paramter.value;
            };
            Get["/int/{value:int}"] = parameters =>
            {
                return "Value " + parameters.value + " is an integer.";
            };
            Get["/profile/{value:email}"] = parameters =>
            {
                return "Value " + parameters.value + " is an e-mail address.";
            };
            Get["/login", (cqtx) => !cqtx.Request.Form.remember] = _ =>
            {
                return "Handling code when remember is true!";
            };
            Get["/bind"] = parameters =>
            {
                string userName = new ViewsModel.User().installUser(new ViewsModel.User()).userName;
                return View["/Home"];
            };
            Post["/bind1"] = parameters =>
            {
                ViewsModel.User user1 = this.Bind();
                var user2 = this.Bind<ViewsModel.User>();
                var user3 = this.BindTo(new ViewsModel.User());
                //backlist
                var user4 = this.Bind<ViewsModel.User>("Gender");
                var user5 = this.Bind<ViewsModel.User>(u => u.userName);
                return View["/Home", user5];
            };
            Post["/bind2"] = parameters =>
            {
                List<ViewsModel.User> user1 = this.Bind<List<ViewsModel.User>>();
                var user2 = this.Bind<List<ViewsModel.User>>();
                foreach (var item in user2)
                {
                    ViewsModel.User u = item;
                }
                var user3 = this.BindTo(new List<ViewsModel.User>());
                //backlist
                var user4 = this.Bind<List<ViewsModel.User>>("Gender");
                var user5 = this.Bind<List<ViewsModel.User>>(u => new ViewsModel.User().userName);

                return View["/Home", user5];
            };

        }

        static async Task DoWork()
        {
            await Task.Delay(10);

        }

    }
    public class result
    {

        public Boolean identiy { get; set; }
        public List<ViewsModel.User> entify { get; set; }
    }
}