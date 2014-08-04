using System;
using System.Linq;
using System.Web.Http;
using Backend.Models;

namespace Backend.Controllers
{
    public class OrdersController : ApiController
    {
        public IHttpActionResult Get()
        {
            return Ok(DataStorage.Orders);
        }

        public IHttpActionResult Get(Guid id)
        {
            var order = DataStorage.Orders.FirstOrDefault(x => x.id == id);
            if (order == default(Order))
                return NotFound();
            return Ok(order);
        }

        public IHttpActionResult Post([FromBody] Order order)
        {
            if (order == null || !ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            order.id = Guid.NewGuid();
            DataStorage.Orders.Add(order);
            return Ok(order);
        }

        public IHttpActionResult Put(Guid id, [FromBody] Order order)
        {
            if (order == null || !ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var oldOrder = DataStorage.Orders.FirstOrDefault(x => x.id == id);
            if (oldOrder == default(Order))
                return NotFound();
            order.id = oldOrder.id;
            DataStorage.Orders.Remove(oldOrder);
            DataStorage.Orders.Add(order);
            return Ok();
        }

        public IHttpActionResult Delete(Guid id)
        {
            var order = DataStorage.Orders.FirstOrDefault(x => x.id == id);
            if (order == default(Order))
                return NotFound();
            DataStorage.Orders.Remove(order);
            return Ok();
        }
    }
}
