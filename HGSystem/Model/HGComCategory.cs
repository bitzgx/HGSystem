using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
// using System.Threading.Tasks;

namespace HGSystem.Model
{
    public class HGComCategorySubItem
    {
        /*
        protected String label;
        protected int value;
         */
        public String Label { get; protected set; }
        public int Value { get; protected set; }
    }

    public class HGComCategoryItem : HGComCategorySubItem
    {
        // private HGComCategorySubItem[] children;
        public HGComCategorySubItem[] Children { get; set; }
    }

    public class HGComCategory : HGComCategoryItem
    {
        // private HGComCategoryItem[] children;
        public HGComCategoryItem[] Children { get; set; }
    }
}
