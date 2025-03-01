using BusinessLayer.Service;
using Microsoft.AspNetCore.Mvc;
using ModelLayer.DTO;

namespace UserRegistration.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserRegistrationController : ControllerBase
    {
        UserRegistrationBL _userRegistrationBL;

        public UserRegistrationController(UserRegistrationBL userRegistrationBL)
        {
            _userRegistrationBL = userRegistrationBL;

        }

        [HttpGet]
        public string Get()
        {
            return "Server Running....";
        }

        [HttpPost]
        public IActionResult PostData(RegisterDTO user)
        {
            try
            {
                var errors = new List<string>();
                if (string.IsNullOrWhiteSpace(user.firstName)) errors.Add("First name is required");
                if (string.IsNullOrWhiteSpace(user.lastName)) errors.Add("Last name is required");
                if (string.IsNullOrWhiteSpace(user.email)) errors.Add("Email is required");
                else if (!user.email.Contains("@")) errors.Add("Invalid email format");
                if (string.IsNullOrWhiteSpace(user.password)) errors.Add("Password is required");
                else if (user.password.Length < 6) errors.Add("Password must be at least 6 characters long");

                if (errors.Count > 0)
                {
                    return BadRequest(new ResponseModel<List<string>>
                    {
                        Success = false,
                        Message = "Validation failed",
                        Data = errors
                    });
                }
                _userRegistrationBL.RegisterUser(user);
                return Ok(new ResponseModel<RegisterDTO> { Success = true, Message = "Registered Succesfully.", Data = user });
            }
            catch (Exception ex)
            {
                return BadRequest(new ResponseModel<string> { Success = false, Message = "Registered Failed.", Data = ex.Message });
            }
        }


    }
}
