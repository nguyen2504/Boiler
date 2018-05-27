app.controller('ctrl', ['$scope', '$http', function ($scope, $http) {
  FnCompany($scope,$http);
}]);

function FnCompany($scope, $http) {
  $scope.getCompany = function() {
    var url = 'Company/GetCompany';
    $http.post(url).then(function(e) {
      var dt = e.data;
      console.log(JSON.stringify(dt));
    });
  }
  $scope.delete = function(id) {
    var url = 'Company/Delete?id='+id;
    $http.post(url).then(function (e) {
      var dt = e.data;
      
      $('.snackbar').val(dt);

      $('.snackbar').addClass('show');
      setTimeout(function () {
        $('.snackbar').removeClass('show');
      }, 3000);

    });
  }
  $scope.showEdit = false;
  $scope.onEdit = function() {
    $scope.showEdit = true;
  }
  $scope.showCreate = false;
  $scope.onCreate = function () {
    $scope.showCreate = true;
  }
  function intit() {
    $scope.getCompany();
    FnTest($scope, $http);
  }

  intit();
}