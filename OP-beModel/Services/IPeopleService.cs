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
        //Shared
        IEnumerable<Person> GetAll();
        IEnumerable<Person> GetPeopleById(long id);
        IEnumerable<Person> GetPeopleByFirstName(string firstname);
        IEnumerable<Person> GetPeopleByLastName(string lastName);
        IEnumerable<Person> GetPeopleByFullName(string firstname, string lastname);
        IEnumerable<Person> GetPeopleByDateOfBirth(string dateOfBirth);
        IEnumerable<Person> GetPeopleByAddress(string address);
        IEnumerable<Person> GetPeopleByCity(string city);
        IEnumerable<Person> GetPeopleByEmail(string email);
        IEnumerable<Person> GetPeopleByPhoneNumber(string phoneNumber);

        //Users only
        IEnumerable<User> GetUsers();
        IEnumerable<User> GetUsersByGender(string gender);

        //Admin only
    }
}
