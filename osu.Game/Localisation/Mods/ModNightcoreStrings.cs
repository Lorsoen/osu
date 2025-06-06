// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using osu.Framework.Localisation;

namespace osu.Game.Localisation.Mods
{
    public static class ModNightcoreStrings
    {
        private const string prefix = @"osu.Game.Resources.Localisation.Mods.ModNightcore";

        /// <summary>
        /// "Uguuuuuuuu..."
        /// </summary>
        public static LocalisableString Uguuuuuuuu => new TranslatableString(getKey(@"uguuuuuuuu"), @"Uguuuuuuuu...");

        /// <summary>
        /// "Speed increase"
        /// </summary>
        public static LocalisableString SpeedIncrease => new TranslatableString(getKey(@"speed_increase"), @"Speed increase");

        /// <summary>
        /// "The actual increase to apply"
        /// </summary>
        public static LocalisableString TheActualIncreaseToApply => new TranslatableString(getKey(@"the_actual_increase_to_apply"), @"The actual increase to apply");

        private static string getKey(string key) => $@"{prefix}:{key}";
    }
}
