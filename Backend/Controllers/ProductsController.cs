using System.Linq;
using System.Web.Http;
using Backend.Models;

namespace Backend.Controllers
{
    public class ProductsController : ApiController
    {
        public IHttpActionResult Get()
        {
            return Ok(WebApiApplication.Products);
        }

        public IHttpActionResult Get(int id)
        {
            if (WebApiApplication.Products.ElementAtOrDefault(id) == null)
                return NotFound();
            return Ok(WebApiApplication.Products[id]);
        }

        public IHttpActionResult Post([FromBody] Product product)
        {
            if (product == null || !ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            WebApiApplication.Products.Add(product);
            return Ok();
        }

        public IHttpActionResult Put(int id, [FromBody] Product product)
        {
            if (product == null || !ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            if (WebApiApplication.Products.ElementAtOrDefault(id) == null)
                return NotFound();
            WebApiApplication.Products.Insert(id, product);
            return Ok();
        }

        public IHttpActionResult Delete(int id)
        {
            if (WebApiApplication.Products.ElementAtOrDefault(id) == null)
                return NotFound();
            WebApiApplication.Products.RemoveAt(id);
            return Ok();
        }
    }
}
