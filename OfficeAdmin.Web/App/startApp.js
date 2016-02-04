var appMainModule = angular.module('mainModel', ['ngRoute'])
                             .config(["$routeProvider", "$locationProvider", function ($routeProvider, $locationProvider) {
                                 $routeProvider.when('/', { templateUrl: '/App/login.html', controller: 'startAppModel' });
                                 $routeProvider.otherwise({
                                     redirectTo: '/'  //Work together with RoutConfig.cs
                                 });

                                 $locationProvider.html5Mode({
                                     enabled: true,
                                     requireBase: false
                                 });
                             }]);

appMainModule.controller("startAppModel", ["$scope", function ($scope) {

    $scope.submitForm = function (isValid) {

        if (isValid) {
            alert('Valid!!!');
        }
    };
}]);