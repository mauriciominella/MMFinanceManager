define(['services/configurationService'], function (configService) {

    return {

        getExpenses: function () {

            // make json call to our api
            jQuery.support.cors = true;

            $.ajax({
                url: configService.apiBaseURL + "Category/Expense",
                type: "GET",
                success: function (result) {
                    for (var i = 0; i < result.length; i++) {
                        that.categories.push(result[i]);
                    }
                }
            });



        }

    };

});