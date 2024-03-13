using System.Net.NetworkInformation;

namespace AWWW_lab1_gr5.Models{
    public class Tag{
        public int Id {get;set;}
        public string Name {get;set;}
        public virtual ICollection<Article> Articles {get;set;}
    }
}