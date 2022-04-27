using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookShop.Models.ViewModels
{
    public class TreeViewCategory
    {
        public TreeViewCategory()
        {
            SubCategory = new List<TreeViewCategory>();
        }

        public int Category_Id { get; set; }
        public string CategoryName { get; set; }
        public List<TreeViewCategory> SubCategory { get; set; }
    }
}
