using MMFinanceManager.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMFinanceManager.Services
{
    public interface ITransactionRepository
    {
        Transaction Add(Transaction transaction);
        void Update(Transaction transaction);
        void Delete(long transactionId);
        IEnumerable<Transaction> GetAll();
    }
}
