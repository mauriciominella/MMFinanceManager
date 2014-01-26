using MMFinanceManager.Model;
using MMFinanceManager.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MMFinanceManager.WebApi.Controllers
{
    public class TransactionController : ApiController
    {
        // GET api/values
        public IEnumerable<Transaction> Get()
        {
            TransactionService transactionService = new TransactionService();
            return transactionService.GetAll();
        }

        // GET api/values/5
        public Transaction Get(long id)
        {
            throw new NotImplementedException();
        }

        // POST api/values
        public void Post(Transaction transactionToCreate)
        {
            transactionToCreate.CreationDate = DateTime.Now;    

            TransactionService transactionService = new TransactionService();
            transactionService.AddNew(transactionToCreate);
        }

        // PUT api/values/5
        public void Put(long id, Transaction transactionToUpdate)
        {
        }

        // DELETE api/values/5
        public void Delete(long id)
        {
        }
    }
}