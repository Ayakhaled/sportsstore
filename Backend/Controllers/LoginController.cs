
using System.Web.Http;
using Backend.Models;

namespace Backend.Controllers
{
    public class LoginController : ApiController
    {
        public IHttpActionResult Post([FromBody] Credentials credentials)
        {
            if (credentials == null || !ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            if (credentials.username == credentials.password)
                return Ok(credentials);
            return BadRequest("Wrong username and or password");
        }
    }
}
