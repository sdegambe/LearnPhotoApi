using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LearnPhotoApi.Models;
using Microsoft.EntityFrameworkCore;

namespace LearnPhotoApi.AppContext
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions opts) : base(opts)
        {
        }

        public DbSet<PhotoModel> Photos { get; set; }
    }
}
