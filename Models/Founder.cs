using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Organizations.Models
{
    public class Founder
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Company> Companies { get; set; }
        public Founder()
        {
            Companies = new List<Company>();
        }
    }
}