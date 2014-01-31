define(['plugins/router', 'durandal/app'], function (router, app) {
    return {
        router: router,
        search: function() {
            //It's really easy to show a message box.
            //You can add custom options too. Also, it returns a promise for the user's response.
            app.showMessage('Search not yet implemented...');
        },
        activate: function () {
            router.map([
                { route: '', moduleId: 'viewmodels/addExpense', nav: true, displayName: 'Add Expense' },
                { route: 'currentMonthTransactions', moduleId: 'viewmodels/currentMonthTransactions', nav: true, displayName: 'Current Month Transactions' }
                //{ route: 'addExpense', moduleId: 'viewmodels/addExpense', nav: true, displayName: 'Add Expense' }
            ]).buildNavigationModel();
            
            return router.activate();
        }
    };
});