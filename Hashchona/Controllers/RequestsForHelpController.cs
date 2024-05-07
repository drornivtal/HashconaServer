using Hashchona.BL;
using Microsoft.AspNetCore.Mvc;
using System.Reflection;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Hashchona.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RequestsForHelpController : ControllerBase
    {
        // GET: api/<AssimentsController>
        [HttpGet]
        public IEnumerable<RequestForHelp> GetAllActiveReq()
        {
            RequestForHelp assistance = new RequestForHelp();

            return 'w';
        }

        // GET api/<AssimentsController>/5
        [HttpGet]
        [Route("ActiveCategoryReq")]
        public IEnumerable<RequestForHelp> GetAllActiveCategoryReq(int CategoryID)
        {
            RequestForHelp assistance = new RequestForHelp();
            return assistance.readAllActiveCategoryReq(CategoryID);
        }

        // POST api/<AssimentsController>
        [HttpPost]
        public int PostNewReq([FromBody] RequestForHelp request)
        {

            return request.InsertNewReq(request);
        }

        // PUT api/<AssimentsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<AssimentsController>/5
        [HttpDelete("{id}")]
        public int DeleteReq(RequestForHelp request)
        {
            return request.DeleteReq(request);
        }
    }
}
