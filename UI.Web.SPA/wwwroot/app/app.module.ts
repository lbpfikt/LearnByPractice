﻿((): void => {
    "use strict";

    angular.module("app", [
        // Надворешни референци
        "ui.router",
        "ui.bootstrap",

        // Апликациски модули
        "app.model",
        "app.services",
        "app.base",
        "app.admin"
    ]);
})();