'use strict';
app.controller('notasController', ['$scope', 'notasService', function ($scope, notasService) {

    $scope.notas = [];

    notasService.getNotas().then(function (results) {

        $scope.notas = results.data;

    }, function (error) {
        //alert(error.data.message);
    });

}]);