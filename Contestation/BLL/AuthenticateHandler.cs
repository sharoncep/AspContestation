using DAL;
using Entities;

namespace BLL
{
    public class AuthenticateHandler
    {
        dbOperations userDetails = null;

        public AuthenticateHandler()
        {
            userDetails = new dbOperations();
        }

        /// <summary>
        /// Authenticate user
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        /// <param name="rememberUserName"></param>
        /// <returns></returns>
        public authenticateUser getUserDetails(string userName, string password)
        {
            authenticateUser authUser = new authenticateUser();
            authUser = userDetails.getUserDetails(userName);

            if (authUser != null)
            {
                string localUserName = authUser.username;
                string localPassword = authUser.password;
                string role = authUser.role;


                if (userName.Equals(localUserName) && password.Equals(localPassword))
                {
                    return authUser;
                }
                else
                {
                    return null;
                }
            }
            return null;
        }

    }
}
