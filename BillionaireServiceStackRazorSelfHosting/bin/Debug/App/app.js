var app = angular.module('theApp',[]);

app.service('theService',function() {

    this.value = "Yes";

    this.setValue = function(someValue) {
        this.value = someValue;
    };

    this.saySomething = function(message) {
        alert(message);
        this.setValue(message);
    };

    this.getValue = function() {
        return this.value;
    };
})


function Yo($scope, theService) {

    $scope.TheWindow = window;

    $scope.message = 'This is very good';
    $scope.a = 3;
    $scope.b = 1;

    $scope.answer = function() {
        return $scope.a + $scope.b;
    };

    $scope.say = function() {
        theService.saySomething('Hello');
    };

    $scope.what = function() {
        return theService.getValue();
    };

    $scope.persons = [
        { Name : "John", Age : 40},
        { Name : "Paul", Age : 38},
        { Name : "George", Age : 37},
        { Name : "Ringo", Age : 40}
    ];
}