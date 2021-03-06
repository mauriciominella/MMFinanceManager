﻿define(['plugins/http', 'durandal/app', 'knockout'], function (http, app, ko) {
    //Note: This module exports an object.
    //That means that every module that "requires" it will get the same object instance.
    //If you wish to be able to create multiple instances, instead export a function.
    //See the "welcome" module for an example of function export.

    //var apiBaseURL = 'http://mmfinancemanager.azurewebsites.net/api/';
    var apiBaseURL = 'http://localhost:26741/api/';
        

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

            var that = this;

            jQuery.support.cors = true;
            $.ajax({
                url: apiBaseURL + "Transaction/Add",
                data: { CategoryId: this.selectedCategory().Id, Description: this.description, Amount: this.amount, Date: this.transactionDate(), Type: 2 },
                type: "POST",
                success: function (result) {
                    app.showMessage('Transaction Sucessfully Added!', 'Information', ['Ok']);
                    that.clearFormValues();
                }
            });

        },
        clearFormValues: function(){
            this.selectedCategory(null);
            this.description(null);
            this.amount(null);
            this.transactionDate(null);
            this.setCurrentDate();
        },
        setCurrentDate: function(){

            var now = new Date();
            var day = ("0" + now.getDate()).slice(-2);
            var month = ("0" + (now.getMonth() + 1)).slice(-2);

            var today = now.getFullYear() + "-" + (month) + "-" + (day);

            $('#transactionDate').val(today);
            $("#transactionDate").trigger("change");

        },
        attached: function (view, parent) {

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

            this.setCurrentDate();
        },
        canDeactivate: function () {
            //the router's activator calls this function to see if it can leave the screen
            //return app.showMessage('Are you sure you want to leave this page?', 'Navigate', ['Yes', 'No']);
            return true;
        }
    };
});