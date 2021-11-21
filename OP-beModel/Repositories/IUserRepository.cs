using OP_beModel.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OP_beModel.Repositories
{
    public interface IUserRepository : ICrudRepository<User, long>
    {

        public User? FindByField(string field, string value);
    }
}
