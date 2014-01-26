using System;
using System.Web.Optimization;

namespace MMFinanceManager.SPA {
  public class DurandalBundleConfig {
    public static void RegisterBundles(BundleCollection bundles) {
      bundles.IgnoreList.Clear();
      AddDefaultIgnorePatterns(bundles.IgnoreList);

	  bundles.Add(
		new ScriptBundle("~/Scripts/vendor")
			.Include("~/Scripts/jquery-{version}.js")
            .Include("~/Scripts/jquery-ui-{version}.js")
			.Include("~/Scripts/bootstrap.js")
			.Include("~/Scripts/knockout-{version}.js")
		);

      bundles.Add(
        new StyleBundle("~/Content/css")
          .Include("~/Content/ie10mobile.css")
          .Include("~/Content/bootstrap.min.css")
          .Include("~/Content/bootstrap-responsive.min.css")
          .Include("~/Content/font-awesome.min.css")
		  .Include("~/Content/durandal.css")
          .Include("~/Content/starterkit.css")
        );
        
      bundles.Add(new StyleBundle("~/Content/themes/base/css").Include(
                  "~/Content/themes/base/jquery.ui.core.css",
                  "~/Content/themes/base/jquery.ui.resizable.css",
                  "~/Content/themes/base/jquery.ui.selectable.css",
                  "~/Content/themes/base/jquery.ui.accordion.css",
                  "~/Content/themes/base/jquery.ui.autocomplete.css",
                  "~/Content/themes/base/jquery.ui.button.css",
                  "~/Content/themes/base/jquery.ui.dialog.css",
                  "~/Content/themes/base/jquery.ui.slider.css",
                  "~/Content/themes/base/jquery.ui.tabs.css",
                  "~/Content/themes/base/jquery.ui.datepicker.css",
                  "~/Content/themes/base/jquery.ui.progressbar.css",
                  "~/Content/themes/base/jquery.ui.theme.css"));
    }

    public static void AddDefaultIgnorePatterns(IgnoreList ignoreList) {
      if(ignoreList == null) {
        throw new ArgumentNullException("ignoreList");
      }

      ignoreList.Ignore("*.intellisense.js");
      ignoreList.Ignore("*-vsdoc.js");
      ignoreList.Ignore("*.debug.js", OptimizationMode.WhenEnabled);
      //ignoreList.Ignore("*.min.js", OptimizationMode.WhenDisabled);
      //ignoreList.Ignore("*.min.css", OptimizationMode.WhenDisabled);
    }
  }
}