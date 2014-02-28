define("configurationService", function (require) {

    function ConfigurationService() {
        //this.apiBaseURL = 'http://mmfinancemanager.azurewebsites.net/api/';
        this.baseApiURL = 'http://localhost:26741/api/'
    }

    //return {

    //    //var apiBaseURL = 'http://mmfinancemanager.azurewebsites.net/api/';
    //    //var apiBaseURL = 'http://localhost:26741/api/';

    //    baseApiUrl: 'http://localhost:26741/api/'

    //};

    return ConfigurationService;

});