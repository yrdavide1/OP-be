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
    public class EFUserRepository : EFCrudRepository<User, long >, IUserRepository
    {
        public EFUserRepository(OPbeContext ctx) : base(ctx) { }

        public IEnumerable<User> FindByField(string field, string value)
        {
            var allUsers = GetAll().ToList<User>();
            List<User> filteredUsers = new List<User>();

            if (field == "Id") return FindById(long.Parse(field));

            foreach(var u in allUsers)
            {
                var props = u.GetType().GetProperties();
                foreach(var prop in props)
                {
                    if (prop.Name == field) 
                    {
                        var propValue = prop.GetValue(u);
                        if(propValue.ToString() == value) filteredUsers.Add(u);
                    }
                }
            }

            return filteredUsers;
        }
    }
}
