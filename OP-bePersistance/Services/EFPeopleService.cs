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
            return userRepo.GetAll().ToList();
        }

        public IEnumerable<User> GetUsersByAddress(string address)
        {
            return userRepo.FindByAddress(address).ToList();
        }

        public IEnumerable<User> GetUsersByCity(string city)
        {
            return userRepo.FindByCity(city).ToList();
        }

        public IEnumerable<User> GetUsersByDateOfBirth(string dateOfBirth)
        {
            return userRepo.FindByDateOfBirth(dateOfBirth).ToList();
        }

        public IEnumerable<User> GetUsersByEmail(string email)
        {
            return userRepo.FindByEmail(email).ToList();
        }

        public IEnumerable<User> GetUsersByFirstName(string firstName)
        {
            return userRepo.FindByFirstName(firstName).ToList();
        }

        public IEnumerable<User> GetUsersByFullName(string firstname, string lastname)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<User> GetUsersByGender(string gender)
        {
            return userRepo.FindByGender(gender).ToList();
        }

        public User GetUsersById(long id)
        {
            return userRepo.FindById(id);
        }

        public IEnumerable<User> GetUsersByLastName(string lastName)
        {
            return userRepo.FindByLastName(lastName).ToList();
        }

        public IEnumerable<User> GetUsersByPhoneNumber(string phoneNumber)
        {
            return userRepo.FindByPhoneNumber(phoneNumber).ToList();
        }
    }
}
