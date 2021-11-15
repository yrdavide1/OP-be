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

        public IEnumerable<User> FindByAddress(string address)
        {
            return ctx.Users.Where(u => u.Address.Contains(address));
        }

        public IEnumerable<User> FindByCity(string city)
        {
            return ctx.Users.Where(u => u.City.Contains(city));
        }

        public IEnumerable<User> FindByDateOfBirth(string dateOfBirth)
        {
            return ctx.Users.Where(u => u.DateOfBirth.Contains(dateOfBirth));
        }

        public IEnumerable<User> FindByEmail(string email)
        {
            return ctx.Users.Where(u => u.Email.Contains(email));
        }

        public IEnumerable<User> FindByFirstName(string firstName)
        {
            return ctx.Users.Where(u => u.Firstname.Contains(firstName));
        }

        public IEnumerable<User> FindByFullName(string fullName)
        {
            return ctx.Users.Where(u => u.FullName.Contains(fullName));   
        }

        public IEnumerable<User> FindByGender(string gender)
        {
            return ctx.Users.Where(u => u.Gender.Contains(gender));
        }

        public IEnumerable<User> FindByLastName(string lastName)
        {
            return ctx.Users.Where(u => u.Lastname.Contains(lastName));
        }

        public IEnumerable<User> FindByPhoneNumber(int phoneNumber)
        {
            return ctx.Users.Where(u => u.PhoneNumber == phoneNumber);
        }
    }
}
