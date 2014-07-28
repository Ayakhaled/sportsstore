using System.Linq;
using System.Web.Http;
using Backend.Models;

namespace Backend.Controllers
{
    public class ProductsController : ApiController
    {
        public IHttpActionResult Get()
        {
            return Ok(DataStorage.Products);
        }

        public IHttpActionResult Get(int id)
        {
            if (DataStorage.Products.ElementAtOrDefault(id) == null)
                return NotFound();
            return Ok(DataStorage.Products[id]);
        }

        public IHttpActionResult Post([FromBody] Product product)
        {
            if (product == null || !ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            DataStorage.Products.Add(product);
            return Ok();
        }

        public IHttpActionResult Put(int id, [FromBody] Product product)
        {
            if (product == null || !ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            if (DataStorage.Products.ElementAtOrDefault(id) == null)
                return NotFound();
            DataStorage.Products.Insert(id, product);
            return Ok();
        }

        public IHttpActionResult Delete(int id)
        {
            if (DataStorage.Products.ElementAtOrDefault(id) == null)
                return NotFound();
            DataStorage.Products.RemoveAt(id);
            return Ok();
        }
    }
}
