'use strict';

angular.module("sportsStoreAdmin")
    .constant("authUrl", "http://localhost:56322/api/login")
    .controller("authCtrl", function($scope, $http, $location, authUrl) {
        $scope.authenticate = function(user, pass) {
            $http.post(authUrl, {
                username: user,
                password: pass
            }).success(function(data) {
                $location.path("/main");
            }).error(function(error) {
                $scope.authenticationError = error;
            });
        }
    });