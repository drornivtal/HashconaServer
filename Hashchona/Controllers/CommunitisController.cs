using Hashchona.BL;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Hashchona.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommunitisController : ControllerBase
    {
        //Get all the communitis
        // GET: api/<CommunitisController>
        [HttpGet]
        public IEnumerable<Community> GetAllCommunities()
        {
            Community community = new Community();
            return community.ReadAllCommunitis();
        }

        // GET api/<CommunitisController>/5
        [HttpGet]
        [Route("ReadApprovedCommunities")]
        public IEnumerable<Community> GetApprovedCommunitis()
        {
            Community community = new Community();
            return community.ReadAllApprovedCommunitis();
        } 

        // GET api/<CommunitisController>/5
        [HttpGet]
        [Route("ReadPendingCommunities")]
        public IEnumerable<Community> GetPendingCommunities()
        {
            Community community = new Community();
            return community.ReadAllPendingCommunities();
        }

        // POST api/<CommunitisController>
        [HttpPost]
        public int Post([FromBody] Community community, string pho)
        {
            User user = new User();
            return community.Insert(user);
        }

        // PUT api/<CommunitisController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CommunitisController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
