using Microsoft.EntityFrameworkCore;
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
        private DbSet<User> users;
        private DbSet<Token> tokens;

        public EFUserRepository(OPbeContext ctx) : base(ctx) 
        {
            users = ctx.Users;
            tokens = ctx.Tokens;
        }
        public User CreateUser(User u)
        {
            string newToken = TokenGenerator();
            string now = DateTime.Now.ToString("g");
            var token = new Token(u, newToken, now);
            u.Token = token;
            users.Add(u);
            tokens.Add(token);
            ctx.SaveChanges();

            return u;
        }
        public User? FindByField(string field, string value)
        {
            var allUsers = GetAll().ToList();
            User found = new();

            if (field == "PersonId") return FindById(long.Parse(value));

            foreach(var u in allUsers)
            {
                var props = u.GetType().GetProperties();
                foreach(var prop in props)
                {
                    if (prop.Name == field) 
                    {
                        var propValue = prop.GetValue(u);
                        if(propValue.ToString() == value) found = u;
                    }
                }
            }

            return found;
        }
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
