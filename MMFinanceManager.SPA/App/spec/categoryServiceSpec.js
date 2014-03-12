define(["services/categoryService"], function (CategoryService) {
    describe('CategoryService', function () {
        it('should be able to create a new CategoryService instance', function () {

            var categoryService = new CategoryService();

            expect(categoryService).toBeDefined();
        });
        it('should be able to call getExpenses with success callback', function () {

            var categoryService = new CategoryService();

            var successCallback = jasmine.createSpy('successCallback')
            var failCallback = jasmine.createSpy('failCallback')
            //$('button#mybutton').click(dummy)

            //var successCallback = function (data) {
                
            //};

            //var failCallback = function (error) {

            //};

            categoryService.getExpenses(successCallback, failCallback);

            expect(successCallback).toHaveBeenCalled();
        });
    });
});