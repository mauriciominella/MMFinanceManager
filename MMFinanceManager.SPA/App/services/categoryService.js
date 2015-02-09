define(['services/configurationService'], function (ConfigurationService) {

    function CategoryService() {
        
    }

    CategoryService.prototype.getExpenses = function(successCallback, errorCallback){

        jQuery.support.cors = true;

        var configService = new ConfigurationService(true);

        jQuery.ajax({
            url: String(configService.baseApiURL) + 'Category/Expense',
            type: "GET",
            success: function (result) {
                successCallback(result);
            }
        });
    };

    return (CategoryService);
});