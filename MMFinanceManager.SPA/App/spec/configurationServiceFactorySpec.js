define(["factory/configurationServiceFactory"], function (ConfigurationServiceFactory) {
    describe('ConfigurationServiceFactory', function(){
        it('should gets a ConfigurationService instance', function () {
           
            var configServiceFactory = new ConfigurationServiceFactory(true);
            var configService = configServiceFactory.GetService();

            expect(configService).toBeDefined();
        });
    });
});