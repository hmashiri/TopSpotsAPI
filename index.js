(function() {
    'use strict';
    angular
        .module('app', [])
        .controller('MainController', MainController);

         MainController.$inject = ['$http'];
    /* @ngInject */
    function MainController($http) {
        var vm = this;
        vm.title = 'MainController';
        activate();
        ////////////////
        function activate() {
            $http({
                method:'GET',
                url: 'http://localhost:49874/api/TopSpots'
            })
            .then(function(response){
                vm.topspots = response.data;
            })
        }
    }
})();