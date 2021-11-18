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
            throw new NotImplementedException();
        }

        public IEnumerable<User> CustomFilter(string field, string value)
        {
            return userRepo.FindByField(field, value);
        }
    }
}
