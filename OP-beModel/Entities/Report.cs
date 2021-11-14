using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OP_beModel.Entities
{
    public class Report
    {
        public long Id { get; set; }
        public virtual ICollection<User>? Users { get; set; }
        public DateTime SnapshotDate { get; set; }
    }
}
