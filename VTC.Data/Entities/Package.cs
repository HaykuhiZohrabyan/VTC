using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VTC.Data.Entities
{
    public class Package:Entity
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public virtual ICollection<Level> Levels { get; set; }
    }
}
