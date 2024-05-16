using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web.Data.Access.Repository.IRepository;
using Web.Models;

namespace Web.Data.Access.Repository
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private ApplicationDbContext _db;
        public CategoryRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }



        public void Update(Category obj)
        {
            _db.Categories.Update(obj);
        }
    }
}
