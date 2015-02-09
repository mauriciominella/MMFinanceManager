define([], function () {

    function ConfigurationService(shouldUseDevApi) {

        if (shouldUseDevApi)
            this.baseApiURL = 'http://localhost:26741/api/'
        else
            this.baseApiURL = 'http://mmfinancemanager.azurewebsites.net/api/';
        
    }

    return ( ConfigurationService );

});