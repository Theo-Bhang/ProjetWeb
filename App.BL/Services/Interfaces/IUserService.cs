using App.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App.BL
{
    public interface IUserService
    {
        public IEnumerable<User> Get();
        public User Get(int id);
        public User Post(User user);
        public User Put(User user);
        public User Delete(int id);
    }
}