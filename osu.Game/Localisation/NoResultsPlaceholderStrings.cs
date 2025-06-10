// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using osu.Framework.Localisation;

namespace osu.Game.Localisation
{
    public static class NoResultsPlaceholderStrings
    {
        private const string prefix = @"osu.Game.Resources.Localisation.NoResultsPlaceholder";

        /// <summary>
        /// "No matching beatmaps"
        /// </summary>
        public static LocalisableString NoMatchingBeatmaps => new TranslatableString(getKey(@"no_matching_beatmaps"), @"No matching beatmaps");

        /// <summary>
        /// "No beatmaps match your filter criteria!"
        /// </summary>
        public static LocalisableString NoBeatmapsMatchYourFilter => new TranslatableString(getKey(@"no_beatmaps_match_your_filter"), @"No beatmaps match your filter criteria!");

        /// <summary>
        /// "Try "
        /// </summary>
        public static LocalisableString TryClearing => new TranslatableString(getKey(@"try_clearing"), @"Try ");

        /// <summary>
        /// "Try "
        /// </summary>
        public static LocalisableString TrySearchOnline => new TranslatableString(getKey(@"try_search_online"), @"Try ");

        /// <summary>
        /// "Try "
        /// </summary>
        public static LocalisableString TryRemoving => new TranslatableString(getKey(@"try_removing"), @"Try ");

        /// <summary>
        /// "Try "
        /// </summary>
        public static LocalisableString TryEnabling => new TranslatableString(getKey(@"try_enabling"), @"Try ");

        /// <summary>
        /// "clearing"
        /// </summary>
        public static LocalisableString Clearing => new TranslatableString(getKey(@"clearing"), @"clearing");

        /// <summary>
        /// " your current search criteria."
        /// </summary>
        public static LocalisableString YourCurrentSearchCriteria => new TranslatableString(getKey(@"your_current_search_criteria"), @" your current search criteria.");

        /// <summary>
        /// "removing"
        /// </summary>
        public static LocalisableString Removing => new TranslatableString(getKey(@"removing"), @"removing");

        /// <summary>
        /// " the {0} - {1} star difficulty filter."
        /// </summary>
        public static LocalisableString TheStarDifficultyFilter(string lowerStar, string upperStar) => new TranslatableString(getKey(@"the_star_difficulty_filter"), @" the {0} - {1} star difficulty filter.", lowerStar, upperStar);

        /// <summary>
        /// "enabling "
        /// </summary>
        public static LocalisableString Enabling => new TranslatableString(getKey(@"enabling"), @"enabling ");

        /// <summary>
        /// "automatic conversion!"
        /// </summary>
        public static LocalisableString AutomaticConversion => new TranslatableString(getKey(@"automatic_conversion"), @"automatic conversion!");

        /// <summary>
        /// "searching online"
        /// </summary>
        public static LocalisableString SearchingOnline => new TranslatableString(getKey(@"searching_online"), @"searching online");

        /// <summary>
        /// " for &quot;{0}&quot;."
        /// </summary>
        public static LocalisableString For(string arg0) => new TranslatableString(getKey(@"for"), @" for ""{0}"".", arg0);

        /// <summary>
        /// "Consider running the &quot;"
        /// </summary>
        public static LocalisableString ConsiderRunningThe => new TranslatableString(getKey(@"consider_running_the"), @"Consider running the """);

        /// <summary>
        /// "&quot; to download or import some beatmaps!"
        /// </summary>
        public static LocalisableString ToDownloadOrImportSome => new TranslatableString(getKey(@"to_download_or_import_some"), @""" to download or import some beatmaps!");

        private static string getKey(string key) => $@"{prefix}:{key}";
    }
}
