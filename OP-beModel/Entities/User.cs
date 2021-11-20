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
        public string? Firstname { get; set; }
        public string? Lastname { get; set; }
        public string? DateOfBirth { get; set; }
        public string? Address { get; set; }
        public string? City { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public virtual Closet? Closet { get; set; }
        public virtual ICollection<Ticket>? Ticket { get; set; }
        public virtual ICollection<Report>? Reports { get; set; }
    }
}
