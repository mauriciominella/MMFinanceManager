﻿define(['plugins/http', 'durandal/app', 'knockout'], function (http, app, ko) {
    //Note: This module exports an object.
    //That means that every module that "requires" it will get the same object instance.
    //If you wish to be able to create multiple instances, instead export a function.
    //See the "welcome" module for an example of function export.

    //var apiBaseURL = 'http://mmfinancemanager.azurewebsites.net/api/';
    var apiBaseURL = 'http://localhost:26741/api/';
    

    return {
        displayName: 'Current Month Transactions',
        transactions: ko.observableArray([]),
        activate: function () {          

        },
        select: function(item) {
            //the app model allows easy display of modal dialogs by passing a view model
            //views are usually located by convention, but you an specify it as well with viewUrl
            //item.viewUrl = 'views/detail';
            //app.showDialog(item);
        },
        attached: function (view, parent) {

        },
        deleteTransaction: function (transactionId) {
          
            var that = this;

            jQuery.support.cors = true;

            $.ajax({
                url: apiBaseURL + "Transaction/Remove/" + String(transactionId),
                type: "DELETE",
                success: function (result) {
                    that.loadTransactions();
                }
            });

        },
        activate: function () {
            var that = this;
            that.loadTransactions();
        },
        loadTransactions: function(){

            var that = this;

            //Delete all content from transactions array
            that.transactions().length = 0;

            jQuery.support.cors = true;
            $.ajax({
                url: apiBaseURL + "Transaction/CurrentMonth",
                type: "GET",
                success: function (result) {
                    for (var i = 0; i < result.length; i++) {
                        that.transactions.push(result[i]);
                    }
                }
            });

        },
        canDeactivate: function () {
            //the router's activator calls this function to see if it can leave the screen
            //return app.showMessage('Are you sure you want to leave this page?', 'Navigate', ['Yes', 'No']);
            return true;
        }
    };
});