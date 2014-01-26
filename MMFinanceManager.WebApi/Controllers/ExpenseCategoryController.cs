using MMFinanceManager.Model;
using MMFinanceManager.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace MMFinanceManager.WebApi.Controllers
{
    public class ExpenseCategoryController : ApiController
    {
        //
        // GET: /ExpenseCategory/
        public IEnumerable<Category> Get()
        {
            CategoryService categoryService = new CategoryService();
            return categoryService.GetAllOfExpenseType();
        }

    }
}
