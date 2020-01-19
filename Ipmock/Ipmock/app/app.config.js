app.config(["$routeProvider", function ($routeProvider) {
    $routeProvider.when("/home", {
        templateUrl: "Templates/Home.html",
        controller: "myController1",
        activeTab:'Home'
    })
    .when("/", {
        templateUrl: "Templates/Home.html",
        controller: "myController1",
        activeTab: 'Execution'
    })
        .when("/exec", {
            templateUrl: "Templates/Execution.html",
            controller: "myController2",
           activeTab: 'Home'
        })

    .otherwise("/home");
}])
