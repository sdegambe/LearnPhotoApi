using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LearnPhotoApi.Models;
using LearnPhotoApi.Repositories;

namespace LearnPhotoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PhotoModelsController : ControllerBase
    {
        private readonly IDataRepository<PhotoModel, int> _iRepo;
        public PhotoModelsController(IDataRepository<PhotoModel, int> iRepo)
        {
            _iRepo = iRepo;
        }

        // GET: api/PhotoModels
        [HttpGet]
        public async Task<IEnumerable<PhotoModel>> GetPhotos()
        {
            return await _iRepo.GetAll();
        }

        // POST: api/PhotoModels
        [HttpPost]
        public async Task<int> PostPhotoModel([FromBody] PhotoModel photoModel)
        {
            return await _iRepo.Add(photoModel);
        }
    }
}