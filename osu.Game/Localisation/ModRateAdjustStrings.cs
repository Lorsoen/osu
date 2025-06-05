// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using osu.Framework.Localisation;

namespace osu.Game.Localisation
{
    public static class ModRateAdjustStrings
    {
        private const string prefix = @"osu.Game.Resources.Localisation.ModRateAdjust";

        /// <summary>
        /// "Speed change"
        /// </summary>
        public static LocalisableString SpeedChange => new TranslatableString(getKey(@"speed_change"), @"Speed change");

        private static string getKey(string key) => $@"{prefix}:{key}";
    }
}