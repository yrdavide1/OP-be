using OP_beModel.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OP_beModel.Services
{
    public interface IPeopleService
    {
        //Users only
        IEnumerable<User> GetAll();
        User GetUserById(long id);
        IEnumerable<User> CustomFilter(string field, string value);
        User CreateUser(User u);
        void DeleteUser(long id);
        User UpdateUser(User u);
        User UpdateUserField(long id, string field, string value);

        //Admin only
    }
}
