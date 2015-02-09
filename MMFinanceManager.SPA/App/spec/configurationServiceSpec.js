define(["services/configurationService"], function (ConfigurationService) {
    describe('ConfigurationService', function(){
        it('should has the baseApiURL as localhost when devApi is true', function () {
           
            var configService = new ConfigurationService(true);

            expect(configService.baseApiURL).toEqual('http://localhost:26741/api/');
        });
        it('should has the baseApiURL as azure api when devApi is false', function () {

            var configService = new ConfigurationService(false);

            expect(configService.baseApiURL).toEqual('http://mmfinancemanager.azurewebsites.net/api/');
        });
    });
});