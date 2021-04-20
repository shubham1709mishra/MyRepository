using BusinessLayerLogic;
using System.Collections.Generic;
using System.Web.Http;

namespace ApiApplication.Controllers
{
    public class UserController : ApiController
    {
        private UserRepository userRepository;
        public UserController()
        {
            userRepository = new UserRepository();
        }

        // GET api/user/101
        public IEnumerable<string> GetDetails(int id)
        {
            IEnumerable<string> userDetails = userRepository.GetUserDetails(id);
            return userDetails;
        }
    }
}
