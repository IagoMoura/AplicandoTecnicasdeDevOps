'use strict';
app.controller('notasController', ['$scope', 'notasService', function ($scope, ordersService) {

    $scope.orders = [];

    notasService.getnotas().then(function (results) {

        $scope.notas = results.data;

    }, function (error) {
        //alert(error.data.message);
    });

}]);