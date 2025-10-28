using Microsoft.AspNetCore.Mvc;
using shopeingcart;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ShoppingCart.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        public static List<Product> products = new List<Product> { new Product { id = 1, price = 30, discription = "gjhgjh", img = "😂😂", numinstock = 69999 } };
        // GET api/<ProductController>
        [HttpGet()]
        public  IEnumerable<Product> Get()
        {
           return products;
        }
        // GET api/<ProductController>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var p = products.Find(x => x.id == id);
            if (p == null)
            {
                return NotFound();
            }
            return Ok(p);
        }
        // POST api/<CartController>
        [HttpPost]
        public ActionResult Post([FromBody] Product value)
        {
            var pro = products.Find(products => products.id == value.id);
            if(pro==null)
            {
                products.Add(value);
                return Ok(pro);
            }
            return Conflict();

        }

        // PUT api/<ProductController>/5/manger
        [HttpPut("{id}/manger")]
        public void Put( int id, [FromBody] Product p)
        {
            var index=products.FindIndex(x => x.id ==id);
            products[index].price = p.price;
            products[index].discription = p.discription;
            products[index].img = p.img;
            products[index].numinstock =p.numinstock;

        }
        // PUT api/<ProductController>/5/count
        [HttpPut("{id}/count")]
        public void Put(int id,  int count)
        {
            var index = products.FindIndex(x => x.id == id);
            products[index].numinstock += count;

        }

        // DELETE api/<ProductController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var pro=products.Find(x => x.id == id);
            if(pro==null)
            {
                return BadRequest();
            }
            return NoContent();
        }


    }
}
