appMainModule.service('loginService', ['$http', '$timeout', function ($http, $timeout) {

    this.isValidUser = function (inputVal, callback) {

        $http.post('api/login', inputVal).success(function (response) {
            callback(response);
        });

        //$timeout(function () {
        //    $http.post('api/login', inputVal).success(function (response) {
        //        callback(response);
        //    });
        //}, 2000);//delay 2 seconds before returning value
    };
}]);