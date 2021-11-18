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
        User GetUsersById(long id);
        IEnumerable<User> GetUsersByFirstName(string firstname);
        IEnumerable<User> GetUsersByLastName(string lastName);
        IEnumerable<User> GetUsersByFullName(string firstname, string lastname);
        IEnumerable<User> GetUsersByDateOfBirth(string dateOfBirth);
        IEnumerable<User> GetUsersByAddress(string address);
        IEnumerable<User> GetUsersByCity(string city);
        IEnumerable<User> GetUsersByEmail(string email);
        IEnumerable<User> GetUsersByPhoneNumber(string phoneNumber);
        IEnumerable<User> GetUsersByGender(string gender);

        //Admin only
        IEnumerable<Administrator> GetAdministrators();
    }
}
