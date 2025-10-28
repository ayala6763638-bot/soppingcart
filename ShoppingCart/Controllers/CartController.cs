using Microsoft.AspNetCore.Mvc;
using shopeingcart;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ShoppingCart.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartController : ControllerBase
    {
       

        // GET api/<CartController>/5
        [HttpGet("{iduser}")]
        public Cart Get(int iduser)
        {
            Cart cart = new Cart();
            return cart ;
        }

        // POST api/<CartController>
        [HttpPost]
        public void Post([FromBody] Cart value)
        {
        }

        // PUT api/<CartController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]Cart value)
        {
        }

        // DELETE api/<CartController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
