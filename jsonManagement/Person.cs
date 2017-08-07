using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jsonManagement
{
    public class Person
    {
        public class Dog
        {
            public string name { get; set; }
            public string race { get; set; }
        }

        public string name { get; set; }
        public string lastName { get; set; }
        public int age { get; set; }
        public DateTime bithDay { get; set; }
        public string[] phoneNumbers{set;get;}
        public Dog[] dogs { set; get; }
    }
}
