using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App.DAL;

namespace App.BL
{
    public class UserService : IUserService
    {
        private readonly BDDContext _BDDContext;

        public UserService(BDDContext BDDContext)
        {
            _BDDContext = BDDContext;
        }

        public IEnumerable<User> Get()
        {
            return _BDDContext.Users;
        }

        public User Get(int id)
        {
            return _BDDContext.Users.SingleOrDefault(x => x.Id == id);
        }

        public User Post(User user)
        {
            _BDDContext.Users.Add(user);
            _BDDContext.SaveChanges();
            return user;
        }

        public User Put(User user)
        {
            _BDDContext.Users.Update(user);
            _BDDContext.SaveChanges();
            return user;
        }

        public User Delete(int id)
        {
            var item = _BDDContext.Users.FirstOrDefault(x => x.Id == id);
            if (item != null)
            {
                _BDDContext.Users.Remove(item);
                _BDDContext.SaveChanges();
                return null;
            }
            return null;
        }
    }
}