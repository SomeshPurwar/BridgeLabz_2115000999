using RepositoryLayer.Service;

namespace BusinessLayer.Service
{
    public class UserRegistrationBL
    {
        private UserRegistrationRL _userRegistrationRL;


        public UserRegistrationBL()
        {
            _userRegistrationRL = new UserRegistrationRL();
        }



        public string registrationBL(string username, string password)
        {

            
            if (isValidUser(username, password))
            {
                return "Login Successfull";
            }

            return "Invalid username or password.";
        }

        public bool isValidUser(string username, string password)
        {
            var (storedUsername, storedPassword) = _userRegistrationRL.registrationRL();
            return username == storedUsername && password == storedPassword;
        }


    }
}
