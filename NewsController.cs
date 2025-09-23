    using System;

    using Microsoft.AspNetCore.Mvc;
    using Microsoft.EntityFrameworkCore;
    using backend
    using System.Threading.Tasks;

    [Route("api/[controller]")]
    [ApiController]
    public class NewsController : ControllerBase
    {
        // Private field to hold the database context
        private readonly ApplicationDbContext _context;

        public NewsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // READ All - Now fetches from the database
        [HttpGet]
        public async Task<IActionResult> GetLatestNews()
        {
            // Asynchronously query the database's News table
            var latestNews = await _context.News
                .OrderByDescending(article => article.PublishDate)
                .ToListAsync(); // Executes the query and returns a list

            return Ok(latestNews);

        }

        // READ (Single) - Now fetches from the database
        [HttpGet("{id}")]
        public async Task<IActionResult> GetNewsById(int id)
        {
            // Asynchronously find a single article by its ID
            var article = await _context.News.FindAsync(id);

            if (article == null)
            {
                return NotFound();
            }
            return Ok(article);
        }

        // CREATE - Adds to the database
        [HttpPost]
        public async Task<IActionResult> CreateNewsArticle([FromBody] NewsArticle newArticle)
        {
            newArticle.PublishDate = DateTime.Now;

            _context.News.Add(newArticle); // Stage the new article for insertion
            await _context.SaveChangesAsync(); // Save changes to the database

            return CreatedAtAction(nameof(GetNewsById), new { id = newArticle.Id }, newArticle);
        }

        // UPDATE - Now updates the database
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateNewsArticle(int id, [FromBody] NewsArticle updatedArticle)
        {
            // Find the existing article by its id
            var article = await _context.News.FindAsync(id);

            // If doesn't exist return 404 not found error
            if (article == null)
            {
                return NotFound();
            }

            // Update the properties of the found article
            article.Title = updatedArticle.Title;
            article.Content = updatedArticle.Content;
            article.Author_id = updatedArticle.Author_id;
            article.Branch_id = updatedArticle.Branch_id;

            // Save changes to the database
            await _context.SaveChangesAsync();

            // Return 204 No Content for a successful update
            return NoContent();
        }

        // DELETE - Now deletes from the database
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteNewsArticle(int id)
        {
            // Found the article to be deleted
            var article = await _context.News.FindAsync();

            // If doesn't exist return 404 not found error
            if (article == null)
            {
                return NotFound();
            }

            // Mark the article for removal
            _context.News.Remove(article);

            // Save the change to the database
            await _context.SaveChangesAsync();

            // Return 204 No Content for a successful delete
            return NoContent();
        }
    }

