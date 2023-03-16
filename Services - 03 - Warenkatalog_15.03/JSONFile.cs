using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services___03___Warenkatalog_15._03
{
    internal class JSONFile
    {
        public class Rootobject
        {
            public Meta meta { get; set; }
            public Products[] products { get; set; }
        }

        public class Meta
        {
            public int count { get; set; }
            public int limit { get; set; }
            public int page { get; set; }
            public string next_url { get; set; }
        }

        public class Products
        {
            public string name { get; set; }
            public string product_url { get; set; }
        }

        public class Productobject
        {
            public string name { get; set; }
            public float price { get; set; }
            public string photo_url { get; set; }
            public string category_url { get; set; }
            public string vendor_url { get; set; }
        }

        public class vendors
        {
            public string name { get; set; }
            public string products_url { get; set; }
        }


        public class Category
        {
            public string name { get; set; }
            public string category_url { get; set; }
        }



    }
}
