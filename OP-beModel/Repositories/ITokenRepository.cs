using OP_beModel.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OP_beModel.Repositories
{
    public interface ITokenRepository : ICrudRepository<Token, long>
    {
    }
}
