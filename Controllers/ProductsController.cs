using Microsoft.AspNetCore.Mvc;
using ProductManagement.Data;
using ProductManagement.Models;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

[ApiController]
[Route("api/products")]
[Produces("application/json")]
public class ProductsController : ControllerBase
{
    private readonly AppDbContext _context;

    public ProductsController(AppDbContext context)
    {
        _context = context;
    }

    //GET /products

        [HttpGet]
        public ActionResult<IEnumerable<Product>> GetProducts()
        {
            var categories = _context.Products.ToList();
            return Ok(categories);
        }


    //GET /products/5
    [HttpGet("{id}")]
    public ActionResult<Product> GetProduct(int id)
    {
        var product = _context.Products.Find(id);
        if (product == null)
        {
            return NotFound();
        }
        return Ok(product);
    }

  [HttpPost]
        public ActionResult<Product> CreateProduct([FromBody] Product product)
        {
            product.productId = 0; 

            _context.Entry(product).State = EntityState.Added; 
            _context.SaveChanges();

            return CreatedAtAction(nameof(GetProduct), new { id = product.productId }, product);
        }

    //PUT /products/5
    [HttpPut("{id}")]
    public ActionResult UpdateProduct(int id, [FromBody] Product product)
    {
        if (id != product.productId)
        {
            return BadRequest();
        }
        _context.Entry(product).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
        _context.SaveChanges();
        return NoContent();
    }

    //DELETE /products/5
    [HttpDelete("{id}")]
    public ActionResult DeleteProduct(int id)
    {
        var product = _context.Products.Find(id);
        if (product == null)
        {
            return NotFound();
        }
        _context.Products.Remove(product);
        _context.SaveChanges();
        return NoContent();
    }

}