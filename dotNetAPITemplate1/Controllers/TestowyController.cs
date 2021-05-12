using System.Linq;
using System.Threading.Tasks;
using dotNetAPITemplate1.Dto.Results;
using dotNetAPITemplate1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace dotNetAPITemplate1.Controllers
{
    
    [ApiController]
    [Route("[controller]")]
    public class TestowyController : ControllerBase
    {
        private MainDbContext _context;

        public TestowyController(MainDbContext context)
        {
            _context = context;
        }
        
        [HttpGet("/api/testowe")]
        public IActionResult Testowa()
        {
            return Ok("Kontroller działa");
        }

        [HttpGet("/api/testowedane")]
        public async Task<IActionResult> DaneTestowe()
        {
            var result = await _context
                .SampleModels
                .Select(samplemodel =>new SampleResultDto
                {
                    IdModelu = samplemodel.MoreModelId,
                    KluczObcy = samplemodel.IdOne,
                    PoleTejTabeli = samplemodel.NazwaModelu,
                    PoleZObcejTabeli = samplemodel.One.Pole
                })
                .ToArrayAsync();
            return Ok(result);
        }
        
    }
}