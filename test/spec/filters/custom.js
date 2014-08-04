'use strict';

describe('Filter: custom', function () {

  // load the filter's module
  beforeEach(module('sportsstoreApp'));

  // initialize a new instance of the filter before each test
  var custom;
  beforeEach(inject(function ($filter) {
    custom = $filter('custom');
  }));

  it('should return the input prefixed with "custom filter:"', function () {
    var text = 'angularjs';
    expect(custom(text)).toBe('custom filter: ' + text);
  });

});
