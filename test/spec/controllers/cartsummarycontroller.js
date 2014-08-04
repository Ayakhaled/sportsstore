'use strict';

describe('Controller: CartsummarycontrollerCtrl', function () {

  // load the controller's module
  beforeEach(module('sportsstoreApp'));

  var CartsummarycontrollerCtrl,
    scope;

  // Initialize the controller and a mock scope
  beforeEach(inject(function ($controller, $rootScope) {
    scope = $rootScope.$new();
    CartsummarycontrollerCtrl = $controller('CartsummarycontrollerCtrl', {
      $scope: scope
    });
  }));

  it('should attach a list of awesomeThings to the scope', function () {
    expect(scope.awesomeThings.length).toBe(3);
  });
});
