using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AWWW_lab1_gr5.Models
{
    public class Author
    {
        public int Id {get; set;}
        public string FirstName {get; set;} = null!;
        public string LastName {get; set;} = null!;
        public virtual ICollection<Article>? Articles {get; set;}
    }
}