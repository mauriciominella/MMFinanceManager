using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMFinanceManager.WPF.Process
{
    public class GDataDB
    {
        #region Singleton Implementation

        private static GDataDB instance;

        private GDataDB() { }

        public static GDataDB Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new GDataDB();
                }
                return instance;
            }
        }

        #endregion

        #region Properties

        public string Email { get; set; }
        public string Password { get; set; }

        #endregion

    }
}
