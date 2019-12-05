app.controller("empCtrl", function ($scope,$http,$window) {
    
    $scope.listOfAllEmployees = {};
    //$scope.empModel = {};//on button click how to use empModel
    $scope.message = "";    
    $scope.newEmp = {};
    $scope.saveValue = false;
    $scope.updateValue = true;
    
   // $scope.savedMessage = false;

    
    getAllEmployees();
    function getAllEmployees() {
        $http.get('http://localhost/FirstMVCDemo/EFEmployee/GetAllData').success(function (data, status, headers, config) {
            $scope.listOfAllEmployees = data;
        }).error(function (data,status,headers,config) {
            $scope.error = [];
            $scope.message = "Unexpected Error";
            console.log($scope.message);
        })
    }

    $scope.selectedEmplDetails = null;
    $scope.getEmplById = function (id) {

        $scope.saveValue = true;
        $scope.updateValue = false;

        $http.get('http://localhost/FirstMVCDemo/EFEmployee/GetDataByEmployeeId/'+ id).success(function (data, status, headers, config) {
            $scope.newEmp = data;

        }).error(function (data, status, headers, config) {
            $scope.message = "Error";
            console.log($scope.message);
        })
       
    }

    $scope.saveEmplDetails = function (newEmp) {
        //On successfuly saving the data we are assigning newEmp to empty object newEmp={} than because of model binding that
        //empty values are getting binded to input fields and beacuause of required field validation input fields are showing error
        //messages therefore we declare submitted .
        $scope.submitted = true;
        //should we pass newEmpData as a parameter to save func?
        var newEmpData = JSON.stringify(newEmp);

        $http.post('http://localhost/FirstMVCDemo/EFEmployee/SaveEmpDetails', newEmpData).success(function (data, headers, config, status) {

            $scope.message = data;
            console.log($scope.message);
            $scope.newEmp = {};
            $scope.submitted = false;

            var answer = confirm("The Employee Data has been saved successfully...Do you wish to refresh the Employee Details??")
            if (answer) {
                getAllEmployees();
            }

        }).error(function (data,headers,config,status) {
            $scope.message = "Error saving data";
            console.log($scope.message);
        })

    }

    $scope.updateEmplDetails = function (newEmp) {
        $scope.submitted = true;
        var editedEmplDetails = JSON.stringify(newEmp);
        $http.post('http://localhost/FirstMVCDemo/EFEmployee/updateEmpDetails', editedEmplDetails).success(function (data, headers, config, status) {
            $scope.message = data;
            console.log($scope.message);
            $scope.newEmp = {};
            $scope.submitted = false;

            var answer = confirm("The Employee Data has been Updated Successfully...Do you wish to refresh the Employee Details??")
            if (answer) {
                getAllEmployees();
            }
        }).error(function (data,headers,status,config) {
            $scope.message = "Error updating data";
            console.log($scope.message);
        })
    }


    $scope.deleteemplDetails = function (empModel) {
        var id = {}
        id.id = empModel.employeeID;
        var emplId = JSON.stringify(id);

        var conf = confirm('You are about to delete ' + empModel.employeeName + '. Are you Sure?')
        
        $http.post('http://localhost/FirstMVCDemo/EFEmployee/DelEmpDetails', emplId).success(function (data, headers, config, status) {
                $scope.message = data;
                console.log($scope.message);
                getAllEmployees();
                $window.alert("Employee has been Deleted");


            }).error(function (data,headers,status,config) {
            $scope.message = "Error deleting data";
            console.log($scope.message);
        })
             
    }

    

})