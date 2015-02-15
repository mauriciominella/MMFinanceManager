using GDataDB;
using MMFinanceManager.Model;
using MMFinanceManager.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMFinanceManager.Repository.GDataDB.Services
{
    public class CategoryRepository : ICategoryRepository
    {
        #region Constants

        public const string TABLE_NAME = "Categories";

        #endregion

        #region Members

        private IDatabase Db { get; set; }
        private ITable<Category> Table {get; set;}

        #endregion

        #region Constructor

        public CategoryRepository(IDatabase db)
        {
            Db = db;
            Table = db.GetTable<Category>(TABLE_NAME) ?? db.CreateTable<Category>(TABLE_NAME);
        }

        #endregion

        #region Public Methods

        public Category Add(Category category)
        {
            Table.Add(category);
            return category;
        }

        public void Update(Category category)
        {
            //Table.Find(new Query() { StructuredQuery = String.Format("id = {0}", category.Id) });
            throw new NotImplementedException();
        }

        public void Delete(long transactionId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Category> GetAll()
        {
            foreach (var item in Table.FindAll())
                yield return item.Element;
        }

        #endregion

    }
}
