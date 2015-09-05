'use strict';
app.factory('notasService', ['$http', 'ngAuthSettings', function ($http, ngAuthSettings) {

    var serviceBase = ngAuthSettings.apiServiceBaseUri;

    var NotasServiceFactory = {};

    var _getNotas = function () {

        return $http.get(serviceBase + 'api/notas').then(function (results) {
            return results;
        });
    };

    ordersServiceFactory.getNotas = _getNotas;

    return ordersServiceFactory;

}]);