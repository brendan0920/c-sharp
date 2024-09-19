using PrsConsole_DEMO_0918.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrsConsole_DEMO_0918.Db
{
    internal class UserDb
    {
        private bmdbContext dbContext = new();

        //CRUD Methods
        public List<User> GetUsers()
        {
            return dbContext.Users.ToList();
        }

        public User FindUsers(int id)
        {
            return dbContext.Users.Where(u => u.Id == id).FirstOrDefault();
        }

        public void AddUser(User user)
        {
            dbContext.Users.Add(user);
            dbContext.SaveChanges();
        }

        public void UpdateUser(User user)
        {
            dbContext.SaveChanges();
        }

        public void RemoveUser(User user)
        {
            dbContext.Users.Remove(user);
            dbContext.SaveChanges();
        }



    }
}
