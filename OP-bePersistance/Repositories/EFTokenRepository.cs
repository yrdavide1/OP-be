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
    public class EFTokenRepository : EFCrudRepository<Token, long>, ITokenRepository
    {
        public EFTokenRepository(OPbeContext ctx) : base(ctx) { }
    }
}
