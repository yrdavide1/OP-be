using OP_beContext.EFContext;
using OP_beModel.Entities;
using OP_beModel.Repositories;
using OP_beModel.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//delegate IEnumerable<User> userSearchRepo(string value);
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

        public IEnumerable<User> GetAll()
        {
            return userRepo.GetAll().ToList();
        }

        public User GetUserById(long id)
        {
            return userRepo.FindById(id).First();
        }

        public IEnumerable<User> CustomFilter(string field, string value)
        {
            return userRepo.FindByField(field, value);
        }

        public User CreateUser(User u)
        {
            userRepo.Create(u);
            ctx.SaveChanges();
            return u;
        }

        public void DeleteUser(long id)
        {
            userRepo.Delete(id);
            ctx.SaveChanges();
        }

        public User UpdateUser(User u)
        {
            userRepo.Update(u);
            ctx.SaveChanges();
            return u;
        }

        public User UpdateUserField(long id, string field, string value)
        {
            var user = userRepo.FindById(id).First();
            if(field != "PersonId") user.GetType().GetProperty(field).SetValue(user, value, null);
            userRepo.Update(user);
            ctx.SaveChanges();
            return user;
        }
    }
}
