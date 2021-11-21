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
        private IAdminRepository adminRepo;

        public EFPeopleService(IUserRepository userRepo, IAdminRepository adminRepo, OPbeContext ctx)
        {
            this.userRepo = userRepo;
            this.adminRepo = adminRepo;
            this.ctx = ctx;
        }

        #region USER
        public IEnumerable<User> GetAll()
        {
            return userRepo.GetAll().ToList();
        }

        public User? GetUserById(long id)
        {
            return userRepo.FindById(id);
        }

        public User? CustomFilter(string field, string value)
        {
            return userRepo.FindByField(field, value);
        }

        public User? CreateUser(User u)
        {
            var users = GetAll();
            foreach(var user in users)
            {
                if (user.Username == u.Username || user.Email == u.Email) return null;
            }
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
            User user = userRepo.FindById(id);
            if(field != "PersonId") user.GetType().GetProperty(field).SetValue(user, value, null);
            userRepo.Update(user);
            ctx.SaveChanges();
            return user;
        }
        #endregion

        #region ADMIN
        public IEnumerable<Administrator> GetAdministrators()
        {
            return adminRepo.GetAll().ToList();
        }

        public Administrator? GetAdminById(long id)
        {
            return adminRepo.FindById(id);
        }

        public Administrator? GetAdminByUsername(string username)
        {
            return adminRepo.FindByUsername(username);
        }

        public Administrator? CreateAdministrator(Administrator a)
        {
            var admins = GetAll();
            foreach (var admin in admins)
            {
                if (admin.Username == a.Username) return null;
            }
            a.Token = TokenGenerator();
            adminRepo.Create(a);
            ctx.SaveChanges();
            return a;
        }

        public void DeleteAdministrator(long id)
        {
            adminRepo.Delete(id);
            ctx.SaveChanges();
        }
        #endregion
        private static string TokenGenerator()
        {
            string allChar = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789!?.-_@";
            Random random = new Random();
            string resultToken = new string(
               Enumerable.Repeat(allChar, 8)
               .Select(token => token[random.Next(token.Length)]).ToArray());

            return resultToken.ToString();
        }

    }
}
