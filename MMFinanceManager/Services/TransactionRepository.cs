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
            var query = this._dbContext.Transactions.Where(t => t.Id == transactionId);

            if(query.Count() == 0)
                throw new ArgumentException(String.Format("An error has occurred trying to delete the resource. The resource id {0} doesn't exist", transactionId));

            Transaction transactionToDelete = query.First();

            this._dbContext.Transactions.Remove(transactionToDelete);
            this._dbContext.SaveChanges();
        }

        public IEnumerable<Transaction> GetAll()
        {
            return _dbContext.Transactions.ToList();
        }

        #endregion
    }
}
