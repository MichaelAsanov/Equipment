app

/**
 * Фильтр по ролям и типам
  */
    .filter("filterByRoleAndType", function(){
   return function(equipment, roles, types){
       roles = roles || [];
       types = types || [];
       
       if(roles.length || types.length){
           var filtered = equipment.filter(function (eq) {
               return roles.contains(eq.role) || types.contains(eq.type);
           });
           
           return filtered;
       }
       else {
           return equipment;
       }
   } 
});