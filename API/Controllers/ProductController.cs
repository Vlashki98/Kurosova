using CustomLog4netLibrary;
using Swashbuckle.Swagger.Annotations;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Controllers;
using System.Web.Http.Description;
using System.Web.Http.Results;
using API.Business;
using API.Models;

namespace API.Controllers
{
    public class ProductController : BaseApiController
    {
        private readonly IProductService _service;
        private readonly ProductDomainService productDomainService;
        public ProductController(IProductService service)
        {
            this._service = service;
        }

        [HttpGet]
        public Product getProduct(int id)
        {
            var response = _service.getProduct(id);
            return response;
        }
        
    }
}
