﻿using System.Web;
using System.Web.Optimization;

namespace MvcView
{
  public class BundleConfig
  {
    // バンドルの詳細については、http://go.microsoft.com/fwlink/?LinkId=301862  を参照してください
    public static void RegisterBundles(BundleCollection bundles)
    {
      bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                  "~/Scripts/jquery-{version}.js"));

      bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                  "~/Scripts/jquery.validate*"));

      bundles.Add(new ScriptBundle("~/bundles/jqueryui").Include(
                  "~/Scripts/jquery-ui-{version}.js",
                  "~/Scripts/app.js"));
      bundles.Add(new StyleBundle("~/Content/jqueryui").Include(
                  "~/Content/themes/base/minified/jquery-ui.min.css"));

      // 開発と学習には、Modernizr の開発バージョンを使用します。次に、実稼働の準備が
      // できたら、http://modernizr.com にあるビルド ツールを使用して、必要なテストのみを選択します。
      bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                  "~/Scripts/modernizr-*"));

      bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                "~/Scripts/bootstrap.js",
                "~/Scripts/respond.js"));

      bundles.Add(new StyleBundle("~/Content/css").Include(
                "~/Content/bootstrap.css",
                "~/Content/site.css"));

      // デバッグを行うには EnableOptimizations を false に設定します。詳細については、
      // http://go.microsoft.com/fwlink/?LinkId=301862 を参照してください
      BundleTable.EnableOptimizations = true;
    }
  }
}
