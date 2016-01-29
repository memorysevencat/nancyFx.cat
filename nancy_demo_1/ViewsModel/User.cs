using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace nancy_demo.ViewsModel
{
    public interface setUser
    {
        User installUser(User u);
    }

    public class User : setUser
    {
        public string userName { get; set; }
        public string passWord { get; set; }
        public User installUser(User u)
        {
            u.userName = "nicat";
            u.passWord = "nicat";
            return u;
        }
    }


}