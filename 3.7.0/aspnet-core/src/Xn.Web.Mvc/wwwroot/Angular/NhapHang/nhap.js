﻿app.controller('ctrl', ['$scope','$http', function($scope,$http) {
  FnNhap($scope, $http);
}]);

function FnNhap($scope, $http) {
  $scope.l = [];
  $scope.n = 2;
  $scope.getL = function() {
    for (var i = 0; i < $scope.n; i++) {
      $scope.Id = 0;
      $scope.TenNcc = "ncc";
      $scope.IdNcc = '1';
      $scope.TenHang = 'gg';
      $scope.SoLuong = 12;
      $scope.DonGiaMua = 34;
      $scope.Dvt = '123';
      $scope.IdCty = 0;
      $scope.MaDonHang = '12';
      $scope.MaVt = '12';
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
    $scope.tong();
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
  $scope.GetMaDh = function() {
    var url = 'Nhap/GetMaDh';
    $http.post(url).then(function (e) {
      $scope.MaDonHang1 = e.data.result;
      $scope.MaDonHang = e.data.result;
    });
  }

  $scope.tong = function() {
    //console.log('toi day '+$scope.l.length);
    $scope.sum = 0;
    for (var i = 0; i < $scope.l.length; i++) {
      $scope.sum += $scope.l[i].SoLuong * $scope.l[i].DonGiaMua;
    }
  }
  $scope.GetTenNcc = function () {
    var url = 'Nhap/GetTenNcc';
    $http.post(url).then(function (e) {
           var dt = e.data.result;
     console.log(JSON.stringify(dt));
    });
  };
  $scope.getAll = function() {
    var url = 'Nhap/GetAll';
    $http.post(url).then(function(e) {
      var dt = e.data.result;
      //console.log(JSON.stringify(dt));
      $scope.getTenHg = [];
      var dupes = {};
      $.each(dt, function (i, el) {

        if (!dupes[el.tenHang]) {
          dupes[el.tenHang] = true;
          $scope.getTenHg.push(el.tenHang);
        }
       
      });
      $scope.getTenHg.push('123');
      console.log(JSON.stringify($scope.getTenHg));
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
    var url = 'Nhap/CreateOrEdit/';
    var request = [];
    for (var i = 0; i < $scope.l.length; i++) {
      $scope.l[i].MaDonHang = $scope.MaDonHang1;
      request.push($scope.l[i]);
    }
    console.log(JSON.stringify(request));
    $http.post(url, request).then(function (e) {
      //var dt = e.data.result;
      console.log(e);
    });
    
  };
  function init() {
    $scope.names = ["Emil", "Tobias", "Linus"];
    $scope.GetMaDh();
    $scope.getAll();
    $scope.getL();
    $scope.GetTenNcc();
  }
  init();
};