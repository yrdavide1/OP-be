using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OP_beModel.Entities
{
    public class Ticket
    {
        public long Id { get; set; }
        public string? Subject { get; set; }
        public string? Description { get; set; }
        public long UserId { get; set; }
        public User? User { get; set; }
    }
}
