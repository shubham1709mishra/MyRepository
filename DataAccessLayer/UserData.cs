using ApiApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class UserData
    {
        List<User> userList = new List<User>();

        public IEnumerable<User> GetAllUsers()
        {
            userList.Add(new User { UserId = 101, UserName = "Swapna Mishra", EmailId = "swapna.mishra@gmail.com" });
            userList.Add(new User { UserId = 102, UserName = "Shubham Mishra", EmailId = "shubham.mishra@gmail.com" });
            userList.Add(new User { UserId = 103, UserName = "Ram Kumar", EmailId = "ram.kumar@gmail.com" });
            userList.Add(new User { UserId = 104, UserName = "chaithanya surendran", EmailId = "chaithanya.surendran@gmail.com" });
            return userList;
        }
    }
}
