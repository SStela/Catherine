using System.Linq;
using System.Threading.Tasks;
using Catherine.Model.DbContext;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Catherine.Api.Controllers
{
    public class CountriesController : AppController
    {
        private readonly AppDbContext _context;

        public CountriesController(
            AppDbContext context
        ) {
            _context = context;
        }

        // [HttpGet("pagination")]
        [HttpGet]
        public async Task<IActionResult> GetPage()
        {
            var countries = await _context.Countries.ToListAsync();
            return ApiOk(countries);
        }
    }
}
