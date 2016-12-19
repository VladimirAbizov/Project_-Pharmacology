app.controller('TestCtrl', function ($scope, $http) {
    alert('load');

    $scope.OnClickButon = function () {
        alert('click');

        $.ajax({
            type: "GET",
            url: "http://localhost/webapi_iis/api/login/login?login=" + $scope.username + "&key=" + $scope.password
            // dataType: "html",
            //data: { login: $scope.username, key: $scope.password }
        })
          .done(function (msg) {alert("Data Saved: " + msg);
              if (msg == "OK")
              { $scope.status = "Запись найдена."; }
              else
              { $scope.status = "Записи нет на сервере."; }
              
          })
        .fail(function (msg) {
            alert('fail:' + msg.Text);
        });
    }
})