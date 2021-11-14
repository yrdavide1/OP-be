using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OP_beModel.Entities
{
    public class Item
    {
        public long Id { get; set; }
        public string? Name { get; set; }
        public string? Size { get; set; }
        public string? ItemType { get; set; }
        public string? Colour { get; set; }
        public string? Fit { get; set; }
        public long ClosetId { get; set; }
        public virtual Closet? Closet { get; set; }
    }
}
