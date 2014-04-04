define(["services/categoryService"], function (CategoryService) {
    describe('CategoryService', function () {

        var server;

        beforeEach(function () {
            server = sinon.fakeServer.create();

            server.respondWith("GET", "http://localhost:26741/api/Category/Expense",
                    [200, { "Content-Type": "application/json" },
                     '[{ "id": 12, "comment": "Hey there" }]']);

        });

        it('should be able to create a new CategoryService instance', function () {

            var categoryService = new CategoryService();
            expect(categoryService).toBeDefined();

        });

        it('should be able to call getExpenses with success callback', function () {

            var categoryService = new CategoryService();

            var sucessCallback = jasmine.createSpy('successCallback')
            var failCallback = jasmine.createSpy('failCallback');

            categoryService.getExpenses(sucessCallback, failCallback);

            server.respond();
            expect(sucessCallback).toHaveBeenCalled();

        });

        afterEach(function () { server.restore(); });
    });
});