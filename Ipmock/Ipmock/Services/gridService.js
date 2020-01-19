app.factory('htoexSvc', function () {
    var myJsonobj = [];
    return {
        getJson: function () {
            return myJsonobj;
        },
        setJson:function(value){
            myJsonobj = value;
    }
    }
})