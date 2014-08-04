'use strict';

angular.module('sportsstoreApp')
  .directive('cartSummary', function () {
      return {
          restrict: 'E',
          templateUrl: 'templates/cartsummary.html',
          controller: function ($scope, cart) {
              var cartData = cart.getProducts();
              $scope.total = function () {
                  var total = 0;
                  for (var i = 0; i < cartData.length; i++) {
                      total += (cartData[i].price * cartData[i].count);
                  }
                  return total;
              };
              $scope.itemCount = function () {
                  var total = 0;
                  for (var i = 0; i < cartData.length; i++) {
                      total += cartData[i].count;
                  }
                  return total;
              };
          }
      };
  });
