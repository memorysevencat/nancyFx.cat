var app = angular.module('myApp', []);
app.controller('myCtrl', function ($scope, $http) {
    $http.get("/photo/1p").success(function (response) { $scope.names = response.entify });
});
