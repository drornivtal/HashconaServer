using Hashchona.BL;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Hashchona.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        // GET: api/<UsersController>
        [HttpGet]
        public IEnumerable<User> Get()
        {
            User user = new User();
            return user.ReadAllUsers();
        }

        [HttpGet]
        [Route("GetSpecificUser")]
        public User GetSpecificUser(string phoneNum)
        {
            User user = new User();
            return user.ReadUser(phoneNum);
        }

        // GET api/<UsersController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<UsersController>
        [HttpPost]
        public int Post([FromBody] User user, int communityId)
        {
            int numEffected = user.Insert(communityId);
            return numEffected;
        }

        // PUT api/<UsersController>/5
        [HttpPut]
        [Route("UpdateUserDetails")]
        public IActionResult Put(User user)
        {
            int res = user.UpdateUserDetails();
            if (res == 0)
            {
                return NotFound("Failed to update details,Try again!");
            }
            else
                return Ok(res);
        }

       
        // PUT api/<UsersController>/5
        [HttpPut] 
        [Route("UpdateUserApproval")]
        public IActionResult Put(int userId, int communityId, string approvalStatus)
        {
            User user = new User();
            int res = user.UpdateUserApprovalStatus(userId, communityId, approvalStatus);
            if (res == 0)
            {
                return NotFound("Failed to update Status,Try again!");
            }
            else
                return Ok(res);
        }

        // DELETE api/<UsersController>/5
        [HttpDelete]
        [Route("DeleteUserForGood")]
        public int Delete(string phoneNum)
        {
            User user = new User();
            return user.DeleteForGood(phoneNum);
        }

        [HttpPost]
        [Route("Login")]
        public User Login([FromBody] UserLogin userLogin)
        {
            User resUser = new User();
            User userR = new User();

            return resUser.Login(userLogin.PhoneNum, userLogin.Password, userLogin.CommunityID);
            //return resUser.Login(phoneNum, password, communityId);

            //if (userR.PhoneNum == null)
            //{
            //    return NotFound("The user is not registered in the system,try again!");
            //}
            //else
               // return Ok(userR);
        }
        //public IActionResult Login([FromBody] string phoneNum, string password, int communityId)
        //{
        //    User resUser = new User();
        //    User userR = new User();

        //    userR = resUser.Login(phoneNum, password, communityId);

        //    //if (userR.PhoneNum == null)
        //    //{
        //    //    return NotFound("The user is not registered in the system,try again!");
        //    //}
        //    //else
        //        return Ok(userR);
        //}
    }
}
