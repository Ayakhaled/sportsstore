'use strict';

describe('Controller: ProductlistcontrollerCtrl', function () {

  // load the controller's module
  beforeEach(module('appApp'));

  var ProductlistcontrollerCtrl,
    scope;

  // Initialize the controller and a mock scope
  beforeEach(inject(function ($controller, $rootScope) {
    scope = $rootScope.$new();
    ProductlistcontrollerCtrl = $controller('ProductlistcontrollerCtrl', {
      $scope: scope
    });
  }));

  it('should attach a list of awesomeThings to the scope', function () {
    expect(scope.awesomeThings.length).toBe(3);
  });
});
