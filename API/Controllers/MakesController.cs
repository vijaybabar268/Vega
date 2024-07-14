using API.Controllers.Resources;
using API.Models;
using API.Persistence;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    public class Makes : Controller
    {
        private readonly VegaDbContext _context;
        private readonly IMapper _mapper;

        public Makes(VegaDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet("/api/makes")]
        public async Task<IEnumerable<MakeResource>> GetMakes()
        {
            var makes = await _context.Makes.Include(m => m.Models).ToListAsync();
            var result = _mapper.Map<List<Make>, List<MakeResource>>(makes);
            return result;
        }

                
    }
}