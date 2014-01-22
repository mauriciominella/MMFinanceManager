using MMFinanceManager.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMFinanceManager.Services
{
    public interface ICategoryRepository
    {
        Category Add(Category transaction);
        void Update(Category transaction);
        void Delete(long transactionId);
        IEnumerable<Category> GetAll();
    }
}
