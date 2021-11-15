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
        public IEnumerable<User> FindByAddress(string address);
        public IEnumerable<User> FindByCity(string city);
        public IEnumerable<User> FindByDateOfBirth(string dateOfBirth);
        public IEnumerable<User> FindByEmail(string email);
        public IEnumerable<User> FindByFirstName(string firstName);
        public IEnumerable<User> FindByLastName(string lastName);
        public IEnumerable<User> FindByFullName(string fullName);
        public IEnumerable<User> FindByGender(string gender);
        public IEnumerable<User> FindByPhoneNumber(int phoneNumber);

    }
}
