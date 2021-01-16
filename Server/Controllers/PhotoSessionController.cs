using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorEfCoreRepro.Server.Data;
using BlazorEfCoreRepro.Shared.Models.PhotoSession;
using Microsoft.EntityFrameworkCore;

namespace BlazorEfCoreRepro.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PhotoSessionController : Controller
    {
        private readonly ApplicationDbContext dbContext;

        public PhotoSessionController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        public async Task<IEnumerable<PhotoSessionResponseModel>> Get()
        {
            var photoSessions = await this.dbContext.PhotoSessions
                                          .Include(p => p.PhotoSessionDetails)
                                          .Select(p => new PhotoSessionResponseModel
                                          {
                                              Id = p.Id,
                                              Price = p.Price,
                                              Frames = p.Frames,
                                              BackgroundImageUri = p.BackgroundImageUri,
                                              Details = p.PhotoSessionDetails.Select(pd => new PhotoSessionDetailsResponseModel
                                              {
                                                  Id = pd.Id,
                                                  Type = pd.Type,
                                                  LanguageCode = pd.LanguageCode,
                                                  Description = pd.Description
                                              }).ToList()
                                          })
                                          .ToListAsync();

            return photoSessions;
        }
    }
}
