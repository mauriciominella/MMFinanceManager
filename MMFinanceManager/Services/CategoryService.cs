using MMFinanceManager.EntityFramework;
using MMFinanceManager.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMFinanceManager.Services
{
    public class CategoryService
    {
        #region Members

        ICategoryRepository _categoryDbService;

        #endregion

        #region Constructors

        public CategoryService()
        {
            _categoryDbService = new CategoryRepository();
        }

        #endregion

        #region Public Methods

        public Category AddNew(Category categoryToAdd)
        {
            _categoryDbService.Add(categoryToAdd);
            return categoryToAdd;
        }

        public IEnumerable<Category> GetAll()
        {
            return _categoryDbService.GetAll();
        }

        #endregion
 
    }
}
