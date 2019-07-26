using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Localization.Routing;
using System.Globalization;

namespace FiltersSample.Filters
{
    public class LocalizationPipeline
    {
        public void Configure(IApplicationBuilder applicationBuilder)
        {
            var supportCultures = new[]
            {
                new CultureInfo("en-US"),
                new CultureInfo("zh-CN")
            };

            var options = new RequestLocalizationOptions
            {
                DefaultRequestCulture = new RequestCulture(culture: "zh-CN", uiCulture: "zh-CN"),
                SupportedCultures = supportCultures,
                SupportedUICultures = supportCultures
            };

            options.RequestCultureProviders = new[]
            {
                new RouteDataRequestCultureProvider(){Options = options}
            };

            applicationBuilder.UseRequestLocalization(options);
        }
    }
}