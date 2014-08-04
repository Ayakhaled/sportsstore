'use strict';

describe('Directive: cartSummary', function () {

  // load the directive's module
  beforeEach(module('sportsstoreApp'));

  var element,
    scope;

  beforeEach(inject(function ($rootScope) {
    scope = $rootScope.$new();
  }));

  it('should make hidden element visible', inject(function ($compile) {
    element = angular.element('<cart-summary></cart-summary>');
    element = $compile(element)(scope);
    expect(element.text()).toBe('this is the cartSummary directive');
  }));
});
