app.directive('initTable', function () {
    return {

        restrict: 'A',
        link: function (scope, el, attrs) {
            var opts = scope.$eval(attrs.initTable);
            el.bootstrapTable(opts);

            /* opts.onLoadSuccess = function () {
                  $compile(el.contents())(scope);
              };*/

        }

    };
});

app.controller('myController2', ['$scope', '$window', 'htoexSvc', '$http', function ($scope, $window, htoexSvc, $http) {
    /* $('#topheader .navbar-nav a').on('click', function () {
         $('#topheader .navbar-nav').find('li.active').removeClass('active');
         $(this).parent('li').addClass('active');
     });*/
    $scope.showTable = false;
    $scope.homeValues = htoexSvc.getJson();
    $scope.scaleUnit = [{ name: 'MSUA01', value: 1 }, { name: 'LSUA01', value: 2 }, { name: 'MSUA02', value: 3 }, { name: 'LSUA02', value: 4 }, { name: 'MSUA03', value: 5 }];
    $scope.getData = function () {
        /*$http.get('https://jsonplaceholder.typicode.com/posts').success(function (response) {            
                $scope.reqData = response.data;
                console.log($scope.reqData);            
        }).error(function (response) {
            $scope.reqData = response.data;
        })*/
        $scope.showTable = false;
        var urls = "https://jsonplaceholder.typicode.com/posts";
        if ($scope.reqData != undefined)
            urls = urls + '/1';
        $http({
            url: urls,
            method: 'GET'
        }).then(function (response) {
            var data = [];
            if ($scope.reqData != undefined) {
                data.push(response.data)
                $scope.reqData = data;
            }
            else
            $scope.reqData = response.data;
            $scope.status = response.status;
            console.log($scope.reqData);
            $scope.options = {
                data: $scope.reqData,
                pagination: true,
                striped: true,
                search: true,
                //pageScroll: true,                
                //overflow: scroll,
                showColumns: true,
                columns: [
                    {
                        //field: 'state',
                        checkbox: true
                    }, {
                        field: 'userId',
                        title: 'User ID'
                    },
            {
                field: 'id',
                title: 'ID'
            },
            {
                field: 'title',
                title: 'Title'
            },
            {
                field: 'body',
                title: 'Body'
            }]
            };
            
            $scope.showTable = true;

            $("#serversTable").on('check.bs.table', function (e, row) {
                debugger;
                $scope.checkedRows.push({ id: row.id, userid: row.userId, title: row.title, body: row.body });
                $.each($scope.checkedRows, function (index, value) {
                    $("#logData").append($('<li></li>').text(value.id + " | " + value.userid + " | " + value.title + " | " + value.body))
                })
            })



            //$scope.$apply();
            //$("#serversTable").bootstrapTable($scope.options)
            //$scope.showTable = true;
        }, function (response) {
            $scope.reqData = response.data;
            $scope.status = response.status;
        })

    };//getData() function end

   
}])