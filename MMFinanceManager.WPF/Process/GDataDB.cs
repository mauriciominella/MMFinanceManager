using GDataDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMFinanceManager.WPF.Process
{
    public class MyGDataDB
    {
        #region Constants

        public const string DATABASE_NAME = "MMFINANCEMANAGER";

        #endregion

        #region Properties

        public IDatabase Db { get; private set; }

        #endregion

        #region Singleton Implementation

        private static MyGDataDB instance;

        private MyGDataDB() { 
            
        }

        private MyGDataDB(string gmailUser, string password)
        {
            IDatabaseClient client = new DatabaseClient(gmailUser, password);
            Db = client.GetDatabase(DATABASE_NAME) ?? client.CreateDatabase(DATABASE_NAME);
        }


        //private void AddPerson()
        //{
        //    ITable<Person> table = _db.GetTable<Person>("Person") ?? _db.CreateTable<Person>("Person");

        //    // now I can fill a Person object and add it
        //    var person = new Person();
        //    person.FirstName = "Ryan";
        //    person.LastName = "Farley";
        //    person.Email = "me@me.com";
        //    //...

        //    table.Add(person);
        //}

        public static MyGDataDB Instance
        {
            get
            {
                return instance;
            }
        }

        public static MyGDataDB GetInstance(string gmailUser, string password)
        {
            if (instance == null)
            {
                instance = new MyGDataDB(gmailUser, password);
            }
            return instance;
        }

        #endregion

//        private void test(){
//            // create the DatabaseClient passing my Gmail or Google Apps credentials

 
//            // get or create the database. This is the spreadsheet file 

 
////            // get or create the table. This is a worksheet in the file 
////            // note I am using my Person object so it knows what my schema needs to be  
////            // for my data. It will create a header row with the property names 
////            ITable<Person> table = db.GetTable<Person>(MySheetName) ?? db.CreateTable<Person>(MySheetName);
 
////            // now I can fill a Person object and add it
////            var person = new Person();
////            person.FirstName = "Ryan";
////            person.LastName = "Farley";
////            person.Email = "me@me.com";
////            //...
 
////table.Add(person);
//        }

        #region Properties


        #endregion

    }
}
