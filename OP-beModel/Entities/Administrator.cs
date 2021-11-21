using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public enum Level
{
    LOW = 1,
    NORMAL = 2,
    HIGH = 3,
    SIZE = 4
}

namespace OP_beModel.Entities
{
    public class Administrator : Person
    {
        public string? Token { get; set; }
        public Level Level { get; set; }
    }
}
