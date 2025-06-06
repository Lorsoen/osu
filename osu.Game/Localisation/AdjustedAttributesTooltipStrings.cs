// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using osu.Framework.Localisation;

namespace osu.Game.Localisation
{
    public static class AdjustedAttributesTooltipStrings
    {
        private const string prefix = @"osu.Game.Resources.Localisation.AdjustedAttributesTooltip";

        /// <summary>
        /// "One or more values are being adjusted by mods."
        /// </summary>
        public static LocalisableString OneOrMoreValuesAre => new TranslatableString(getKey(@"one_or_more_values_are"), @"One or more values are being adjusted by mods.");

        private static string getKey(string key) => $@"{prefix}:{key}";
    }
}