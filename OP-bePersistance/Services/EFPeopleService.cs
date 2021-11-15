using OP_beContext.EFContext;
using OP_beModel.Entities;
using OP_beModel.Repositories;
using OP_beModel.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OP_beContext.Services
{
    public class EFPeopleService : IPeopleService
    {
        private OPbeContext ctx;
        private IUserRepository userRepo;    
        
        public EFPeopleService(IUserRepository userRepo, OPbeContext ctx)
        {
            this.userRepo = userRepo;
            this.ctx = ctx;
        }

        public IEnumerable<Administrator> GetAdministrators()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<User> GetAll()
        {
            return userRepo.GetAll();
        }

        public IEnumerable<User> GetUsersByAddress(string address)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<User> GetUsersByCity(string city)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<User> GetUsersByDateOfBirth(string dateOfBirth)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<User> GetUsersByEmail(string email)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<User> GetUsersByFirstName(string firstname)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<User> GetUsersByFullName(string firstname, string lastname)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<User> GetUsersByGender(string gender)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<User> GetUsersById(long id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<User> GetUsersByLastName(string lastName)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<User> GetUsersByPhoneNumber(int phoneNumber)
        {
            throw new NotImplementedException();
        }
    }
}
