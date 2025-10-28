using Microsoft.AspNetCore.Mvc;
using shopeingcart;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ShoppingCart.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DiscountController : ControllerBase
    {
        public static List<Discount> discount = new List<Discount> { new Discount { id=234,productid=1,discountprecent=45,discription="hgujgj",numindiscount=5 } };

        // GET api/<ProductController>
        [HttpGet()]
        public IEnumerable<Discount> Get()
        {
            return discount;
        }
        // GET api/<DiscountController>/5
        [HttpGet("{idproduct}")]
        public ActionResult Get(int idproduct)
        {
            var d = discount.Find(x => x.id ==idproduct);
            if (d == null)
            {
                return NotFound();
            }
            return Ok(d);
        }
     
        // POST api/<CartController>
        [HttpPost]
        public ActionResult Post([FromBody] Discount value)
        {
            var dis = discount.Find(discount => discount.id == value.id);
            if (dis == null)
            {
                discount.Add(value);
                return Ok(dis);
            }
            return Conflict();

        }

        // PUT api/<ProductController>/5/manger
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Discount d)
        {
            var index = discount.FindIndex(x => x.id == id);
            discount[index].productid = d.productid;
            discount[index].discription = d.discription;
            discount[index].numindiscount = d.numindiscount;
            discount[index].numinstock += p.numinstock;

        }
      

        // DELETE api/<ProductController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var pro = products.Find(x => x.id == id);
            if (pro == null)
            {
                return BadRequest();
            }
            return NoContent();
        }




    }
}
