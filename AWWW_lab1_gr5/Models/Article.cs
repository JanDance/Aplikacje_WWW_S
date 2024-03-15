using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AWWW_lab1_gr5.Models
{
    public class Article
    {
        public int Id {get; set;}
        public required string Title {get; set;}
        public required string Content {get; set;}
        public DateTime CreationDate {get; set;}

    }
}