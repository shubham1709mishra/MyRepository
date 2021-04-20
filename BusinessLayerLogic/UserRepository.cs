using ApiApplication.Models;
using DataAccessLayer;
using IBusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayerLogic
{
    public class UserRepository : IUserRepository
    {
        private UserData objUserData;
        public UserRepository()
        {
            objUserData = new UserData();
        }
        public IEnumerable<string> GetUserDetails(int userId)
        {
            IEnumerable<User> list = objUserData.GetAllUsers();
            IEnumerable<string> details = list.Where(x=>x.UserId==userId).Select(f => new List<string>() { f.UserName, f.EmailId }).SelectMany(item => item).Distinct();
            return details;

        }
    }
}
