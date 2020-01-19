app.controller('myController1', ['$scope', '$window', 'htoexSvc', '$location', function ($scope, $window, htoexSvc, $location) {
       /* $('#topheader .navbar-nav a').on('click', function () {
        $('#topheader .navbar-nav').find('li.active').removeClass('active');
        $(this).parent('li').addClass('active');
    });*/
    $scope.homeData = {};
    htoexSvc.setJson({});
    $scope.name = "Sandeep";
    $scope.env = [{ name: 'PE', value: 1 }, { name: 'Support-PPE', value: 2 }, { name: 'Ctip', value: 3 }, { name: 'Production', value: 4 }, { name: 'Spares', value: 5 }];
    $scope.selectStatus = true;
    $scope.checkdis = function () {
        $scope.selectStatus = ($scope.enviro != undefined && $scope.affin != undefined) ? false : true;
    }
    //$scope.loc = $location.path();
    $scope.popUp = function (path) {
        $scope.homeData = { enData: $scope.enviro, affData: $scope.affin };
        htoexSvc.setJson($scope.homeData);
        $location.path(path);
        //$("li#ho").removeClass("active");
        //$("li#ex").addClass("active");

    }

}])