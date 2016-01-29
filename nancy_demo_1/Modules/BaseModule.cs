using Nancy.Conventions;
using System.Dynamic;
using nancy_demo;
using System.Collections.Generic;
using System;

namespace nancy_demo.Modules
{
    public class BaseModule : Nancy.NancyModule
    {
        enum state : byte
        {
            red = 1,
            green,
            blue = red,
            black
        }

        struct statelist
        {
            public state sa;
            private string name;
        }
        class MyClass
        {
            public int val;
            public static int vfun() { return 1; }
        }
        struct myStruct
        {
            public int val;
        }




        int[] arr = { 1, 2, 3, 4, 5, 6, 7 };


        int[,] h = new int[3, 4];

        double[,] h2 = { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 1, 2, 3, 4 } };

        int[][] intArray;
        private dynamic Model = null;
        protected dynamic model
        {
            get
            {
                if (Model == null)
                    Model = new ExpandoObject();
                return Model;
            }
            set
            {
                Model = value;
            }
        }
        public BaseModule() : base()
        {
            Dictionary<string, string> dic = new Dictionary<string, string>{{"1","A"}, {"2","B"}};
            Bootstrapper bt = new Bootstrapper();
            bt.Dispose();
            state xs;
            xs = state.red;
            xs.ToString();
            statelist s;
            s.sa = xs;

            int[] array = new int[5] { 1, 2, 3, 4, 5 };

            h = new int[,] { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 1, 2, 3, 4 } };

            intArray = new int[2][];
            intArray = new int[2][] { new int[] { 1, 2, 3 }, new int[] { 2, 3, 4 } };

            intArray[0] = new int[5];
            intArray[1] = new int[4];

            int[][] intArray2 = { new int[] { 1, 2, 3 }, new int[] { 2, 3, 4 } };

            string arrayStr = "";
            foreach (int[] item in intArray2)
            {
                foreach (int i in item)
                {
                    arrayStr += i + ".";
                }
            }

            MyClass objectA = new MyClass();
            MyClass objectB = new MyClass();

            MyClass.vfun();

            objectA.val = 10;
            objectB.val = 20;
            myStruct structA = new myStruct();
            myStruct structB = new myStruct();
            structA.val = 30;
            structB.val = 40;
            string obstr = objectA.val + "." + objectB.val + "." + structA.val + "." + structB.val;

            ViewsModel.UserInfo ui = (ViewsModel.UserInfo)new ViewsModel.UserInfo().installUser(new ViewsModel.UserInfo() { Age = 27, Gender = "girl", Name = "xx" });



        }
        public BaseModule(string modelPath) : base(modelPath)
        {
        }
        //public class CustomBootstrapper : DefaultNancyBootstrapper
        //{
        //    protected override void ApplicationStartup(TinyIoCContainer container, IPipelines pipelines)
        //    {
        //        string a=container.ToString();
        //        pipelines.BeforeRequest = new Nancy.BeforePipeline() {

        //        };
        //        // your customization goes here
        //    }
        //}
        //private dynamic Model = null;
        //protected dynamic model
        //{
        //    get
        //    {
        //        if (Model == null)
        //            Model = new ExpandoObject();
        //        return Model;
        //    }
        //    set
        //    {
        //        Model = value;
        //    }
        //}

        //public BaseModule()
        //{
        //    Get["/"] = paramters =>
        //    {
        //        Person Person = new Person { name = "null data", age = paramters.value };
        //        model.Person = Person;
        //        //return View["/Home", model];
        //        return Response.AsJson(Person);
        //    };
        //    Get[@"/(?<value>[a-zA-Z0-9]*)"] = paramters =>
        //    {
        //        Person Person = new Person { name = paramters.value, age = paramters.value };
        //        model.Person = Person;
        //        return View["/Home", model];
        //    };
        //    //photo views list
        //    Post["/post"] = paramters =>
        //    {
        //        Person Person = this.Bind<Person>();
        //        model.Person = Person;
        //        return "1";
        //    };
        //    //ever photo detail
        //    Get["/photo/{aaa}"] = paramters =>
        //    {
        //        return paramters.aaa;
        //    };

        //    Get["/photo/{value}/addcomment"] = paramters =>
        //    {
        //        return "";
        //    };
        //}
        //public class Person
        //{
        //    public string name { get; set; }
        //    public string age { get; set; }
        //}
        //public class ccc
        //{
        //    public string MyProperty { get; set; }
        //}
    }


}