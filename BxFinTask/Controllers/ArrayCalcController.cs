using BxFinTask.Services;
using Microsoft.AspNetCore.Mvc;
using System;

namespace BxFinTask.Controllers
{
    [Route("api/[controller]")]
    public class ArrayCalcController : Controller
    {
        private readonly IProductService _productService;

        public ArrayCalcController(IProductService productService)
        {
            _productService = productService;
        }


        // GET: api/arraycalc/reverse
        [HttpGet("reverse")]
        public IActionResult Get([FromQuery] int[] productIds)
        {
            try
            {
                return Ok(_productService.Reverse(productIds));
            }
            catch (Exception)
            {
                return StatusCode(500, "Reverse Failure");
            }
        }


        // GET: api/arraycalc/deletepart
        [HttpGet("deletepart")]
        public IActionResult Get(int position, [FromQuery] int[] productIds)
        {
            try
            {
                if (position > 0)
                {
                    return Ok(_productService.Delete(position, productIds));
                }
                else
                {
                    return StatusCode(500, "Please, enter a valid position value!");
                }
            }
            catch (Exception)
            {
                return StatusCode(500, "DeletePart Failure");
            }
        }
    }
}
