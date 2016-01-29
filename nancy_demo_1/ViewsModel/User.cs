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
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public int Score { get; set; }
        public User installUser(User u)
        {
            u.Age = 1;
            u.Name = "cat";
            u.Gender = "boy";
            u.Score = 80;
            return u;
        }
    }


}