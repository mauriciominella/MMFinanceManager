using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            return !string.IsNullOrEmpty(Email);
        }

        public void Login(object passwordBox)
        {

        }

        #endregion

    }
}
