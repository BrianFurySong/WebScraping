(function () {
    "use strict";

    angular.module(appName).component("webScrape", {
        bindings: {},
        templateUrl: "/Scripts/Components/Views/webScrapeView.html",
        controller: function (requestService, $scope, $window) { 
            var vm = this;
            vm.$onInit = _init; 
            vm.scrapes = [];

            function _init() {
                requestService.ApiRequestService("get", "/api/WebScrapes")
                    .then(function (response) {
                        vm.scrapes = response;
                        console.log("Start", vm.scrapes);
                    })
                    .catch(function (err) {
                        console.log(err);
                    })
            }
        }
    })
})();
