'use strict';

describe('Controller: AdminproductcontrollerCtrl', function () {

  // load the controller's module
  beforeEach(module('sportsstoreApp'));

  var AdminproductcontrollerCtrl,
    scope;

  // Initialize the controller and a mock scope
  beforeEach(inject(function ($controller, $rootScope) {
    scope = $rootScope.$new();
    AdminproductcontrollerCtrl = $controller('AdminproductcontrollerCtrl', {
      $scope: scope
    });
  }));

  it('should attach a list of awesomeThings to the scope', function () {
    expect(scope.awesomeThings.length).toBe(3);
  });
});
