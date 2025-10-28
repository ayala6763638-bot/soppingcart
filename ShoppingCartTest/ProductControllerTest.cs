using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using ShoppingCart.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartTest
{
    public class ProductControllerTest
    {
        [Fact]
        public void Get_ReturnOk()
        {
            var id = 3;
            var controller = new ProductController();

            var result = controller.Get(id);
            Assert.IsType<OkObjectResult>(result);
        }

        [Fact]
        public void Get_ReturnNotFound()
        {
            var id = 2;
            var controller = new ProductController();
            var result = controller.Get(id);
            Assert.IsType<NotFoundResult>(result);
        }
        [Fact]

    }
}
