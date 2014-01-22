using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Web.Http;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MMFinanceManager;
using MMFinanceManager.WebApi.Controllers;
using MMFinanceManager.Model;

namespace MMFinanceManager.WebApi.Controllers.Tests.Controllers
{
    [TestClass]
    public class TransactionControllerTest
    {
        [TestMethod]
        public void Get()
        {
            // Arrange
            TransactionController controller = new TransactionController();

            // Act
            IEnumerable<Transaction> result = controller.Get();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(2, result.Count());
            Assert.AreEqual("value1", result.ElementAt(0));
            Assert.AreEqual("value2", result.ElementAt(1));
        }

        [TestMethod]
        public void GetById()
        {
            // Arrange
            TransactionController controller = new TransactionController();

            // Act
            Transaction result = controller.Get(5);

            // Assert
            Assert.AreEqual("value", result);
        }

        [TestMethod]
        public void Post()
        {
            // Arrange
            TransactionController controller = new TransactionController();

            // Act
            Transaction newTransaction = new Transaction()
            {
                Amount = 1,
                CategoryId = 1,
                CreationDate = DateTime.Now,
                Date = DateTime.Now,
                Description = "Test Transaction " + DateTime.Now.ToString(),
                Type = TransactionType.Expense
            };

            controller.Post(newTransaction);

            // Assert
        }

        [TestMethod]
        public void Put()
        {
            // Arrange
            TransactionController controller = new TransactionController();

            Transaction newTransaction = new Transaction()
            {
                Amount = 1,
                CategoryId = 1,
                CreationDate = DateTime.Now,
                Date = DateTime.Now,
                Description = "Test Transaction " + DateTime.Now.ToString(),
                Type = TransactionType.Expense
            };

            // Act
            controller.Put(1, newTransaction);

            // Assert
        }

        [TestMethod]
        public void Delete()
        {
            // Arrange
            TransactionController controller = new TransactionController();

            // Act
            controller.Delete(1);

            // Assert
        }
    }
}
