using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OP_beModel.Entities
{
    public class Person
    {
        public long PersonId { get; set; }
        public string? Firstname { get; set; }
        public string? Lastname { get; set; }
        public string? FullName { get; set; }
        public string? DateOfBirth { get; set; }
        public string? Address { get; set; }
        public string? City { get; set; }
        public string? Email { get; set; }
        public int PhoneNumber { get; set; }
    }
}
