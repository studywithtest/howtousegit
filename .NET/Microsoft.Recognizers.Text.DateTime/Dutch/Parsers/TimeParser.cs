﻿using DateObject = System.DateTime;

namespace Microsoft.Recognizers.Text.DateTime.Dutch
{
    public class TimeParser : BaseTimeParser
    {
        public TimeParser(ITimeParserConfiguration configuration)
            : base(configuration)
        {
        }

        protected override DateTimeResolutionResult InternalParse(string text, DateObject referenceTime)
        {
            var innerResult = base.InternalParse(text, referenceTime);
            if (!innerResult.Success)
            {
                innerResult = ParseIsh(text, referenceTime);
            }

            return innerResult;
        }

        // parse "noonish", "11-ish"
        private DateTimeResolutionResult ParseIsh(string text, DateObject referenceTime)
        {
            var ret = new DateTimeResolutionResult();
            var lowerText = text.ToLowerInvariant();

            var match = DutchTimeExtractorConfiguration.IshRegex.MatchExact(lowerText, trim: true);

            if (match.Success)
            {
                var hourStr = match.Groups[Constants.HourGroupName].Value;
                var hour = Constants.HalfDayHourCount;
                if (!string.IsNullOrEmpty(hourStr))
                {
                    hour = int.Parse(hourStr);
                }

                ret.Timex = "T" + hour.ToString("D2");
                ret.FutureValue =
                    ret.PastValue =
                        DateObject.MinValue.SafeCreateFromValue(referenceTime.Year, referenceTime.Month, referenceTime.Day, hour, 0, 0);
                ret.Success = true;
                return ret;
            }

            return ret;
        }
    }
}
