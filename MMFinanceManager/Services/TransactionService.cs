using MMFinanceManager.EntityFramework;
using MMFinanceManager.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMFinanceManager.Services
{
    public class TransactionService
    {
        #region Members

        ITransactionRepository _transactionDbService;

        #endregion

        #region Constructors

        public TransactionService()
        {
            _transactionDbService = new TransactionRepository();
        }

        #endregion

        #region Public Methods

        public Transaction AddNew(Transaction transactionToAdd)
        {
            _transactionDbService.Add(transactionToAdd);
            return transactionToAdd;
        }

        public IEnumerable<Transaction> GetAll()
        {
            return _transactionDbService.GetAll();
        }

        public IEnumerable<Transaction> GetCurrentMonth()
        {
            return _transactionDbService.GetAll().Where(t => t.Date.Month == DateTime.Now.Month && t.Date.Year == DateTime.Now.Year).OrderByDescending(o => o.Date);
        }

        #endregion
 
    }
}
