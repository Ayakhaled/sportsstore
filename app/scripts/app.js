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
        $routeProvider.when("/complete", {
            templateUrl: "views/thankyou.html"
        });
        $routeProvider.when("/placeorder", {
            templateUrl: "views/placeorder.html"
        });
        $routeProvider.when("/checkout", {
            templateUrl: "views/checkoutsummary.html"
        });
        $routeProvider.when("/products", {
            templateUrl: "views/productlist.html"
        });
        $routeProvider.otherwise({
            templateUrl: "views/productlist.html"
        });
    });
