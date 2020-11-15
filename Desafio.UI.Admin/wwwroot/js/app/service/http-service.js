var app = angular.module("HttpService", [])

app.service("service", function($http){

    this.save = function(sub) {
        return $http.post("api/subscriptions", sub);
    }

    this.delete = function (id) {
        return $http.delete(`api/subscriptions/${id}`);
    }

    this.list = ()=> {
        return $http.get("api/subscriptions")
            .then((res) => {
                return res.data
            })
            .catch((res) => {

                if (res.status === 404)
                    Swal.fire("Atenção", "Servidor fora do ar, tente mais tarde.", "warning");
                else
                    Swal.fire("Atenção", res.data, "warning");
            })
    }

});