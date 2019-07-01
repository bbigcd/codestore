using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ConfigurationSample.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;

namespace ConfigurationSample.Pages
{
    public class IndexModel : PageModel
    {
        private readonly IConfiguration _config;

        public IndexModel(IConfiguration config)
        {
            _config = config;
        }

        public IEnumerable<KeyValuePair<string, string>> FilteredConfiguration { get; private set; }
        public ArrayExample ArrayExample { get; private set; }
        public JsonArrayExample JsonArrayExample { get; private set; }
        public Starship Starship { get; private set; }
        public TvShow TvShow { get; private set; }

        public void OnGet()
        {
            var configEntryFilter = new string[] { "ASPNETCORE_", "urls", "Logging", "ENVIRONMENT", "contentRoot", "AllowedHosts", "applicationName", "CommandLine" };

            var config = _config.AsEnumerable();

            FilteredConfiguration = config.Where(
                kvp => config.Any(
                    i => configEntryFilter.Any(prefix => kvp.Key.StartsWith(prefix))));

            ArrayExample = _config.GetSection("array").Get<ArrayExample>();

            JsonArrayExample = _config.GetSection("json_array").Get<JsonArrayExample>();

            TvShow = _config.GetSection("tvshow").Get<TvShow>();

            var starship = new Starship();
            _config.GetSection("starship").Bind(starship);
            Starship = starship;

        }
    }
}
