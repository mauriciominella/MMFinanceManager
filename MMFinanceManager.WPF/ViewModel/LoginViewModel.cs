using Caliburn.Micro;
using MMFinanceManager.WPF.Process;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace MMFinanceManager.WPF.ViewModel
{
    [Export(typeof(IScreen))]
    public class LoginViewModel : Screen
    {
        #region Members

        private string _email = String.Empty;

        #endregion

        #region Constructors

        public LoginViewModel()
        {
            DisplayName = "Login";
        }

        #endregion

        #region Properties

        public string Email
        {
            get
            {
                return _email;
            }
            set
            {
                _email = value;
                NotifyOfPropertyChange(() => Email);
            }
        }

        #endregion

        #region Public Methods

        public bool CanLogin()
        {
            return true;
        }

        public void Login(object passwordBox)
        {
            PasswordBox obj = passwordBox as PasswordBox;
            MyGDataDB.GetInstance(Email, obj.Password);
        }

        #endregion

    }
}
