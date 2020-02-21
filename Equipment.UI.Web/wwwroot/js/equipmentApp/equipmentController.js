﻿app
    
    
    .controller("equipmentController", function ($scope, equipmentService, $q) {

        /**
         /* Загружает оборудование
         * @returns {}
         */
        $scope.LoadEquipmentAsync = function() {
            var deferred = $q.defer();
            
            $scope.EquipmentAreLoading = true;
            $scope.EquipmentLoadingErrors = false;

            equipmentService.GetEquipmentAsync()
                .then(function(equipment) {
                    $scope.Equipment = equipment;
                    deferred.resolve(equipment);
                })
                .catch(function() {
                    $scope.EquipmentLoadingErrors = true;
                    deferred.reject();
                })
                .finally(function() {
                    $scope.EquipmentAreLoading = false;
                });
            
            return deferred.promise;
        };

        //Загружаем оборудование
        $scope.LoadEquipmentAsync()
            .then(function (equipment) {
                $scope.Roles = equipment.map(function (eq) { return eq.role }).distinct();
                $scope.Types = equipment.map(function (eq) { return eq.type }).distinct();
                
                $scope.SelectedRoles = $scope.SelectedTypes = [];
            });
        
        $scope.AddOrRemoveItem = function(item, array){
            if(array.contains(item)){
                array.remove(item);
            }
            else{
                array.push(item);
            }
        }
    });