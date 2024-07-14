using API.Controllers.Resources;
using API.Models;
using API.Persistence;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    public class FeaturesController : Controller
    {
        private readonly VegaDbContext _context;
        private readonly IMapper _mapper;

        public FeaturesController(VegaDbContext context, IMapper mapper)
        {
            _mapper = mapper;
            _context = context;
        }        

        [HttpGet("/api/features")]
        public async Task<IEnumerable<FeatureResource>> GetFeatures()
        {
            var features = await _context.Features.ToListAsync();
            var result = _mapper.Map<List<Feature>, List<FeatureResource>>(features);
            return result;
        }

    }
}