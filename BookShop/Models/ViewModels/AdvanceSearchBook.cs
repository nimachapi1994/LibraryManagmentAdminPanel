using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookShop.Models.ViewModels
{
    public class AdvanceSearchBook
    {

        public string title { get; set; }
        public string ISBN { get; set; }
        public string Language { get; set; }
        public string Category { get; set; }
        public string Author { get; set; }
        public string Translator { get; set; }
        public string Publisher { get; set; }

        public int[] CategoryId { get; set; }

    }
}
