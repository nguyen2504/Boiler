app.filter('totalSumPriceQty',
  function() {
    return function(data, key1, key2) {
      if (window.angular.isUndefined(data) || window.angular.isUndefined(key1) || window.angular.isUndefined(key2))
        return 0;
      var sum = 0;
      window.angular.forEach(data,
        function(value) {
          sum = sum + (parseInt(value[key1], 10) * parseInt(value[key2], 10));
        });
      return sum;
    }
  });
app.filter('total', function () {
  return function (input, property) {
    var i =  input.length;
    var total = 0;
    while (i--)
      total += input[i][property];
    return total;
  }
});