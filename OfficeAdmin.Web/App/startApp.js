var appMainModule = angular.module('mainModel', ['ngRoute'])
    .config(["$routeProvider", "$locationProvider", function ($routeProvider, $locationProvider) {
        $routeProvider
            .when('/', { templateUrl: '/App/Login/View/login.html', controller: 'loginCtrl' });
        $routeProvider
            .when('/register', { templateUrl: '/App/Register/View/register.html', controller: 'registerCtrl' });
        $routeProvider
            .otherwise({
            redirectTo: '/'  //Work together with RoutConfig.cs
        });

        $locationProvider.html5Mode({
            enabled: true,
            requireBase: false
        });
    }]);

//appMainModule.controller("startAppModel", ["$scope", "loginService", function ($scope, loginService) {

//    $scope.submitForm = function (isValid) {

//        if (isValid) {

//            var inputVal = { username: this.username, password: this.pwd };

//            loginService.isValidUser(inputVal, function (response) {
//                if (response.success) {
//                    //AuthenticationService.SetCredentials($scope.username, $scope.password);
//                    //$location.path('/');
//                } else {
//                    //$scope.error = response.message;
//                    //$scope.dataLoading = false;
//                }
//            });
//            //alert('Valid!!!');
//            //alert("username:" + this.username);
//            //alert("password:" + this.pwd);
//        }
//    };
//}]);