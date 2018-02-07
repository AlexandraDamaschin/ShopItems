using ShopItems.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopItems.DAL
{
     public interface IUserRepository : IDisposable
    {
        IEnumerable<User> GetUsers();
        User GetUserByID(int userID);

        void InsertUser(User user);
        void UpdateUser(User user);
        void DeleteUser(int userID);
        void Save();
    }
}
