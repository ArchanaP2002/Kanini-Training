﻿using AngularSampleApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AngularSampleApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly SampleNgContext _context;

        public ProductsController(SampleNgContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Product>>> GetAllProducts()
        {
            var products = await _context.Products.ToListAsync();
            return Ok(products);
        }

        [HttpPost]
        public async Task<ActionResult<Product>> CreateProduct(Product product)
        {
            _context.Products.Add(product);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetProduct), new { id = product.Id }, product);
        }


        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> GetProduct(int id)
        {
            var product = await _context.Products.FindAsync(id);

            if (product == null)
            {
                return NotFound();
            }

            return Ok(product);
        }
    }
}
