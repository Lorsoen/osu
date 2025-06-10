// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using osu.Framework.Localisation;

namespace osu.Game.Localisation
{
    public static class BeatmapCarouselFilterGroupingStrings
    {
        private const string prefix = @"osu.Game.Resources.Localisation.BeatmapCarouselFilterGrouping";

        /// <summary>
        /// "Other"
        /// </summary>
        public static LocalisableString Other => new TranslatableString(getKey(@"other"), @"Other");

        /// <summary>
        /// "Today"
        /// </summary>
        public static LocalisableString Today => new TranslatableString(getKey(@"today"), @"Today");

        /// <summary>
        /// "Yesterday"
        /// </summary>
        public static LocalisableString Yesterday => new TranslatableString(getKey(@"yesterday"), @"Yesterday");

        /// <summary>
        /// "Last week"
        /// </summary>
        public static LocalisableString LastWeek => new TranslatableString(getKey(@"last_week"), @"Last week");

        /// <summary>
        /// "1 month ago"
        /// </summary>
        public static LocalisableString MonthAgo => new TranslatableString(getKey(@"month_ago"), @"1 month ago");

        /// <summary>
        /// "Over 5 months ago"
        /// </summary>
        public static LocalisableString OverMonthsAgo => new TranslatableString(getKey(@"over_months_ago"), @"Over 5 months ago");

        /// <summary>
        /// "Unranked"
        /// </summary>
        public static LocalisableString Unranked => new TranslatableString(getKey(@"unranked"), @"Unranked");

        /// <summary>
        /// "Over 300 BPM"
        /// </summary>
        public static LocalisableString OverBPM => new TranslatableString(getKey(@"over_bpm"), @"Over 300 BPM");

        /// <summary>
        /// "Below 1 Star"
        /// </summary>
        public static LocalisableString BelowStar => new TranslatableString(getKey(@"below_star"), @"Below 1 Star");

        /// <summary>
        /// "1 Star"
        /// </summary>
        public static LocalisableString Star => new TranslatableString(getKey(@"star"), @"1 Star");

        /// <summary>
        /// "1 minute or less"
        /// </summary>
        public static LocalisableString MinuteOrLess => new TranslatableString(getKey(@"minute_or_less"), @"1 minute or less");

        /// <summary>
        /// "{0} minutes or less"
        /// </summary>
        public static LocalisableString MinutesOrLess(int i) => new TranslatableString(getKey(@"minutes_or_less"), @"{0} minutes or less", i);

        /// <summary>
        /// "10 minutes or less"
        /// </summary>
        public static LocalisableString MinutesOrLess1 => new TranslatableString(getKey(@"minutes_or_less1"), @"10 minutes or less");

        /// <summary>
        /// "Over 10 minutes"
        /// </summary>
        public static LocalisableString OverMinutes => new TranslatableString(getKey(@"over_minutes"), @"Over 10 minutes");

        /// <summary>
        /// "{0} Stars"
        /// </summary>
        public static LocalisableString Stars(int starInt) => new TranslatableString(getKey(@"stars"), @"{0} Stars", starInt);

        /// <summary>
        /// "Under {0} BPM"
        /// </summary>
        public static LocalisableString UnderBPM(int arg0) => new TranslatableString(getKey(@"under_bpm"), @"Under {0} BPM", arg0);

        /// <summary>
        /// "{0} months ago"
        /// </summary>
        public static LocalisableString MonthsAgo(int arg0) => new TranslatableString(getKey(@"months_ago"), @"{0} months ago", arg0);

        /// <summary>
        /// "Never"
        /// </summary>
        public static LocalisableString Never => new TranslatableString(getKey(@"never"), @"Never");

        private static string getKey(string key) => $@"{prefix}:{key}";
    }
}