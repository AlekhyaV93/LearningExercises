app.controller("dptCtrl", function ($scope,$http) {

   $scope.revealEmployeeTable = false;   
    $scope.message = '';
    $scope.listOfDepartments = null;
    getAllDepartments();
    function getAllDepartments() {
        $http.get('http://localhost/FirstMVCDemo/Department/GetAllDepartments').success(function (data, status, headers, config) {
            $scope.listOfDepartments = data;
        }).error(function (data, status, headers, config) {
            $scope.error = [];
            $scope.message = 'Unexpected error';
            console.log($scope.message);
        })
    }

    $scope.listOfEmployees = null;
    $scope.getEmployeesByID = function (x) {
        
       
        $http.get('http://localhost/FirstMVCDemo/Department/GetEmployeeByDptID/' + x).success(function (data, status, headers, config) {

            $scope.listOfEmployees = data;
            $scope.revealEmployeeTable = true;
           
            
            
        }).error(function (data, status, headers, config) {
            $scope.error = [];
            $scope.message = 'Unexpected error';
            console.log($scope.message);
        })
    }

}).config(function ($locationProvider) {
    $locationProvider.html5Mode(true);
});;

/*
app.controller("empctrl", function ($scope, $http) {
    $scope.revealEmployeeTable = "False";
    $scope.message = '';
    $scope.listOfEmployees = null;
    getEmployeesByID();
    function getEmployeesByID(x) {
        $scope.revealEmployeeTable = "True";
        $http.get('http://localhost/FirstMVCDemo/Department/GetEmployeeByDptID/x').success(function (data, status, headers, config) {
            $scope.listOfEmployees = data;
        }).error(function (data, status, headers, config) {
            $scope.error = [];
            $scope.message = 'Unexpected error';
            console.log($scope.message);
        })
    }
})
*/