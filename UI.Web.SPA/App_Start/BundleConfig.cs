﻿using System;
using System.Web.Optimization;

namespace LearnByPractice.UI.Web
{
    public static class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            if (bundles == null) throw new ArgumentNullException("bundles");

            bundles.Add(new StyleBundle("~/bundles/css").Include(
                LibFile("bootstrap/dist/css/bootstrap.css"),
                LibFile("bootstrap/dist/css/bootstrap-theme.css"),
                LibFile("Font-Awesome/css/font-awesome.css"),

                AppFile("styles/Site.css")
            ));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include("~/Scripts/modernizr-2.8.3.js"));

            bundles.Add(new ScriptBundle("~/bundles/scripts").Include(
                LibFile("jquery/dist/jquery.js"),
                LibFile("bootstrap/dist/js/bootstrap.js"),
                LibFile("angular/angular.js"),
                LibFile("angular-bootstrap/ui-bootstrap.js"),
                LibFile("angular-bootstrap/ui-bootstrap-tpls.js"),
                LibFile("angular-ui-router/release/angular-ui-router.js")
                ));

            bundles.Add(new ScriptBundle("~/bundles/app").Include(
                AppFile("app.module.js"),
                AppFile("app.js")
                ));
        }

        private static string LibFile(string filePath)
        {
            return string.Concat("~/wwwroot/lib/", filePath);
        }

        private static string AppFile(string filePath)
        {
            return string.Concat("~/wwwroot/app/", filePath);
        }
    }
}