define(['services/configurationService'], function (ConfigurationService) {

    function ConfigurationServiceFactory() {

    }

    ConfigurationServiceFactory.prototype.GetService = function () {
        return new ConfigurationService(true);
    }

    return (ConfigurationServiceFactory);

});