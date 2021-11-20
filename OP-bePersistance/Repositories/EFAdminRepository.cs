using OP_beContext.EFContext;
using OP_beModel.Entities;
using OP_beModel.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OP_beContext.Repositories
{
    public class EFAdminRepository : EFCrudRepository<Administrator, long>, IAdminRepository
    {
        public EFAdminRepository(OPbeContext ctx) : base(ctx) { }
    }
}
