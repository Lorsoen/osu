// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using osu.Framework.Localisation;

namespace osu.Game.Localisation
{
    public static class ComposerDistanceSnapProviderStrings
    {
        private const string prefix = @"osu.Game.Resources.Localisation.ComposerDistanceSnapProvider";

        /// <summary>
        /// "Distance Spacing ({0})"
        /// </summary>
        public static LocalisableString DistanceSpacing(double arg0) => new TranslatableString(getKey(@"distance_spacing"), @"Distance Spacing ({0})", arg0);

        /// <summary>
        /// "D. S. ({0})"
        /// </summary>
        public static LocalisableString DS(double arg0) => new TranslatableString(getKey(@"ds"), @"D. S. ({0})", arg0);

        /// <summary>
        /// "current {0}x"
        /// </summary>
        public static LocalisableString CurrentX(double currentSnap) => new TranslatableString(getKey(@"current_x"), @"current {0}x", currentSnap);

        /// <summary>
        /// "Use current ({0}x)"
        /// </summary>
        public static LocalisableString UseCurrentX(double currentSnap) => new TranslatableString(getKey(@"use_current_x"), @"Use current ({0}x)", currentSnap);

        /// <summary>
        /// "Use current (unavailable)"
        /// </summary>
        public static LocalisableString UseCurrentUnavailable => new TranslatableString(getKey(@"use_current_unavailable"), @"Use current (unavailable)");

        /// <summary>
        /// "Distance Snap"
        /// </summary>
        public static LocalisableString DistanceSnap => new TranslatableString(getKey(@"distance_snap"), @"Distance Snap");

        /// <summary>
        /// "{0} may be called only once for a single {1} instance."
        /// </summary>
        public static LocalisableString MayBeCalledOnlyOnce(string arg0, string arg1) => new TranslatableString(getKey(@"may_be_called_only_once"), @"{0} may be called only once for a single {1} instance.", arg0, arg1);

        /// <summary>
        /// "snapping"
        /// </summary>
        public static LocalisableString Snapping => new TranslatableString(getKey(@"snapping"), @"snapping");

        /// <summary>
        /// "{0} may be called only once for a single {1} instance."
        /// </summary>
        public static LocalisableString MayBeCalledOnlyOnce1(string arg0, string arg1) => new TranslatableString(getKey(@"may_be_called_only_once1"), @"{0} may be called only once for a single {1} instance.", arg0, arg1);

        /// <summary>
        /// "{0} may be called only once for a single {1} instance."
        /// </summary>
        public static LocalisableString MayBeCalledOnlyOnce2(string arg0, string arg1) => new TranslatableString(getKey(@"may_be_called_only_once2"), @"{0} may be called only once for a single {1} instance.", arg0, arg1);

        private static string getKey(string key) => $@"{prefix}:{key}";
    }
}