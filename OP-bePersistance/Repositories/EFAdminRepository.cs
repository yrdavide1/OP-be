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

        public Administrator? FindByUsername(string username)
        {
            var admins = GetAll().ToList();
            Administrator admin = new();

            foreach(var a in admins)
            {
                if (a.GetType().GetProperty("Username").GetValue(a).ToString() == username) admin = a;
            }

            return admin; 
        }
    }
}
