﻿using MMFinanceManager.Model;
using MMFinanceManager.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MMFinanceManager.WebApi.Controllers
{
    public class CategoryController : ApiController
    {
        // GET api/values
        [ActionName("GetAll")]
        public IEnumerable<Category> Get()
        {
            CategoryService categoryService = new CategoryService();
            return categoryService.GetAll();
        }

        [ActionName("Expense")]
        public IEnumerable<Category> GetExpenseType()
        {
            CategoryService categoryService = new CategoryService();
            return categoryService.GetAllOfExpenseType();
        }

        // GET api/values/5
        [ActionName("GetById")]
        public Category Get(long id)
        {
            throw new NotImplementedException();
        }

        // POST api/values
        [ActionName("Add")]
        public void Post(Category categoryToCreate)
        {
            CategoryService categoryService = new CategoryService();
            categoryService.AddNew(categoryToCreate);
        }

        // PUT api/values/5
        [ActionName("Modify")]
        public void Put(long id, Category categoryToUpdate)
        {
            throw new NotImplementedException();
        }

        // DELETE api/values/5
        [ActionName("Remove")]
        public void Delete(long id)
        {
        }
    }
}