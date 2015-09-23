'use strict';
app.factory('notasService', ['$http', 'ngAuthSettings', function ($http, ngAuthSettings) {

    var serviceBase = ngAuthSettings.apiServiceBaseUri;

    var NotasServiceFactory = {};

    var _getNotas = function () {

        return $http.get(serviceBase + 'api/notas').then(function (results) {
            return results;
        });
    };

    NotasServiceFactory.getNotas = _getNotas;

    return NotasServiceFactory;

}]);