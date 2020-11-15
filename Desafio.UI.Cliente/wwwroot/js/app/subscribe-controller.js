var app = angular.module("desafio", ['HttpService']);

app.controller("desafioController", ['$scope','service','$timeout',($scope,service,$timeout) => {

    $scope.loading = false;

    $scope.subscribe = (sub) => {

        $scope.loading = true;

        service.subscribe(sub).then((res) => {
            $scope.loading = false;
            Swal.fire("Sucesso!", "Inscrição realizada com sucesso!", "success");
        }).catch((res) => {

            $scope.loading = false;

                if (res.status === 404)
                    Swal.fire("Atenção", "Servidor fora do ar, tente mais tarde.", "warning");
                else
                    Swal.fire("Atenção", res.data, "warning");
        })
    }

}])