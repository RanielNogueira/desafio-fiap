var app = angular.module("desafio", ['HttpService','datatables']);

app.controller("desafioController", ['$scope','service','$timeout','DTOptionsBuilder',($scope,service,$timeout,DTOptionsBuilder) => {

    var lang = {
        "sEmptyTable": "Nenhum registro encontrado",
        "sInfo": "Mostrando de _START_ até _END_ de _TOTAL_ registros",
        "sInfoEmpty": "Mostrando 0 até 0 de 0 registros",
        "sInfoFiltered": "(Filtrados de _MAX_ registros)",
        "sInfoPostFix": "",
        "sInfoThousands": ".",
        "sLengthMenu": "_MENU_ resultados por página",
        "sLoadingRecords": "Carregando...",
        "sProcessing": "Processando...",
        "sZeroRecords": "Nenhum registro encontrado",
        "sSearch": "Pesquisar",
        "oPaginate": {
            "sNext": "Próximo",
            "sPrevious": "Anterior",
            "sFirst": "Primeiro",
            "sLast": "Último"
        },
        "oAria": {
            "sSortAscending": ": Ordenar colunas de forma ascendente",
            "sSortDescending": ": Ordenar colunas de forma descendente"
        },
        "select": {
            "rows": {
                "_": "Selecionado %d linhas",
                "0": "Nenhuma linha selecionada",
                "1": "Selecionado 1 linha"
            }
        }
    };

    $scope.dtOptions = DTOptionsBuilder.newOptions().withPaginationType('full_numbers').withDisplayLength(10).withLanguage(lang);

    $scope.loading = false;

    $scope.subscribe = (sub) => {

        $scope.loading = true;

        service.subscribe(sub).then(() => { $scope.loading = false; }).catch(() => { $scope.loading = false; })
       
    }

    $scope.list = [];

    $scope.listAll = async () => {

        $scope.list = await service.list();

        $scope.$apply();
    }

    $scope.listAll();

    $scope.details = (sub) => {

        $scope.formSub.$setPristine();

        $scope.formSub.$setUntouched();

        $scope.sub = angular.copy(sub);
      
        $("#modalDetails").modal("show");

    }

    $scope.save = (sub) => {
        $scope.loading = true;

        service.save(sub).then((res) => {
            $scope.loading = false;
            $scope.listAll();
            $("#modalDetails").modal("hide")
            Swal.fire("Sucesso!", "Inscrição atualizada com sucesso!", "success");
        })
            .catch((res) => {
                $scope.loading = false;

                if (res.status === 404)
                    Swal.fire("Atenção", "Servidor fora do ar, tente mais tarde.", "warning");
                else
                    Swal.fire("Atenção", res.data, "warning");
            })
    }

    $scope.delete = (id) => {

        service.delete(id).then((res) => {
            $scope.listAll();
            Swal.fire("Sucesso!", "Operação realizada com sucesso!", "success");
        }).catch((res) => {

            if (res.status === 404)
                Swal.fire("Atenção", "Servidor fora do ar, tente mais tarde.", "warning");
            else
                Swal.fire("Atenção", res.data, "warning");
        })
    }

}])