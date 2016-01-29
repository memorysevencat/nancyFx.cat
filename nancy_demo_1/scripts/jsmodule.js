var home = angular.module('home', []);

home.controller("user", ['$scope',
    function ($scope) {
        $scope.user = {
            username: "1"
        };
    }
])