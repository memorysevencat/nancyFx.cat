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
        public int userId { get; set; }
        public string userName { get; set; }
        public string userGender { get; set; }
        public int userAge { get; set; }
        public string passWord { get; set; }
        public User installUser(User u)
        {
            u.userName = "nicat";
            u.userGender = "boy";
            u.userAge = 25;
            u.passWord = "nicat";
            u.userId = 0;
            return u;
        }
    }


}