var app = angular.module("HttpService", [])

app.service("service", function($http){

    this.subscribe = function(sub) {
        return $http.post("api/subscribe/subscription", sub);
    }

});