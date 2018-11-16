using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LearnPhotoApi.Models;

namespace LearnPhotoApi.Managers
{
    public interface IPhotoManager
    {
        Task<int> Add(PhotoModel photoModel);
        Task<IEnumerable<PhotoModel>> GetAll();
    }
}
