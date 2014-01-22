using MMFinanceManager.EntityFramework;
using MMFinanceManager.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMFinanceManager.Services
{
    public class TransactionRepository : ITransactionRepository
    {
        #region Members

        private EFDbContext _dbContext;

        #endregion

        #region Constructors

        public TransactionRepository()
        {
            this._dbContext = new EFDbContext();
        }

        #endregion

        #region Public Methods

        public Transaction Add(Transaction transaction)
        {
            this._dbContext.Transactions.Add(transaction);
            this._dbContext.SaveChanges();

            return transaction;
        }

        public void Update(Transaction transaction)
        {
            throw new NotImplementedException();
        }

        public void Delete(long transactionId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Transaction> GetAll()
        {
            return _dbContext.Transactions.ToList();
        }

        #endregion
    }
}
