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
        [ActionName("All")]
        public IEnumerable<Transaction> Get()
        {
            TransactionService transactionService = new TransactionService();
            return transactionService.GetAll();
        }

        [ActionName("CurrentMonth")]
        public IEnumerable<Transaction> GetCurrentMonth()
        {
            TransactionService transactionService = new TransactionService();
            return transactionService.GetCurrentMonth();
        }


        // GET api/values/5
        [ActionName("ById")]
        public Transaction Get(long id)
        {
            throw new NotImplementedException();
        }

        // POST api/values
        [ActionName("Add")]
        public void Post(Transaction transactionToCreate)
        {
            transactionToCreate.CreationDate = DateTime.Now;    

            TransactionService transactionService = new TransactionService();
            transactionService.AddNew(transactionToCreate);
        }

        // PUT api/values/5
        [ActionName("Modify")]
        public void Put(long id, Transaction transactionToUpdate)
        {
        }

        // DELETE api/values/5
        [ActionName("Remove")]
        [HttpDelete]
        public void Delete(long id)
        {
            TransactionService transactionService = new TransactionService();
            transactionService.Remove(id);
        }
    }
}