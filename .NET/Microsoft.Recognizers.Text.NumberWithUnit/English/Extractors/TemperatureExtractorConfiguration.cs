﻿using System.Collections.Immutable;
using System.Globalization;
using System.Text.RegularExpressions;

using Microsoft.Recognizers.Definitions;
using Microsoft.Recognizers.Definitions.English;

namespace Microsoft.Recognizers.Text.NumberWithUnit.English
{
    public class TemperatureExtractorConfiguration : EnglishNumberWithUnitExtractorConfiguration
    {
        public static readonly ImmutableDictionary<string, string> TemperatureSuffixList =
            NumbersWithUnitDefinitions.TemperatureSuffixList.ToImmutableDictionary();

        private static readonly ImmutableList<string> AmbiguousValues =
            NumbersWithUnitDefinitions.AmbiguousTemperatureUnitList.ToImmutableList();

        private static readonly Regex AmbiguousUnitMultiplierRegex =
            new Regex(BaseUnits.AmbiguousUnitNumberMultiplierRegex, RegexOptions.None);

        public TemperatureExtractorConfiguration()
               : this(new CultureInfo(Culture.English))
        {
        }

        public TemperatureExtractorConfiguration(CultureInfo ci)
               : base(ci)
        {
        }

        public override ImmutableDictionary<string, string> SuffixList => TemperatureSuffixList;

        public override ImmutableDictionary<string, string> PrefixList => null;

        public override ImmutableList<string> AmbiguousUnitList => AmbiguousValues;

        public override string ExtractType => Constants.SYS_UNIT_TEMPERATURE;

        public override Regex AmbiguousUnitNumberMultiplierRegex => AmbiguousUnitMultiplierRegex;
    }
}