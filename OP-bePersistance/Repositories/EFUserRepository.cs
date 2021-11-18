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
            return ctx.Users.Where(u => u.Address == address);
        }

        public IEnumerable<User> FindByCity(string city)
        {
            return ctx.Users.Where(u => u.City == city);
        }

        public IEnumerable<User> FindByDateOfBirth(string dateOfBirth)
        {
            return ctx.Users.Where(u => u.DateOfBirth == dateOfBirth);
        }

        public IEnumerable<User> FindByEmail(string email)
        {
            return ctx.Users.Where(u => u.Email == email);
        }

        public IEnumerable<User> FindByFirstName(string firstName)
        {
            return ctx.Users.Where(u => u.Firstname == firstName);
        }

        public IEnumerable<User> FindByFullName(string fullName)
        {
            return ctx.Users.Where(u => u.FullName == fullName);   
        }

        public IEnumerable<User> FindByGender(string gender)
        {
            return ctx.Users.Where(u => u.Gender == gender);
        }

        public IEnumerable<User> FindByLastName(string lastName)
        {
            return ctx.Users.Where(u => u.Lastname == lastName);
        }

        public IEnumerable<User> FindByPhoneNumber(string phoneNumber)
        {
            return ctx.Users.Where(u => u.PhoneNumber == phoneNumber);
        }
    }
}
