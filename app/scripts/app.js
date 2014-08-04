'use strict';

/**
 * @ngdoc overview
 * @name sportsstoreApp
 * @description
 * # sportsstoreApp
 *
 * Main module of the application.
 */
angular
    .module('sportsstoreApp', [
    'ngAnimate',
    'ngCookies',
    'ngResource',
    'ngRoute',
    'ngSanitize',
    'ngTouch'
    ])
    .config(function ($routeProvider) {
        $routeProvider.when("/checkout", {
            templateUrl: "views/checkoutSummary.html"
        });
        $routeProvider.when("/products", {
            templateUrl: "views/productList.html"
        });
        $routeProvider.otherwise({
            templateUrl: "views/productList.html"
        });
    });
    //.config(function ($routeProvider) {
    //    $routeProvider
    //    .when('/', {
    //        templateUrl: 'views/productlist.html'
    //    })
    //    .otherwise({
    //        redirectTo: '/'
    //    });
    //});
