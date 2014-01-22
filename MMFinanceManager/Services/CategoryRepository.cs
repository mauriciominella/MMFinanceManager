using MMFinanceManager.EntityFramework;
using MMFinanceManager.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMFinanceManager.Services
{
    public class CategoryRepository : ICategoryRepository
    {
        #region Members

        private EFDbContext _dbContext;

        #endregion

        #region Constructors

        public CategoryRepository()
        {
            this._dbContext = new EFDbContext();
        }

        #endregion

        #region Public Methods

        public Category Add(Category Category)
        {
            this._dbContext.Categories.Add(Category);
            this._dbContext.SaveChanges();

            return Category;
        }

        public void Update(Category Category)
        {
            throw new NotImplementedException();
        }

        public void Delete(long CategoryId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Category> GetAll()
        {
            return _dbContext.Categories.ToList();
        }

        #endregion
    }
}
