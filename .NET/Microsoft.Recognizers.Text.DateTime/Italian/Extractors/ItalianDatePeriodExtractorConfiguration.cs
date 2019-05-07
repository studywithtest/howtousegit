﻿using System.Collections.Generic;
using System.Text.RegularExpressions;
using Microsoft.Recognizers.Definitions;
using Microsoft.Recognizers.Definitions.Italian;
using Microsoft.Recognizers.Text.Number;
using Microsoft.Recognizers.Text.Number.Italian;

namespace Microsoft.Recognizers.Text.DateTime.Italian
{
    public class ItalianDatePeriodExtractorConfiguration : BaseOptionsConfiguration, IDatePeriodExtractorConfiguration
    {
        // base regexes
        public static readonly Regex TillRegex = new Regex(
            DateTimeDefinitions.TillRegex, // until
            RegexOptions.Singleline);

        public static readonly Regex RangeConnectorRegex = new Regex(
            DateTimeDefinitions.RangeConnectorRegex, // and
            RegexOptions.Singleline);

        public static readonly Regex DayRegex =
            new Regex(
                DateTimeDefinitions.DayRegex,
                RegexOptions.Singleline);

        public static readonly Regex MonthNumRegex =
            new Regex(
                DateTimeDefinitions.MonthNumRegex,
                RegexOptions.Singleline);

        public static readonly Regex IllegalYearRegex =
            new Regex(
                BaseDateTime.IllegalYearRegex,
                RegexOptions.Singleline);

        public static readonly Regex YearRegex =
            new Regex(
                DateTimeDefinitions.YearRegex,
                RegexOptions.Singleline);

        public static readonly Regex WeekDayRegex =
            new Regex(
                DateTimeDefinitions.WeekDayRegex,
                RegexOptions.Singleline);

        public static readonly Regex RelativeMonthRegex =
            new Regex(
                DateTimeDefinitions.RelativeMonthRegex, // this month, next month, last month
                RegexOptions.Singleline);

        public static readonly Regex TimeUnitRegex =
           new Regex(DateTimeDefinitions.TimeUnitRegex, RegexOptions.Singleline);

        public static readonly Regex EngMonthRegex =
            new Regex(
                DateTimeDefinitions.EngMonthRegex,
                RegexOptions.Singleline);

        public static readonly Regex MonthSuffixRegex =
            new Regex(
                DateTimeDefinitions.MonthSuffixRegex, // in, of, no "on"...
                RegexOptions.Singleline);

        public static readonly Regex DateUnitRegex = new Regex(
            DateTimeDefinitions.DateUnitRegex, // year, month, week, day
            RegexOptions.Singleline);

        public static readonly Regex PastPrefixRegex = // **In Italian, Past/Next is suffix, but interface enforces this
            new Regex(
                DateTimeDefinitions.PastSuffixRegex, // past, last, previous
                RegexOptions.Singleline);

        public static readonly Regex NextPrefixRegex = // **In Italian, Past/Next is suffix, but interface enforces this
            new Regex(
                DateTimeDefinitions.NextSuffixRegex, // next, in
                RegexOptions.Singleline);

        public static readonly Regex FutureSuffixRegex =
            new Regex(
                DateTimeDefinitions.FutureSuffixRegex,
                RegexOptions.Singleline);

        public static readonly Regex ThisPrefexRegex =
            new Regex(
                DateTimeDefinitions.ThisPrefixRegex,
                RegexOptions.Singleline);

        // composite regexes
        public static readonly Regex SimpleCasesRegex =
            new Regex(
                DateTimeDefinitions.SimpleCasesRegex,
                RegexOptions.Singleline);

        public static readonly Regex MonthFrontSimpleCasesRegex =
            new Regex(
                DateTimeDefinitions.MonthFrontSimpleCasesRegex, // between 'x' until 'y', from 'x' until 'y'
                RegexOptions.Singleline);

        public static readonly Regex MonthFrontBetweenRegex =
            new Regex(
                DateTimeDefinitions.MonthFrontBetweenRegex,
                RegexOptions.Singleline);

        public static readonly Regex BetweenRegex =
            new Regex(
                DateTimeDefinitions.BetweenRegex,
                RegexOptions.Singleline);

        public static readonly Regex MonthWithYear =
            new Regex(
                DateTimeDefinitions.MonthWithYear,
                RegexOptions.Singleline);

        public static readonly Regex OneWordPeriodRegex =
            new Regex(
               DateTimeDefinitions.OneWordPeriodRegex,
               RegexOptions.Singleline); // a cote de - 'next to', cette - 'this', dernier - 'last' (always after the noun, i.e annee dernier - 'last year'

        public static readonly Regex MonthNumWithYear =
            new Regex(
                DateTimeDefinitions.MonthNumWithYear,
                RegexOptions.Singleline);

        public static readonly Regex WeekOfMonthRegex =
            new Regex(
                DateTimeDefinitions.WeekDayOfMonthRegex,
                RegexOptions.Singleline); // le/la - masc/fem 'the'

        public static readonly Regex WeekOfYearRegex =
            new Regex(
                DateTimeDefinitions.WeekOfYearRegex,
                RegexOptions.Singleline);

        public static readonly Regex FollowedDateUnit =
            new Regex(
                DateTimeDefinitions.FollowedDateUnit,
                RegexOptions.Singleline);

        public static readonly Regex NumberCombinedWithDateUnit =
            new Regex(
                DateTimeDefinitions.NumberCombinedWithDateUnit,
                RegexOptions.Singleline);

        public static readonly Regex QuarterRegex =
            new Regex(
                DateTimeDefinitions.QuarterRegex, // 1st quarter of this year, 2nd quarter of next/last year, etc
                RegexOptions.Singleline);

        public static readonly Regex QuarterRegexYearFront =
            new Regex(
                DateTimeDefinitions.QuarterRegexYearFront,
                RegexOptions.Singleline);

        public static readonly Regex AllHalfYearRegex =
            new Regex(
                DateTimeDefinitions.AllHalfYearRegex,
                RegexOptions.Singleline);

        public static readonly Regex SeasonRegex =
            new Regex(
                DateTimeDefinitions.SeasonRegex,
                RegexOptions.Singleline);

        public static readonly Regex WhichWeekRegex =
            new Regex(
                DateTimeDefinitions.WhichWeekRegex,
                RegexOptions.Singleline);

        public static readonly Regex WeekOfRegex =
            new Regex(
                DateTimeDefinitions.WeekOfRegex,
                RegexOptions.Singleline);

        public static readonly Regex MonthOfRegex =
            new Regex(
                DateTimeDefinitions.MonthOfRegex,
                RegexOptions.Singleline);

        // TODO: add regexs below
        public static readonly Regex RangeUnitRegex =
            new Regex(
                DateTimeDefinitions.RangeUnitRegex,
                RegexOptions.Singleline);

        public static readonly Regex InConnectorRegex =
            new Regex(
                DateTimeDefinitions.InConnectorRegex,
                RegexOptions.Singleline);

        public static readonly Regex WithinNextPrefixRegex =
          new Regex(
              DateTimeDefinitions.WithinNextPrefixRegex,
              RegexOptions.Singleline);

        public static readonly Regex RestOfDateRegex =
            new Regex(DateTimeDefinitions.RestOfDateRegex, RegexOptions.Singleline);

        public static readonly Regex LaterEarlyPeriodRegex =
            new Regex(DateTimeDefinitions.LaterEarlyPeriodRegex, RegexOptions.Singleline);

        public static readonly Regex WeekWithWeekDayRangeRegex =
            new Regex(DateTimeDefinitions.WeekWithWeekDayRangeRegex, RegexOptions.Singleline);

        public static readonly Regex YearPlusNumberRegex =
           new Regex(DateTimeDefinitions.YearPlusNumberRegex, RegexOptions.Singleline);

        public static readonly Regex DecadeWithCenturyRegex =
            new Regex(DateTimeDefinitions.DecadeWithCenturyRegex, RegexOptions.Singleline);

        public static readonly Regex YearPeriodRegex =
            new Regex(DateTimeDefinitions.YearPeriodRegex, RegexOptions.Singleline);

        public static readonly Regex ComplexDatePeriodRegex =
            new Regex(DateTimeDefinitions.ComplexDatePeriodRegex, RegexOptions.Singleline);

        public static readonly Regex RelativeDecadeRegex =
            new Regex(DateTimeDefinitions.RelativeDecadeRegex, RegexOptions.Singleline);

        public static readonly Regex ReferenceDatePeriodRegex =
            new Regex(DateTimeDefinitions.ReferenceDatePeriodRegex, RegexOptions.Singleline);

        public static readonly Regex AgoRegex =
            new Regex(DateTimeDefinitions.AgoRegex, RegexOptions.Singleline);

        public static readonly Regex LaterRegex =
            new Regex(DateTimeDefinitions.LaterRegex, RegexOptions.Singleline);

        public static readonly Regex LessThanRegex =
            new Regex(DateTimeDefinitions.LessThanRegex, RegexOptions.Singleline);

        public static readonly Regex MoreThanRegex =
            new Regex(DateTimeDefinitions.MoreThanRegex, RegexOptions.Singleline);

        public static readonly Regex CenturySuffixRegex =
            new Regex(DateTimeDefinitions.CenturySuffixRegex, RegexOptions.Singleline);

        private static readonly Regex FromRegex =
            new Regex(DateTimeDefinitions.FromRegex, RegexOptions.Singleline);

        private static readonly Regex ConnectorAndRegex =
            new Regex(DateTimeDefinitions.ConnectorAndRegex, RegexOptions.Singleline);

        private static readonly Regex BeforeRegex =
            new Regex(DateTimeDefinitions.BeforeRegex2, RegexOptions.Singleline);

        private static readonly Regex[] SimpleCasesRegexes =
        {
            SimpleCasesRegex,
            BetweenRegex,
            OneWordPeriodRegex,
            MonthWithYear,
            MonthNumWithYear,
            YearRegex,
            YearPeriodRegex,
            WeekOfMonthRegex,
            WeekOfYearRegex,
            MonthFrontBetweenRegex,
            MonthFrontSimpleCasesRegex,
            QuarterRegex,
            QuarterRegexYearFront,
            SeasonRegex,
            PastPrefixRegex,
            NextPrefixRegex,
            ThisPrefexRegex,
            LaterEarlyPeriodRegex,
            WeekWithWeekDayRangeRegex,
            YearPlusNumberRegex,
            DecadeWithCenturyRegex,
            RelativeDecadeRegex,
        };

        public ItalianDatePeriodExtractorConfiguration(IOptionsConfiguration config)
            : base(config)
        {
            DatePointExtractor = new BaseDateExtractor(new ItalianDateExtractorConfiguration(this));
            CardinalExtractor = Number.Italian.CardinalExtractor.GetInstance();
            DurationExtractor = new BaseDurationExtractor(new ItalianDurationExtractorConfiguration(this));
            NumberParser = new BaseNumberParser(new ItalianNumberParserConfiguration());
        }

        public IDateExtractor DatePointExtractor { get; }

        public IExtractor CardinalExtractor { get; }

        public IExtractor OrdinalExtractor { get; }

        public IDateTimeExtractor DurationExtractor { get; }

        public IParser NumberParser { get; }

        IEnumerable<Regex> IDatePeriodExtractorConfiguration.SimpleCasesRegexes => SimpleCasesRegexes;

        Regex IDatePeriodExtractorConfiguration.IllegalYearRegex => IllegalYearRegex;

        Regex IDatePeriodExtractorConfiguration.YearRegex => YearRegex;

        Regex IDatePeriodExtractorConfiguration.TillRegex => TillRegex;

        Regex IDatePeriodExtractorConfiguration.DateUnitRegex => DateUnitRegex;

        Regex IDatePeriodExtractorConfiguration.TimeUnitRegex => TimeUnitRegex;

        Regex IDatePeriodExtractorConfiguration.FollowedDateUnit => FollowedDateUnit;

        Regex IDatePeriodExtractorConfiguration.NumberCombinedWithDateUnit => NumberCombinedWithDateUnit;

        Regex IDatePeriodExtractorConfiguration.PreviousPrefixRegex => PastPrefixRegex;

        Regex IDatePeriodExtractorConfiguration.FutureRegex => NextPrefixRegex;

        Regex IDatePeriodExtractorConfiguration.FutureSuffixRegex => FutureSuffixRegex;

        Regex IDatePeriodExtractorConfiguration.WeekOfRegex => WeekOfRegex;

        Regex IDatePeriodExtractorConfiguration.MonthOfRegex => MonthOfRegex;

        Regex IDatePeriodExtractorConfiguration.RangeUnitRegex => RangeUnitRegex;

        Regex IDatePeriodExtractorConfiguration.InConnectorRegex => InConnectorRegex;

        Regex IDatePeriodExtractorConfiguration.WithinNextPrefixRegex => WithinNextPrefixRegex;

        Regex IDatePeriodExtractorConfiguration.YearPeriodRegex => YearPeriodRegex;

        Regex IDatePeriodExtractorConfiguration.ComplexDatePeriodRegex => ComplexDatePeriodRegex;

        Regex IDatePeriodExtractorConfiguration.RelativeDecadeRegex => RelativeDecadeRegex;

        Regex IDatePeriodExtractorConfiguration.ReferenceDatePeriodRegex => ReferenceDatePeriodRegex;

        Regex IDatePeriodExtractorConfiguration.AgoRegex => AgoRegex;

        Regex IDatePeriodExtractorConfiguration.LaterRegex => LaterRegex;

        Regex IDatePeriodExtractorConfiguration.LessThanRegex => LessThanRegex;

        Regex IDatePeriodExtractorConfiguration.MoreThanRegex => MoreThanRegex;

        Regex IDatePeriodExtractorConfiguration.CenturySuffixRegex => CenturySuffixRegex;

        Regex IDatePeriodExtractorConfiguration.MonthNumRegex => MonthNumRegex;

        string[] IDatePeriodExtractorConfiguration.DurationDateRestrictions => DateTimeDefinitions.DurationDateRestrictions;

        public bool GetFromTokenIndex(string text, out int index)
        {
            index = -1;
            var fromMatch = FromRegex.Match(text);
            if (fromMatch.Success)
            {
                index = fromMatch.Index;
            }

            return fromMatch.Success;
        }

        public bool GetBetweenTokenIndex(string text, out int index)
        {
            index = -1;
            var beforeMatch = BeforeRegex.Match(text);
            if (beforeMatch.Success)
            {
                index = beforeMatch.Index;
            }

            return beforeMatch.Success;
        }

        public bool HasConnectorToken(string text)
        {
            return ConnectorAndRegex.IsMatch(text);
        }
    }
}
