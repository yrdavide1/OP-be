using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OP_beModel.Entities
{
    public class Token
    {
        public long Id { get; set; }
        public virtual User? User { get; set; }
        public string? SessionToken { get; set; }
        public string? LastCallDateTime { get; set; }

        public Token() { }
        public Token(User user, string sessionToken, string lastCallDateTime)
        {
            User = user;
            SessionToken = sessionToken;
            LastCallDateTime = lastCallDateTime;
        }
    }
}
