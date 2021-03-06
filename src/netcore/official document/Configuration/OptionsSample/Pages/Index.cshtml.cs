﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OptionsSample.Models;
using Microsoft.Extensions.Options;

namespace OptionsSample.Pages
{
    public class IndexModel : PageModel
    {
        private readonly MyOptions _options;
        private readonly MyOptionsWithDelegateConfig _optionsWithDelegateConfig;
        private readonly MySubOptions _subOptions;
        private readonly MyOptions _snapshotOptions;
        private readonly MyOptions _named_options_1;
        private readonly MyOptions _named_options_2;

        public IndexModel(
            IOptionsMonitor<MyOptions> optionsAccessor,
            IOptionsMonitor<MyOptionsWithDelegateConfig> optionsAccessorWithDelegateConfig,
            IOptionsMonitor<MySubOptions> subOptionsAccessor,
            IOptionsSnapshot<MyOptions> snapshotOptions,
            IOptionsSnapshot<MyOptions> snapshotOptionsAccessor,
            IOptionsSnapshot<MyOptions> namedOptionsAccessor
        )
        {
            _options = optionsAccessor.CurrentValue;
            _optionsWithDelegateConfig = optionsAccessorWithDelegateConfig.CurrentValue;
            _subOptions = subOptionsAccessor.CurrentValue;
            _snapshotOptions = snapshotOptions.Value;
            _named_options_1 = namedOptionsAccessor.Get("named_options_1");
            _named_options_2 = namedOptionsAccessor.Get("named_options_2");
        }

        public string SimpleOptions { get; private set; }
        public string SimpleOptionsWithDelegateConfig { get; private set; }
        public string SubOptions { get; private set; }
        public MyOptions MyOptions { get; private set; }
        public string SnapshotOptions { get; private set; }
        public string NamedOptions { get; private set; }

        public void OnGet()
        {
            var option1 = _options.Option1;
            var option2 = _options.Option2;
            SimpleOptions = $"option1 = {option1}, option2 = {option2}";

            var delegate_config_option1 = _optionsWithDelegateConfig.Option1;
            var delegate_config_option2 = _optionsWithDelegateConfig.Option2;
            SimpleOptionsWithDelegateConfig =
                $"delegate_option1 = {delegate_config_option1}, " +
                $"delegate_option2 = {delegate_config_option2}";

            var subOption1 = _subOptions.SubOption1;
            var subOption2 = _subOptions.SubOption2;
            SubOptions = $"subOption1 = {subOption1}, subOption2 = {subOption2}";


            MyOptions = _options;

            var snapshotOption1 = _snapshotOptions.Option1;
            var snapshotOption2 = _snapshotOptions.Option2;
            SnapshotOptions =
                $"snapshot option1 = {snapshotOption1}, " +
                $"snapshot option2 = {snapshotOption2}";


            var named_options_1 =
                $"named_options_1: option1 = {_named_options_1.Option1}, " +
                $"option2 = {_named_options_1.Option2}";
            var named_options_2 =
                $"named_options_2: option1 = {_named_options_2.Option1}, " +
                $"option2 = {_named_options_2.Option2}";
            NamedOptions = $"{named_options_1} {named_options_2}";
        }
    }
}
