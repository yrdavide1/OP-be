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
        User? GetUserById(long id);
        User? CustomFilter(string field, string value);
        User? CreateUser(User u);
        void DeleteUser(long id);
        User UpdateUser(User u);
        User UpdateUserField(long id, string field, string value);

        //Admin only
        IEnumerable<Administrator> GetAdministrators();
        Administrator? GetAdminById(long id);
        Administrator? GetAdminByUsername(string username);
        Administrator? CreateAdministrator(Administrator a);
        void DeleteAdministrator(long id);

        //Token only
        Token? GetTokenById(long id);
    }
}
