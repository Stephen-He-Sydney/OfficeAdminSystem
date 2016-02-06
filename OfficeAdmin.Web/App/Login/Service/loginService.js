appMainModule.service('loginService', ['$http', '$timeout', function ($http, $timeout) {

    this.isValidUser = function (inputVal, callback) {
        $timeout(function () {
            $http.post('api/login', inputVal).success(function (response) {
                callback(response);
            });
        }, 1000);
    };
}]);