define(['plugins/http', 'durandal/app', 'knockout'], function (http, app, ko) {
    //Note: This module exports an object.
    //That means that every module that "requires" it will get the same object instance.
    //If you wish to be able to create multiple instances, instead export a function.
    //See the "welcome" module for an example of function export.

    var apiBaseURL = 'http://mmfinancemanager.azurewebsites.net/api/';
    //var apiBaseURL = 'http://localhost:26741/api/';
        

    return {
        displayName: 'Add Expense',
        categories: ko.observableArray([]),
        selectedCategory: ko.observable(),
        description: ko.observable(),
        amount: ko.observable(),
        transactionDate: ko.observable(),
        activate: function () {

        },
        select: function(item) {
            //the app model allows easy display of modal dialogs by passing a view model
            //views are usually located by convention, but you an specify it as well with viewUrl
            //item.viewUrl = 'views/detail';
            //app.showDialog(item);
        },
        add: function () {
            jQuery.support.cors = true;
            $.ajax({
                url: apiBaseURL + "Transaction/Add",
                data: { CategoryId: this.selectedCategory().Id, Description: this.description, Amount: this.amount, Date: this.transactionDate(), Type: 2 },
                type: "POST",
                success: function (result) {
                }
            });

        },
        attached: function (view, parent) {
            //$(view).find('#transactionDate').datepicker({ dateFormat: 'dd/mm/yy' });

            var that = this;

            jQuery.support.cors = true;
            $.ajax({
                url: apiBaseURL + "Category/Expense",
                type: "GET",
                success: function (result) {
                    for (var i = 0; i < result.length; i++) {
                        that.categories.push(result[i]);
                    }
                }
            });

            //transactionDate = Date.now;

        },
        canDeactivate: function () {
            //the router's activator calls this function to see if it can leave the screen
            //return app.showMessage('Are you sure you want to leave this page?', 'Navigate', ['Yes', 'No']);
            return true;
        }
    };
});