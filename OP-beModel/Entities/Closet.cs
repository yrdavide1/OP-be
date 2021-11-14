using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OP_beModel.Entities
{
    public class Closet
    {
        public long Id { get; set; }
        public string? Name { get; set; }
        public long UserId { get; set; }
        public virtual User? User { get; set; }
        public virtual ICollection<Item>? Items { get; set; }
    }
}
