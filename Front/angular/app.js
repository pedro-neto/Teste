var crud = angular.module("crud", []);

crud.controller("controller", function ($scope) {

   $scope.novoCliente = {};
   $scope.clienteSelecionado = {};

   $scope.clientes = [
     {Nome: "Pedro", Sobrenome:"Neto", CPF: "434.888.938-24", DataNascimento: "04/12/1999", Idade: "22", Profissao:"Programador"},
     {Nome: "Carlos", Sobrenome:"Ronaldo", CPF: "434.555.938-24", DataNascimento: "21/09/2001", Idade: "20", Profissao:"Estagiario"},
     {Nome: "Cesar", Sobrenome:"Silva", CPF: "023.844.938-24", DataNascimento: "01/11/1995", Idade: "27", Profissao:"QA"},
     {Nome: "Paulo", Sobrenome:"Marcos", CPF: "434.967.938-24", DataNascimento: "03/06/1998", Idade: "23", Profissao:"Analista"}
 ];
   
   $scope.salvar = function () {
       $scope.clientes.push($scope.novoCliente);
       $scope.novoCliente = {};
   };
   
   $scope.selecionaCliente = function (cliente) {
        $scope.clienteSelecionado = cliente;
   };

   $scope.alterarCliente = function () {
       
   };

   $scope.excluirCliente = function(){
        $scope.clientes.splice($scope.clientes.indexOf($scope.clienteSelecionado), 1);
   };   
});