﻿module app {
    "use strict";

    class Config {

        static $inject = [
            "$stateProvider",
            "$urlRouterProvider",
        ];

        constructor(
            $stateProvider: ng.ui.IStateProvider,
            $urlRouteProvider: ng.ui.IUrlRouterProvider) {

            var baseUrl = $("base").first().attr("href");

            let pochetnaConfig: ng.ui.IState = {
                name: "pochetna",
                url: "/",
                views: {
                    "@": {
                        templateUrl: "/wwwroot/app/index.html",
                        controller: app.InjectionIds.indexController,
                        controllerAs: "vm"
                    }
                }
            };
            $stateProvider.state("pochetna", pochetnaConfig);

            let adminConfig: ng.ui.IState = {
                name: "admin",
                url: "/admin",
                abstract: true
            };
            $stateProvider.state("admin", adminConfig);

            let predmetiConfig: ng.ui.IState = {
                name: "admin.predmeti",
                url: "/predmeti",
                views: {
                    "@": {
                        templateUrl: "/wwwroot/app/admin/predmeti/index.html",
                        controller: app.InjectionIds.admin_predmeti_indexController,
                        controllerAs: "vm"
                    }
                }
            };
            $stateProvider.state("admin.predmeti", predmetiConfig);
        }
    }

    angular
        .module("app")
        .config(Config);
}
