using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AWWW_lab1_gr2.Models
{
    public class Article
    {
        public int Id {get;set;}
        public string Title {get;set;}
        public string Content {get;set;}
        public DateTime CreationDate {get;set;}
    }
}