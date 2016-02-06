appMainModule.controller("loginCtrl", ["$scope", "loginService", function ($scope, loginService) {

    $scope.submitForm = function (isValid) {

        if (isValid) {

            var inputVal = { Username: this.username, Password: this.pwd };

            loginService.isValidUser(inputVal, function (response) {
                if (response.success) {
                    alert("!!!!!!!!!!!");
                } else {
                    alert("@@@@@@@@@@");
                }
            });
        }
    };
}]);