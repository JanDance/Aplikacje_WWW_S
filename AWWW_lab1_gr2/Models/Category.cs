using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AWWW_lab1_gr2.Models
{
    public class Category
    {
        public int CategoryId {get; set;}
        public string? Name {get; set;}
        public ICollection<Article>? Articles {get; set;}
    }
}