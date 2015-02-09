using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMFinanceManager.WPF.ViewModel
{
    [Export]
    public class ShellViewModel : Conductor<IScreen>.Collection.OneActive
    {
        #region Constructors

        /// <summary>
        /// </summary>
        /// <param name="viewModels"></param>
        [ImportingConstructor]
        public ShellViewModel([ImportMany] IEnumerable<IScreen> viewModels)
        {
            Dictionary<Type, int> tabOrder = new Dictionary<Type, int>();
            tabOrder.Add(typeof(LoginViewModel), 1);
            //tabOrder.Add(typeof(BraviEntriesViewModel), 2);
            //tabOrder.Add(typeof(ConfigurationViewModel), 3);

            IOrderedEnumerable<IScreen> orderedScreens = viewModels.OrderBy(t => tabOrder[t.GetType()]);

           // Items.AddRange(orderedScreens.Except(orderedScreens.OfType<BraviEntriesViewModel>()));
            Items.AddRange(orderedScreens);
         
        }

        #endregion
    }
}
