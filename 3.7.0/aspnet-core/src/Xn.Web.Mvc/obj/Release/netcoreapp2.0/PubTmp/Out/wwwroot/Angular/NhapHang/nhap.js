app.controller('ctrl', ['$scope','$http', function($scope,$http) {
  FnNhap($scope, $http);
}]);

function FnNhap($scope, $http) {
  $scope.l = [];
  $scope.n = 15;
  $scope.getL = function() {
    for (var i = 0; i < $scope.n; i++) {
      $scope.Id = 0;
      $scope.TenNcc = "";
      $scope.IdNcc = '';
      $scope.TenHang = '';
      $scope.SoLuong = '';
      $scope.DonGiaMua = '';
      $scope.Dvt = '';
      $scope.IdCty = 5;
      $scope.MaDonHang = '';
      $scope.MaVt = i;
      $scope.NgayGhi = new Date().toLocaleDateString();
      var item = {
        Id: $scope.Id,
        TenNcc: $scope.TenNcc,
        IdNcc: $scope.IdNcc,
        TenHang: $scope.TenHang,
        SoLuong: $scope.SoLuong,
        DonGiaMua: $scope.DonGiaMua,
        Dvt: $scope.Dvt,
        NgayGhi: $scope.NgayGhi,
        IdCty: $scope.IdCty,
        MaDonHang: $scope.MaDonHang,
        IsActive: 1,
        MaVt: $scope.MaVt
      };
      $scope.l.push(item);
    }
    //console.log(JSON.stringify($scope.l));
    //var item1 = {
    //  Id: $scope.Id[i],
    //  TenNcc: $scope.TenNcc[i],
    //  IdNcc: $scope.IdNcc[i],
    //  TenHang: $scope.TenHang[i],
    //  SoLuong: $scope.SoLuong[i],
    //  DonGiaMua: $scope.DonGiaMua[i],
    //  Dvt: $scope.Dvt[i],
    //  NgayGhi: $scope.NgayGhi[i],
    //  IdCty: $scope.IdCty,
    //  MaDonHang: $scope.MaDonHang,
    //  IsActive: 1,
    //  MaVt: $scope.MaVt[i]
    //};
  }
  $scope.getAll = function() {
    var url = 'Nhap/GetAll';
    $http.post(url).then(function(e) {
      var dt = e.data.result;
      //console.log(JSON.stringify(dt));
    });
  };
  $scope.onChange = function() {  
    if ($scope.chonGiay == 4) {
      $scope.gWidth = '210mm';
      $scope.gHeight = '297mm';
    };
    if ($scope.chonGiay == 5) {
      $scope.gWidth = '148mm';
      $scope.gHeight = '210mm';
    }
    localStorage.setItem("w", $scope.gWidth);
    localStorage.setItem("h", $scope.gHeight);
  };
  $scope.onSubmit = function () {
  
    console.log(JSON.stringify($scope.l));
  };
  function init() {
   
    if (typeof (Storage) !== "undefined") {
      // Store
      $scope.gWidth = '148mm';
      $scope.gHeight = '210mm';
      localStorage.setItem("w", $scope.gWidth);
      localStorage.setItem("h", $scope.gHeight);
      // Retrieve
      console.log(localStorage.getItem("w"));
    } else {
      document.getElementById("result").innerHTML = "Sorry, your browser does not support Web Storage...";
    }
    $scope.getAll();
    $scope.getL();
  }
  init();
};