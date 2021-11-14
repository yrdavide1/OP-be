using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OP_beModel.Entities
{
    public class User : Person
    {
        public string? Gender { get; set; }
        public bool? IsUser { get; set; }
        public virtual Closet? Closet { get; set; }
        public virtual ICollection<Ticket>? Ticket { get; set; }
        public virtual ICollection<Report>? Reports { get; set; }
    }
}
