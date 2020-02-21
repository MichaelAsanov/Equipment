app

/**
 * Сервис для работы с оборудованием
 */
    .factory("equipmentService", function ($http, $q) {
        return {

            /**
             /* Возвращает список оборудования
             * @returns {}
             */
            GetEquipmentAsync: function() {
                var deferred = $q.defer();

                $http.get("/api/equipment", {})
                    .then(function(equipmentResponse) {
                        deferred.resolve(equipmentResponse.data);
                    }, function (e) {
                        console.error(e);
                        deferred.reject();
                    });

                return deferred.promise;
            },
        }
    });