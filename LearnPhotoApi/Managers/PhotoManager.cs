using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LearnPhotoApi.AppContext;
using LearnPhotoApi.Models;
using LearnPhotoApi.Repositories;
using Microsoft.EntityFrameworkCore;

namespace LearnPhotoApi.Managers
{
    public class PhotoManager : IDataRepository<PhotoModel, int>, IPhotoManager
    {
        private readonly ApplicationContext _ctx;

        public PhotoManager(ApplicationContext ctx)
        {
            _ctx = ctx;
        }
        public async Task<int> Add(PhotoModel photoModel)
        {
            _ctx.Photos.Add(photoModel);
            await _ctx.SaveChangesAsync();
            return photoModel.Id;
        }

        public async Task<IEnumerable<PhotoModel>> GetAll()
        {
            return await _ctx.Photos.ToListAsync();
        }
    }
}
