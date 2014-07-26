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
  .module('sportsStore', [
    'ngAnimate',
    'ngCookies',
    'ngResource',
    'ngRoute',
    'ngSanitize',
    'ngTouch'
  ])
  .config(function ($routeProvider) {
    $routeProvider
      .when('/', {
        templateUrl: 'views/main.html',
        controller: 'MainCtrl'
      })
      .otherwise({
        redirectTo: '/'
      });
  });
