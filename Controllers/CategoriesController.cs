using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using ProductManagement.Data;
using ProductManagement.Models;
using Microsoft.EntityFrameworkCore;


    [ApiController]
    [Route("api/categories")]
    [Produces("application/json")]
    public class CategoriesController : ControllerBase
    {
        private readonly AppDbContext _context;

        public CategoriesController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Category>> GetCategories()
        {
            var categories = _context.Categories.ToList();
            return Ok(categories);
        }

        [HttpGet("{id}")]
        public ActionResult<Category> GetCategory(int id)
        {
            var category = _context.Categories.FirstOrDefault(c => c.categoryId == id);
            if (category == null)
            {
                return NotFound();
            }

            return Ok(category);
        }

       [HttpPost]
        public ActionResult<Category> CreateCategory([FromBody] Category category)
        {
            category.categoryId = 0; 

            _context.Entry(category).State = EntityState.Added; 
            _context.SaveChanges();

            return CreatedAtAction(nameof(GetCategory), new { id = category.categoryId }, category);
        }

        [HttpPut("{id}")]
        public ActionResult UpdateCategory(int id, [FromBody] Category category)
        {
            if (id != category.categoryId)
            {
                return BadRequest();
            }

            _context.Entry(category).State = EntityState.Modified;
            _context.SaveChanges();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteCategory(int id)
        {
            var category = _context.Categories.FirstOrDefault(c => c.categoryId == id);
            if (category == null)
            {
                return NotFound();
            }

            _context.Categories.Remove(category);
            _context.SaveChanges();

            return NoContent();
        }
    }
