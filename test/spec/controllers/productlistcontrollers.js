'use strict';

describe('Controller: ProductlistcontrollersCtrl', function () {

  // load the controller's module
  beforeEach(module('sportsstoreApp'));

  var ProductlistcontrollersCtrl,
    scope;

  // Initialize the controller and a mock scope
  beforeEach(inject(function ($controller, $rootScope) {
    scope = $rootScope.$new();
    ProductlistcontrollersCtrl = $controller('ProductlistcontrollersCtrl', {
      $scope: scope
    });
  }));

  it('should attach a list of awesomeThings to the scope', function () {
    expect(scope.awesomeThings.length).toBe(3);
  });
});
