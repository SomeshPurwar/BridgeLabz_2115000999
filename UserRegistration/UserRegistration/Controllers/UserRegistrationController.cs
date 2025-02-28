using System.Net;
using BusinessLayer.Service;
using Microsoft.AspNetCore.Mvc;

namespace UserRegistration.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserRegistrationController : ControllerBase
    {
        private UserRegistrationBL _userRegistrationBL;
        public UserRegistrationController() 
        {
            _userRegistrationBL = new UserRegistrationBL();
        }

        



        [HttpGet]
        public string Get()
        {
            
            string response = _userRegistrationBL.registrationBL("root", "root");
            return response;

        }
    }
}
