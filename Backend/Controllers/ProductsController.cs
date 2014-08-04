using System;
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

        public IHttpActionResult Get(Guid id)
        {
            var product = DataStorage.Products.FirstOrDefault(x => x.id == id);
            if (product == default(Product))
                return NotFound();
            return Ok(product);
        }

        public IHttpActionResult Post([FromBody] Product product)
        {
            if (product == null || !ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            product.id = Guid.NewGuid();
            DataStorage.Products.Add(product);
            return Ok(product);
        }

        public IHttpActionResult Put(Guid id, [FromBody] Product product)
        {
            if (product == null || !ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var oldProduct = DataStorage.Products.FirstOrDefault(x => x.id == id);
            if (oldProduct == default(Product))
                return NotFound();
            product.id = oldProduct.id;
            DataStorage.Products.Remove(oldProduct);
            DataStorage.Products.Add(product);
            return Ok();
        }

        public IHttpActionResult Delete(Guid id)
        {
            var product = DataStorage.Products.FirstOrDefault(x => x.id == id);
            if (product == default(Product))
                return NotFound();
            DataStorage.Products.Remove(product);
            return Ok();
        }
    }
}
