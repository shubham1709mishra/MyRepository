using System.Collections.Generic;

namespace IBusinessLogic
{
    public interface IUserRepository
    {
        IEnumerable<string> GetUserDetails(int userId);
    }
}
