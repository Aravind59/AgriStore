using AgriStore.Contracts.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AgriStore.Controllers
{
    public class ProductsController : ApiController
    {

        private IProductService _productService;
        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public HttpResponseMessage GetProducts()
        {
            try
            {
                
                return Request.CreateResponse(HttpStatusCode.OK, new { Products = _productService.GetProducts() });
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, Convert.ToString(ex.Message));
            }
        }
    }
}
