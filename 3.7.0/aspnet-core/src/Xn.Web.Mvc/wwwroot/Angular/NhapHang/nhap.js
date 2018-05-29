app.controller('ctrl', ['$scope','$http', function($scope,$http) {
  FnNhap($scope, $http);
}]);

function FnNhap($scope, $http) {
  $scope.l = [];
  $scope.n = 2;
  $scope.getL = function() {
    for (var i = 0; i < $scope.n; i++) {
     
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
   
  }
  $scope.GetMaDh = function() {
    var url = 'Nhap/GetMaDh';
    $http.post(url).then(function (e) {
      $scope.MaDonHang1 = e.data.result;
      $scope.MaDonHang = e.data.result;
    });
  }

  $scope.tong = function() {
  
    $scope.sum = 0;
    for (var i = 0; i < $scope.l.length; i++) {
      $scope.sum += $scope.l[i].SoLuong * $scope.l[i].DonGiaMua;
    }
    $scope.conlai = $scope.sum - $scope.thanhtoan;
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
      $scope.dvts = [];
      var dupes = {};
      $.each(dt, function (i, el) {

        if (!dupes[el.tenHang]) {
          dupes[el.tenHang] = true;
          $scope.getTenHg.push(el.tenHang);
        }
        if (!dupes[el.dvt])
        {
          dupes[el.dvt] = true;
          $scope.dvts.push(el.dvt);
        }
       
      });
    
      console.log(JSON.stringify($scope.dvts));
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
    var item2 = {
      //Id: $scope.conlai,
      //TenNcc: '',
      //IdNcc:'',
      //TenHang: "",
      SoLuong: $scope.sum,
      DonGiaMua: $scope.thanhtoan,
      Dvt: 'dvt',
      MaDonHang: $scope.MaDonHang1,
      IsActive: 1,
      //NgayGhi: $scope.NgayGhi,
      //IdCty: $scope.IdCty,
     
     
      //MaVt: '00'
    };
    request.push(item2);
    console.log(JSON.stringify(request));
    $http.post(url, request).then(function (e) {
      //var dt = e.data.result;
      console.log(e);
    });
    
  };

  //-------------------- danh sach nhap xuat
  $scope.getNhapXuat = function() {
    var url = 'Nhap/GetNxs/';
    $http.post(url).then(function (e) {
      $scope.listnhap = e.data.result;
   
    });
  }
  function init() {
    $scope.names = ["Emil", "Tobias", "Linus"];
    $scope.GetMaDh();
    $scope.getAll();
    $scope.getL();
    $scope.GetTenNcc();
    $scope.getNhapXuat();
  }
  init();
};