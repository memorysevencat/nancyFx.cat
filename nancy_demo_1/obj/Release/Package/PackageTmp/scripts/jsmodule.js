//var app = angular.module('myApp', []);

//app.controller('myCtrl', function ($scope, $http) {
//    $http.get("/photo/1").success(function (response) { $scope.names = response.entify; });
//});

var app = angular.module('myApp', []);
app.controller('customersCtrl', function ($scope, $http) {
    $http.get("/home/1")
    .success(function (response) { $scope.names = response.records; });
});
